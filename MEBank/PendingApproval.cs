using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MEBank
{
    public partial class PendingApproval : UserControl
    {
        Dictionary<string, string> data;
        Main m = new Main();

        public PendingApproval(Dictionary<string, string> returnData)
        {
            InitializeComponent();
            data = returnData;
            lblAccType.Text = "Type : " + data["@AccountType"] + " / User ID : " + data["@LoggedInID"];
            loadPendingTransactions();
        }

        private void loadPendingTransactions()
        {
            try
            {
                dgvPending.Rows.Clear();

                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@ParentCustomerID", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, data["@CustomerID"]));

                List<string> dataList = new List<string>();
                dataList.Add("PendingTransactionID");
                dataList.Add("KidsIBANNo");
                dataList.Add("DestIBANNo");
                dataList.Add("TransactionType");
                dataList.Add("Amount");
                dataList.Add("RequestDate");
                dataList.Add("RequestUser");

                // ExecuteSP Query mode returns key=value, value=columnName
                // We need all rows, so we use a direct query approach via the SP
                var connection = m.GetConnectionStrings();
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("SPA_getPendingTransactions", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@ParentCustomerID", SqlDbType.VarChar, 20) { Value = data["@CustomerID"] });
                        command.Parameters.Add(new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@ErrorMsg", SqlDbType.VarChar, 1000) { Direction = ParameterDirection.Output });

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvPending.Rows.Add(
                                    reader["PendingTransactionID"].ToString(),
                                    reader["KidsIBANNo"].ToString(),
                                    reader["DestIBANNo"].ToString(),
                                    reader["TransactionType"].ToString(),
                                    reader["Amount"].ToString(),
                                    reader["RequestDate"].ToString(),
                                    reader["RequestUser"].ToString()
                                );
                            }
                        }
                    }
                }
                finally
                {
                    connection.Close();
                }

                if (dgvPending.Rows.Count == 0)
                {
                    MessageBox.Show("No pending transactions to review.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reviewTransaction(string action)
        {
            if (dgvPending.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to " + action.ToLower(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string pendingID = dgvPending.SelectedRows[0].Cells["colPendingID"].Value.ToString();
            string amount = dgvPending.SelectedRows[0].Cells["colAmount"].Value.ToString();
            string kidsIBAN = dgvPending.SelectedRows[0].Cells["colKidsIBAN"].Value.ToString();

            string confirmMsg = action == "Approve"
                ? $"Approve transfer of {amount} from Kids account {kidsIBAN}?"
                : $"Reject transfer of {amount} from Kids account {kidsIBAN}?";

            if (MessageBox.Show(confirmMsg, "Confirm " + action, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@PendingTransactionID", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, pendingID));
                param.Add(new SqlParameter("@Action", SqlDbType.VarChar, 10, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, action));
                param.Add(new SqlParameter("@ReviewUser", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, data["@LoggedInID"]));
                param.Add(new SqlParameter("@Notes", SqlDbType.VarChar, 500, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtNotes.Text.Equals("") ? (object)DBNull.Value : txtNotes.Text));

                m.ExecuteSP("SPA_reviewPendingTransaction", param, "PendingApproval", "Check", new List<string>());

                MessageBox.Show("Transaction " + action.ToLower() + "d successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNotes.Clear();
                loadPendingTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fnApprove(object sender, EventArgs e)
        {
            reviewTransaction("Approve");
        }

        private void fnReject(object sender, EventArgs e)
        {
            reviewTransaction("Reject");
        }

        private void fnRefresh(object sender, EventArgs e)
        {
            loadPendingTransactions();
        }

        private void fnBack(object sender, EventArgs e)
        {
            Profile screen = new Profile(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }
    }
}
