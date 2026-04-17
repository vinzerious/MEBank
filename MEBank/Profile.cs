using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEBank
{
    public partial class Profile : UserControl
    {
        public String AccountType;
        Dictionary<string, string> data;
        public Profile(Dictionary<string, string> returnData)
        {
            InitializeComponent();
            data = returnData;
            AccountType = data["@AccountType"];
            lblAccType.Text = "Type : " + AccountType + " / User ID : " + data["@LoggedInID"];

            if (AccountType.Equals("Admin"))
            {
                btnRegisterBankOfficer.Visible = true;
                btnRegisterCustomer.Visible = false;
            }
            else if (AccountType.Equals("Bank"))
            {
                btnRegisterBankOfficer.Visible = false;
                btnRegisterCustomer.Visible = true;
            }
            else if (AccountType.Equals("Customer"))
            {
                btnTransfer.Visible = true;
                btnWithdraw.Visible = true;
                btnDeposit.Visible = false;
                btnParentalControl.Visible = true;
                btnPendingApproval.Visible = true;
                btnLoanRequest.Visible = true;
            }
            else if (AccountType.Equals("LoanApprover"))
            {
                btnLoanApproval.Visible = true;
            }

        }

        private void fnOpenAccount(object sender, EventArgs e)
        {
            OpenAccount screen = new OpenAccount(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }

        private void fnLogout(object sender, EventArgs e)
        {
            Login screen = new Login();
            this.Hide();
            this.Parent.Controls.Add(screen);
        }

        private void fnRegisterBankOfficer(object sender, EventArgs e)
        {
            RegisterIMEBank screen = new RegisterIMEBank(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }

        private void fnRegisterCustomer(object sender, EventArgs e)
        {
            Register screen = new Register(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }

        private void fnTransfer(object sender, EventArgs e)
        {
            Transfer screen = new Transfer(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }

        private void fnDeposit(object sender, EventArgs e)
        {
            Deposit screen = new Deposit(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }

        private void fnWithdraw(object sender, EventArgs e)
        {
            Withdraw screen = new Withdraw(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }

        private void fnParentalControl(object sender, EventArgs e)
        {
            ParentalControlSetup screen = new ParentalControlSetup(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }

        private void fnPendingApproval(object sender, EventArgs e)
        {
            PendingApproval screen = new PendingApproval(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }

        private void fnLoanRequest(object sender, EventArgs e)
        {
            LoanRequest screen = new LoanRequest(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }

        private void fnLoanApproval(object sender, EventArgs e)
        {
            LoanApproval screen = new LoanApproval(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }
    }
}
