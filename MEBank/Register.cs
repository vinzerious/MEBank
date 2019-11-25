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
    public partial class Register : UserControl
    {
        Dictionary<string, string> data;
        Main m = new Main();
        public Register(Dictionary<string, string> returnData)
        {
            InitializeComponent();
            data = returnData;
            //getCustomerID();
        }

        private void fnBack(object sender, EventArgs e)
        {
            Login screen = new Login();
            this.Hide();
            this.Parent.Controls.Add(screen);
        }

        private void fnRegister(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Equals(""))
                {
                    MessageBox.Show("Please enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    return;
                }

                if (txtSurname.Text.Equals(""))
                {
                    MessageBox.Show("Please enter surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurname.Focus();
                    return;
                }

                if (txtIDNo.Text.Equals(""))
                {
                    MessageBox.Show("Please enter ID No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIDNo.Focus();
                    return;
                }

                if (txtAddress.Text.Equals(""))
                {
                    MessageBox.Show("Please enter address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
                    return;
                }

                if (txtTelNo.Text.Equals(""))
                {
                    MessageBox.Show("Please enter telephone No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelNo.Focus();
                    return;
                }

                if (txtAddress.Text.Equals(""))
                {
                    MessageBox.Show("Please enter address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelNo.Focus();
                    return;
                }

                if (!m.IsNumeric(txtTelNo.Text))
                {
                    MessageBox.Show("Please input only numeric in telephone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelNo.Focus();
                    return;
                }

                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@Name", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtName.Text));
                param.Add(new SqlParameter("@MiddleName", SqlDbType.VarChar, 30, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtMiddleName.Text));
                param.Add(new SqlParameter("@Surname", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtSurname.Text));
                param.Add(new SqlParameter("@IDNo", SqlDbType.VarChar, 30, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtIDNo.Text));
                param.Add(new SqlParameter("@Address", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtAddress.Text));
                param.Add(new SqlParameter("@TelNo", SqlDbType.VarChar, 30, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtTelNo.Text));
                param.Add(new SqlParameter("@AccountCreated", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, data["@LoggedInID"]));
                param.Add(new SqlParameter("@CustomerID", SqlDbType.VarChar, 50, ParameterDirection.Output, false, 0, 0, null, DataRowVersion.Current, ""));


                //List of return data
                List<String> dataList = new List<string>();
                dataList.Add("@CustomerID");

                Dictionary<string, string> dataFromSP;
                dataFromSP = m.ExecuteSP("SPR_customerRegister", param, "Register", "Check", dataList);
                MessageBox.Show("Customer register successfully : " + dataFromSP["@CustomerID"]);

                //Add data from SP into main dictionary
                foreach (var item in dataFromSP)
                {
                    data[item.Key] = item.Value;
                }
                DialogResult result = MessageBox.Show("Do you want to create new bank account ?", "Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    OpenAccount screen = new OpenAccount(data);
                    this.Hide();
                    this.Parent.Controls.Add(screen);
                }
                clearScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ex.Message.Contains("ID"))
                {
                    txtIDNo.Clear();
                    txtIDNo.Focus();
                }
                else if (ex.Message.Contains("Telephone"))
                {
                    txtTelNo.Clear();
                    txtTelNo.Focus();
                } 
            }
        }

        private void getCustomerID()
        {
            List<SqlParameter> param = new List<SqlParameter>();
            Main m = new Main();
            param.Add(new SqlParameter("@CustomerID", SqlDbType.VarChar, 50, ParameterDirection.Output, false, 0, 0, null, DataRowVersion.Current, ""));

            //List of return data
            List<String> dataList = new List<string>();
            dataList.Add("@CustomerID");
            Dictionary<string, string> dataFromSP;
            dataFromSP = m.ExecuteSP("SPR_getCustomerID", param, "Register", "Check", dataList);

            //Add data from SP into main dictionary
            foreach (var item in dataFromSP)
            {
                data[item.Key] = item.Value;
            }

            txtCustomerID.Text = data["@CustomerID"];
            clearScreen();
        }

        private void clearScreen()
        {
            txtName.Text = "";
            txtMiddleName.Text = "";
            txtSurname.Text = "";
            txtIDNo.Text = "";
            txtAddress.Text = "";
            txtTelNo.Text = "";
        }
    }
}
