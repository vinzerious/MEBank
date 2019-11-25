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
    public partial class Login : UserControl
    {
        public string AccountType = "";
        Dictionary<string, string> data = new Dictionary<string, string>();
        public Login()
        {
            InitializeComponent();
            //For test
            //txtUsername.Text = "banksystemadmin";
            //txtPassword.Text = "MEBank[00001]";
        }

        private void fnRegister(object sender, EventArgs e)
        {
            data.Add("@AccountType","New");
            RegisterIMEBank screen = new RegisterIMEBank(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }

        private void fnLogin(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text.Equals(""))
                {
                    MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }

                if (txtPassword.Text.Equals(""))
                {
                    MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }

                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@usr", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtUsername.Text));
                param.Add(new SqlParameter("@pwd", SqlDbType.VarChar, 30, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtPassword.Text));
                param.Add(new SqlParameter("@AccountType", SqlDbType.VarChar, 10, ParameterDirection.Output, false, 0, 0, null, DataRowVersion.Current, ""));
                param.Add(new SqlParameter("@CustomerID", SqlDbType.VarChar, 50, ParameterDirection.Output, false, 0, 0, null, DataRowVersion.Current, ""));

                //List of return data
                List<String> dataList = new List<string>();
                dataList.Add("@AccountType");
                dataList.Add("@CustomerID");

                Main m = new Main();
                data = m.ExecuteSP("SPL_checkLogin", param, "Login", "Check", dataList);
                m.AccountType = data["@AccountType"];
                MessageBox.Show("You have logged in");
                data["@LoggedInID"] = txtUsername.Text;

                Profile screen = new Profile(data);
                this.Hide();
                this.Parent.Controls.Add(screen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
