using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MEBank
{
    public partial class ParentalControlSetup : UserControl
    {
        Dictionary<string, string> data;
        Main m = new Main();

        public ParentalControlSetup(Dictionary<string, string> returnData)
        {
            InitializeComponent();
            data = returnData;
            lblAccType.Text = "Type : " + data["@AccountType"] + " / User ID : " + data["@LoggedInID"];
        }

        private void fnLoadSettings(object sender, EventArgs e)
        {
            if (txtKidsIBANNo.Text.Equals(""))
            {
                MessageBox.Show("Please enter the Kids Account IBAN No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKidsIBANNo.Focus();
                return;
            }

            try
            {
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@KidsIBANNo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtKidsIBANNo.Text));

                List<string> dataList = new List<string>();
                dataList.Add("KidsIBANNo");
                dataList.Add("ParentCustomerID");
                dataList.Add("TransactionLimit");
                dataList.Add("RequireApproval");
                dataList.Add("ParentName");

                Dictionary<string, string> result = m.ExecuteSP("SPR_getParentalControl", param, "ParentalControl", "Query", dataList);

                if (result.Count == 0)
                {
                    grpCurrentSettings.Visible = false;
                    lblStatusMsg.Text = "No parental control set for this account yet.";
                    lblStatusMsg.ForeColor = System.Drawing.Color.DarkOrange;
                    return;
                }

                // result keys are values, values are column names (per ExecuteSP Query mode)
                string kidsIBAN = "", parentID = "", limit = "", approval = "", parentName = "";
                foreach (var item in result)
                {
                    if (item.Value == "KidsIBANNo") kidsIBAN = item.Key;
                    else if (item.Value == "ParentCustomerID") parentID = item.Key;
                    else if (item.Value == "TransactionLimit") limit = item.Key;
                    else if (item.Value == "RequireApproval") approval = item.Key;
                    else if (item.Value == "ParentName") parentName = item.Key;
                }

                lblCurrentKidsIBAN.Text = "Kids IBAN: " + kidsIBAN;
                lblCurrentParent.Text = "Parent: " + parentName + " (" + parentID + ")";
                lblCurrentLimit.Text = "Transaction Limit: " + (string.IsNullOrEmpty(limit) ? "No limit" : limit);
                lblCurrentApproval.Text = "Require Approval: " + (approval == "True" || approval == "1" ? "Yes" : "No");

                // Pre-fill form
                txtTransactionLimit.Text = limit;
                chkRequireApproval.Checked = (approval == "True" || approval == "1");

                grpCurrentSettings.Visible = true;
                lblStatusMsg.Text = "Settings loaded.";
                lblStatusMsg.ForeColor = System.Drawing.Color.DarkBlue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fnSave(object sender, EventArgs e)
        {
            if (txtKidsIBANNo.Text.Equals(""))
            {
                MessageBox.Show("Please enter the Kids Account IBAN No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKidsIBANNo.Focus();
                return;
            }

            if (!txtTransactionLimit.Text.Equals("") && !m.IsNumeric(txtTransactionLimit.Text))
            {
                MessageBox.Show("Transaction limit must be a numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTransactionLimit.Focus();
                return;
            }

            try
            {
                object limitValue = DBNull.Value;
                if (!txtTransactionLimit.Text.Equals(""))
                    limitValue = decimal.Parse(txtTransactionLimit.Text);

                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@KidsIBANNo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtKidsIBANNo.Text));
                param.Add(new SqlParameter("@ParentCustomerID", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, data["@CustomerID"]));
                param.Add(new SqlParameter("@TransactionLimit", SqlDbType.Money, 0, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, limitValue));
                param.Add(new SqlParameter("@RequireApproval", SqlDbType.Bit, 0, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, chkRequireApproval.Checked ? 1 : 0));
                param.Add(new SqlParameter("@CreatedUser", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, data["@LoggedInID"]));

                m.ExecuteSP("SPR_setParentalControl", param, "ParentalControl", "Check", new List<string>());

                lblStatusMsg.Text = "Parental control settings saved successfully.";
                lblStatusMsg.ForeColor = System.Drawing.Color.Green;
                MessageBox.Show("Parental control settings saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fnLoadSettings(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fnBack(object sender, EventArgs e)
        {
            Profile screen = new Profile(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }
    }
}
