using System;
using System.Windows.Forms;

namespace TaxAssignment {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void annualSalaryTB_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e) {
            string annualSalaryText = annualSalaryTB.Text;
            if (annualSalaryText == null || annualSalaryText == "") {
                MessageBox.Show("Annual Salary should be not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int annualSalary = Convert.ToInt32(annualSalaryText);           
            if (annualSalary == 0) {
                MessageBox.Show("Annual Salary should be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (incomeTaxYesRB.Checked == false && incomeTaxNoRB.Checked == false) {
                MessageBox.Show("Please enter the income tax related information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (studentLoanYesRB.Checked == false && studentLoanNoRB.Checked == false) {
                MessageBox.Show("Please enter the student loan related information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (annualSalary > 1000000)
            {
                MessageBox.Show("This ammount is far too much!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                annualSalaryTB.Text = "";
                return;
            }
            if (annualSalary > 25000 && incomeTaxYesRB.Checked == false)
            {
                MessageBox.Show("If your annual salary is greater than £25000 then you must have income tax checked as yes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (annualSalary < 25000 && studentLoanYesRB.Checked == true)
                
            {
                MessageBox.Show("You don't have to pay student loan yet!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);         
            }
            if (annualSalary < 11000 && incomeTaxYesRB.Checked == true)
            {
                MessageBox.Show("You don't have to pay income tax!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (annualSalary > 11000 && incomeTaxNoRB.Checked == true)
            {
                MessageBox.Show("You must have income tax checked as yes if you're earning £11,000 a year.", "Alert",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }           

            double incomeTax = 0, nationalInsurance = 0, studentLoan = 0, takeHomePay = 0;
            string band = "Personal Allowance";
            if (incomeTaxYesRB.Checked == true) {
                if (annualSalary > 150000) {
                    incomeTax = 0.45 * (annualSalary - 150000);
                    incomeTax += 0.40 * (150000 - 46350);
                    incomeTax += 0.20 * (46350 - 11850);
                    band = "Additional Rate";
                } else if (annualSalary > 46350 && annualSalary <= 150000) {
                    incomeTax = 0.40 * (annualSalary - 46350);
                    incomeTax += 0.20 * (46350 - 11850);
                    band = "Higher Rate";
                } else if (annualSalary > 11850 && annualSalary <= 46350) {
                    incomeTax = 0.20 * (annualSalary - 11850);
                    band = "Basic Rate";
                }
            }

            if (studentLoanYesRB.Checked == true) {
                if (annualSalary > 25000) {
                    studentLoan = 0.09 * (annualSalary - 25000);
                }
            }

            double incomePerWeek = annualSalary / 52;
            if (incomePerWeek > 892) {
                nationalInsurance = 0.02 * (annualSalary - (52 * 892));
            } else if (incomePerWeek > 162 && incomePerWeek <= 892) {
                nationalInsurance = 0.12 * (annualSalary - (52 * 162));
            }

            takeHomePay = annualSalary - incomeTax - studentLoan - nationalInsurance;

            //string outputMessage = "Annual salary: " + annualSalary;
            //outputMessage += "\nIncome Tax Band: " + band;
            //outputMessage += "\nMonthly Income Tax Amount: " + incomeTax / 12;
            //outputMessage += "\nMonthly National Insurance Amount: " + nationalInsurance / 12;
            //outputMessage += "\nMonthly Student Loan Payment: " + studentLoan / 12;
            //outputMessage += "\nMonthly Take Home Pay: " + takeHomePay / 12;

            //MessageBox.Show(outputMessage, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Close();

            lblAnnualSalary.Text = (annualSalary).ToString();
            lblBand.Text = (band);
            lblIncomeTax.Text = (incomeTax / 12).ToString();
            lblNationalInsurance.Text = (nationalInsurance / 12).ToString();
            lblStudentLoan.Text = (studentLoan / 12).ToString();
            lblTakeHomePay.Text = (takeHomePay / 12).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
