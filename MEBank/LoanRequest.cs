using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MEBank
{
    public partial class LoanRequest : UserControl
    {
        Dictionary<string, string> data;
        Main m = new Main();

        public LoanRequest(Dictionary<string, string> returnData)
        {
            InitializeComponent();
            data = returnData;
            lblAccType.Text = "Type : " + data["@AccountType"] + " / User ID : " + data["@LoggedInID"];
            loadMyLoanRequests();
        }

        private void loadMyLoanRequests()
        {
            try
            {
                dgvMyLoans.Rows.Clear();

                var connection = m.GetConnectionStrings();
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("SPL_getMyLoanRequests", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.VarChar, 50) { Value = data["@CustomerID"] });
                        command.Parameters.Add(new SqlParameter("@Result", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@ErrorMsg", SqlDbType.VarChar, 1000) { Direction = ParameterDirection.Output });

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvMyLoans.Rows.Add(
                                    reader["LoanRequestID"].ToString(),
                                    reader["LoanAmount"].ToString(),
                                    reader["LoanPurpose"].ToString(),
                                    reader["LoanTermMonths"].ToString() + " months",
                                    reader["MonthlySalary"].ToString(),
                                    reader["MaxLoanEligible"].ToString(),
                                    reader["FinancialScore"].ToString(),
                                    reader["ScoreGrade"].ToString(),
                                    reader["Status"].ToString(),
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fnSubmit(object sender, EventArgs e)
        {
            if (!validateForm()) return;

            decimal loanAmount  = decimal.Parse(txtLoanAmount.Text);
            decimal salary      = decimal.Parse(txtMonthlySalary.Text);
            decimal maxEligible = salary * 5;

            if (loanAmount > maxEligible)
            {
                MessageBox.Show(
                    $"Loan amount exceeds the maximum eligible amount of {maxEligible:N2} (5× monthly salary).",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string confirmMsg = $"Submit loan request for {loanAmount:N2}?\n" +
                                $"Term: {cmbLoanTerm.SelectedItem} months\n" +
                                $"Financial score will be calculated automatically.";

            if (MessageBox.Show(confirmMsg, "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                List<SqlParameter> param = new List<SqlParameter>
                {
                    new SqlParameter("@CustomerID",          SqlDbType.VarChar, 50,   ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, data["@CustomerID"]),
                    new SqlParameter("@LoanAmount",          SqlDbType.Money,   0,    ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, loanAmount),
                    new SqlParameter("@LoanPurpose",         SqlDbType.VarChar, 500,  ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, txtLoanPurpose.Text.Trim()),
                    new SqlParameter("@LoanTermMonths",      SqlDbType.Int,     0,    ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, int.Parse(cmbLoanTerm.SelectedItem.ToString())),
                    new SqlParameter("@MonthlySalary",       SqlDbType.Money,   0,    ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, salary),
                    new SqlParameter("@DocumentDescription", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current,
                        string.IsNullOrWhiteSpace(txtDocumentDescription.Text) ? (object)DBNull.Value : txtDocumentDescription.Text.Trim()),
                    new SqlParameter("@RequestUser",         SqlDbType.VarChar, 50,   ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, data["@LoggedInID"]),
                    new SqlParameter("@LoanRequestID",       SqlDbType.VarChar, 50) { Direction = ParameterDirection.Output },
                    new SqlParameter("@FinancialScore",      SqlDbType.Decimal) { Direction = ParameterDirection.Output, Precision = 5, Scale = 2 },
                    new SqlParameter("@ScoreGrade",          SqlDbType.VarChar, 10) { Direction = ParameterDirection.Output },
                    new SqlParameter("@MaxLoanEligible",     SqlDbType.Money) { Direction = ParameterDirection.Output }
                };

                List<string> dataList = new List<string> { "@LoanRequestID", "@FinancialScore", "@ScoreGrade", "@MaxLoanEligible" };
                Dictionary<string, string> result = m.ExecuteSP("SPL_submitLoanRequest", param, "LoanRequest", "Check", dataList);

                string score = result["@FinancialScore"];
                string grade = result["@ScoreGrade"];
                string reqID = result["@LoanRequestID"];

                MessageBox.Show(
                    $"Loan request submitted successfully!\n\n" +
                    $"Request ID   : {reqID}\n" +
                    $"Financial Score : {score} ({grade})\n\n" +
                    "Your request is pending review by a Loan Approver.",
                    "Submission Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearForm();
                loadMyLoanRequests();
                tabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validateForm()
        {
            if (string.IsNullOrWhiteSpace(txtLoanAmount.Text) || !decimal.TryParse(txtLoanAmount.Text, out _))
            {
                MessageBox.Show("Please enter a valid loan amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoanAmount.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLoanPurpose.Text))
            {
                MessageBox.Show("Please enter the loan purpose.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLoanPurpose.Focus();
                return false;
            }
            if (cmbLoanTerm.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a loan term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLoanTerm.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMonthlySalary.Text) || !decimal.TryParse(txtMonthlySalary.Text, out decimal sal) || sal <= 0)
            {
                MessageBox.Show("Please enter a valid monthly salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonthlySalary.Focus();
                return false;
            }
            return true;
        }

        private void clearForm()
        {
            txtLoanAmount.Clear();
            txtLoanPurpose.Clear();
            cmbLoanTerm.SelectedIndex = -1;
            txtMonthlySalary.Clear();
            txtDocumentDescription.Clear();
            lblMaxEligible.Text = "Max eligible: —";
        }

        private void onSalaryOrAmountChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMonthlySalary.Text, out decimal salary) && salary > 0)
            {
                decimal max = salary * 5;
                lblMaxEligible.Text = $"Max eligible: {max:N2}";
                lblMaxEligible.ForeColor = System.Drawing.Color.FromArgb(0, 103, 192);
            }
            else
            {
                lblMaxEligible.Text = "Max eligible: —";
                lblMaxEligible.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            }
        }

        private void fnRefresh(object sender, EventArgs e)
        {
            loadMyLoanRequests();
        }

        private void fnBack(object sender, EventArgs e)
        {
            Profile screen = new Profile(data);
            this.Hide();
            this.Parent.Controls.Add(screen);
        }
    }
}
