using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MEBank
{
    public partial class RegisterIMEBank : UserControl
    {
        public String AccountType;
        Dictionary<string, string> data;
        Main m = new Main();
        public RegisterIMEBank(Dictionary<string, string> returnData)
        {
            InitializeComponent();
            data = returnData;
            AccountType = returnData["@AccountType"];
            if (AccountType.Equals("Admin"))
            {
                lblScreen.Text = "Bank Officer registration";
                lblVerify.Text = "Officer ID";
                txtCustomerID.Enabled = false;
                btnAccVerify.Visible = false;
                cmbAccType.Items.Add("Admin");
                cmbAccType.Items.Add("Bank");
            }
            else if (AccountType.Equals("Bank"))
            {
                lblScreen.Text = "Customer registration";
                lblVerify.Text = "Customer ID";
                txtCustomerID.Enabled = true;
                btnAccVerify.Visible = true;
                cmbAccType.Items.Add("Customer");
                cmbAccType.Items.Add("Business");
            }
            else if (AccountType.Equals("New"))
            {
                lblScreen.Text = "Customer registration";
                lblVerify.Text = "Customer ID";
                txtCustomerID.Enabled = true;
                btnAccVerify.Visible = true;
                cmbAccType.Items.Add("Customer");
            }
        }

        private void fnBack(object sender, EventArgs e)
        {
            if (AccountType.Equals("New"))
            {
                Login screen = new Login();
                this.Hide();
                this.Parent.Controls.Add(screen);
            }
            else
            {
                Profile screen = new Profile(data);
                this.Hide();
                this.Parent.Controls.Add(screen);
            }
            
        }

        private void fnRegister(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text.Equals(""))
                {
                    MessageBox.Show("Please enter User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserID.Focus();
                    return;
                }

                if (txtPassword.Text.Equals(""))
                {
                    MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }

                if (cmbAccType.SelectedIndex.Equals(null))
                {
                    MessageBox.Show("Please select account type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbAccType.Focus();
                    return;
                }

                if (AccountType.Equals("New"))
                {
                    data["@LoggedInID"] = txtUserID.Text;
                }

                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@usr", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtUserID.Text));
                param.Add(new SqlParameter("@pwd", SqlDbType.VarChar, 30, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtPassword.Text));
                param.Add(new SqlParameter("@CustomerID", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtCustomerID.Text));
                param.Add(new SqlParameter("@AccountType", SqlDbType.VarChar, 10, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, cmbAccType.SelectedItem));
                param.Add(new SqlParameter("@AccountCreated", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, data["@LoggedInID"]));
                param.Add(new SqlParameter("@ID", SqlDbType.VarChar, 50, ParameterDirection.Output, false, 0, 0, null, DataRowVersion.Current, null));

                //List of return data
                List<String> dataList = new List<string>();
                dataList.Add("@ID");

                Main m = new Main();
                Dictionary<string, string> dataFromSP;
                dataFromSP = m.ExecuteSP("SPR_IMERegister", param, "Login", "Check", dataList);
                txtCustomerID.Text = dataFromSP["@ID"];
                MessageBox.Show("Successfully created. " + lblVerify.Text + " is " + dataFromSP["@ID"]);

                //Add data from SP into main dictionary
                foreach (var item in dataFromSP)
                {
                    data[item.Key] = item.Value;
                }

                if (AccountType.Equals("New"))
                {
                    Login screen = new Login();
                    this.Hide();
                    this.Parent.Controls.Add(screen);
                }
                else
                {
                    Profile screen = new Profile(data);
                    this.Hide();
                    this.Parent.Controls.Add(screen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Clear();
                txtPassword.Clear();
                txtUserID.Focus();
            }
        }

        private void fnVerify(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerID.Text.Equals(""))
                {
                    MessageBox.Show("Please enter Customer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerID.Focus();
                    return;
                }

                txtIDVerfiy.Visible = true;
                txtIDVerfiy.Focus();
                btnCheckIDNo.Visible = true;
            }
            catch (Exception)
            {

            }
        }

        private void fnCheckIDNo(object sender, EventArgs e)
        {
            try
            {
                if (txtIDVerfiy.Text.Equals(""))
                {
                    MessageBox.Show("Please enter Customer ID No to verfiy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIDVerfiy.Focus();
                    return;
                }

                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@CustomerID", SqlDbType.VarChar, 30, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtCustomerID.Text));
                param.Add(new SqlParameter("@IDNo", SqlDbType.VarChar, 30, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtIDVerfiy.Text));

                Dictionary<string, string> dataFromSP;
                List<String> dataList = new List<string>();
                dataFromSP = m.ExecuteSP("SPR_checkIDNo", param, "Register", "Check", dataList);
                MessageBox.Show("ID No confirmed");
                txtCustomerID.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
