using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MEBank
{
    public partial class LoanApproval : UserControl
    {
        Dictionary<string, string> data;
        Main m = new Main();

        public LoanApproval(Dictionary<string, string> returnData)
        {
            InitializeComponent();
            data = returnData;
            lblAccType.Text = "Type : " + data["@AccountType"] + " / User ID : " + data["@LoggedInID"];
            loadLoanRequests();
        }

        private void loadLoanRequests()
        {
            try
            {
                dgvLoans.Rows.Clear();

                var connection = m.GetConnectionStrings();
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("SPL_getLoanRequests", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Result",   SqlDbType.Int)         { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@ErrorMsg", SqlDbType.VarChar, 1000) { Direction = ParameterDirection.Output });

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvLoans.Rows.Add(
                                    reader["LoanRequestID"].ToString(),
                                    reader["CustomerID"].ToString(),
                                    reader["CustomerName"].ToString(),
                                    reader["LoanAmount"].ToString(),
                                    reader["LoanPurpose"].ToString(),
                                    reader["LoanTermMonths"].ToString() + " months",
                                    reader["MonthlySalary"].ToString(),
                                    reader["MaxLoanEligible"].ToString(),
                                    reader["FinancialScore"].ToString(),
                                    reader["ScoreGrade"].ToString(),
                                    reader["DocumentDescription"].ToString(),
                                    reader["RequestDate"].ToString()
                                );
                            }
                        }
                    }
                }
                finally
                {
                    connection.Close();
                }

                if (dgvLoans.Rows.Count == 0)
                    MessageBox.Show("No pending loan requests.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reviewLoan(string action)
        {
            if (dgvLoans.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a loan request to " + action.ToLower() + ".",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string loanID      = dgvLoans.SelectedRows[0].Cells["colApprLoanID"].Value.ToString();
            string customerName = dgvLoans.SelectedRows[0].Cells["colApprCustomerName"].Value.ToString();
            string amount      = dgvLoans.SelectedRows[0].Cells["colApprAmount"].Value.ToString();
            string grade       = dgvLoans.SelectedRows[0].Cells["colApprGrade"].Value.ToString();

            string confirmMsg = action == "Approve"
                ? $"Approve loan request {loanID} for {customerName}?\nAmount: {amount}  |  Score Grade: {grade}"
                : $"Reject loan request {loanID} for {customerName}?\nAmount: {amount}  |  Score Grade: {grade}";

            if (MessageBox.Show(confirmMsg, "Confirm " + action, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                List<SqlParameter> param = new List<SqlParameter>
                {
                    new SqlParameter("@LoanRequestID", SqlDbType.VarChar, 50,   ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, loanID),
                    new SqlParameter("@Action",        SqlDbType.VarChar, 10,   ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, action),
                    new SqlParameter("@ReviewUser",    SqlDbType.VarChar, 50,   ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, data["@LoggedInID"]),
                    new SqlParameter("@ReviewNotes",   SqlDbType.VarChar, 1000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current,
                        string.IsNullOrWhiteSpace(txtReviewNotes.Text) ? (object)DBNull.Value : txtReviewNotes.Text.Trim())
                };

                m.ExecuteSP("SPL_reviewLoanRequest", param, "LoanApproval", "Check", new List<string>());

                MessageBox.Show($"Loan request {action.ToLower()}d successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtReviewNotes.Clear();
                loadLoanRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fnApprove(object sender, EventArgs e)  => reviewLoan("Approve");
        private void fnReject(object sender, EventArgs e)   => reviewLoan("Reject");
        private void fnRefresh(object sender, EventArgs e)  => loadLoanRequests();

        private void fnBack(object sender, EventArgs e)
        {
            Profile screen = new Profile(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }

        private void onRowSelected(object sender, System.Windows.Forms.DataGridViewSelectionChangedEventArgs e)
        {
            if (dgvLoans.SelectedRows.Count == 0) return;

            var row = dgvLoans.SelectedRows[0];
            lblDetailLoanID.Text    = "Request ID : " + row.Cells["colApprLoanID"].Value;
            lblDetailCustomer.Text  = "Customer   : " + row.Cells["colApprCustomerID"].Value + " — " + row.Cells["colApprCustomerName"].Value;
            lblDetailAmount.Text    = "Amount     : " + row.Cells["colApprAmount"].Value;
            lblDetailTerm.Text      = "Term       : " + row.Cells["colApprTerm"].Value;
            lblDetailSalary.Text    = "Salary     : " + row.Cells["colApprSalary"].Value + "   |   Max Eligible : " + row.Cells["colApprMaxElig"].Value;
            lblDetailScore.Text     = "Score      : " + row.Cells["colApprScore"].Value + " (" + row.Cells["colApprGrade"].Value + ")";
            lblDetailDocuments.Text = "Documents  : " + row.Cells["colApprDocuments"].Value;
            lblDetailPurpose.Text   = "Purpose    : " + row.Cells["colApprPurpose"].Value;
        }
    }
}
