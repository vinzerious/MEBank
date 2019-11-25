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
    public partial class Transfer : UserControl
    {
        public string AccountType = "";
        public String CustomerID = "";
        public String UserID = "";
        Dictionary<string, string> data = new Dictionary<string, string>();
        public Transfer(Dictionary<string, string> returnData)
        {
            InitializeComponent();
            data = returnData;
            AccountType = data["@AccountType"];
            CustomerID = data["@CustomerID"];
            UserID = data["@LoggedInID"];
            lblAccType.Text = "Type : " + AccountType + " User ID : " + UserID;
            getAccountList();
        }

        private void fnTransfer(object sender, EventArgs e)
        {
            try
            {
                if (cmbAccountList.SelectedItem.Equals(""))
                {
                    MessageBox.Show("Please select your account number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbAccountList.Focus();
                    return;
                }

                if (txtTransferTo.Text.Equals(""))
                {
                    MessageBox.Show("Please enter transfer to account number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransferTo.Focus();
                    return;
                }

                if (txtAmount.Text.Equals(""))
                {
                    MessageBox.Show("Please enter transfer amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Focus();
                    return;
                }

                if (cmbAccountList.SelectedItem.Equals(txtTransferTo.Text))
                {
                    MessageBox.Show("Please input different account number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTransferTo.Focus();
                    return;
                }

                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@TransferFrom", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, cmbAccountList.SelectedItem));
                param.Add(new SqlParameter("@TransferTo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtTransferTo.Text));
                param.Add(new SqlParameter("@Amount", SqlDbType.VarChar, 30, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtAmount.Text));
                param.Add(new SqlParameter("@TransactionCreated", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, data["@LoggedInID"]));

                //List of return data
                List<String> dataList = new List<string>();

                Main m = new Main(); 
                Dictionary<string, string> dataFromSP;
                dataFromSP = m.ExecuteSP("SPA_transfer", param, "Transfer", "Check", dataList);
                MessageBox.Show("Transferred successfully");

                getBalance(cmbAccountList.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTransferTo.Clear();
                txtAmount.Clear();
                txtTransferTo.Focus();
            }
        }

        private void getAccountList()
        {
            try
            {
                cmbAccountList.Items.Clear();

                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@CustomerID", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, CustomerID));

                //List of return data
                List<String> dataList = new List<string>();
                dataList.Add("IBANNo");

                Main m = new Main();
                Dictionary<string, string> dataFromSP;
                dataFromSP = m.ExecuteSP("SPA_getAccountList", param, "Transfer", "Query", dataList);

                foreach (var item in dataFromSP)
                {
                    cmbAccountList.Items.Add(item.Key);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getBalance(string IBANNo)
        {
            try
            {
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter("@IBANNo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, IBANNo));
                param.Add(new SqlParameter("@Amount", SqlDbType.VarChar, 30, ParameterDirection.Output, false, 0, 0, null, DataRowVersion.Current, ""));

                //List of return data
                List<String> dataList = new List<string>();
                dataList.Add("@Amount");

                Main m = new Main();
                Dictionary<string, string> dataFromSP;
                dataFromSP = m.ExecuteSP("SPA_getBalance", param, "Transfer", "Check", dataList);

                lblBalance.Text = dataFromSP["@Amount"];
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

        private void fnGetBalance(object sender, EventArgs e)
        {
            getBalance(cmbAccountList.SelectedItem.ToString());
        }
    }
}
