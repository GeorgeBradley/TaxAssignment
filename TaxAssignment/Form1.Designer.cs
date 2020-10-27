namespace TaxAssignment {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.annualSalaryLabel = new System.Windows.Forms.Label();
            this.annualSalaryTB = new System.Windows.Forms.TextBox();
            this.incomeTaxGB = new System.Windows.Forms.GroupBox();
            this.incomeTaxNoRB = new System.Windows.Forms.RadioButton();
            this.incomeTaxYesRB = new System.Windows.Forms.RadioButton();
            this.studentLoanGB = new System.Windows.Forms.GroupBox();
            this.studentLoanNoRB = new System.Windows.Forms.RadioButton();
            this.studentLoanYesRB = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTakeHomePay = new System.Windows.Forms.Label();
            this.lblStudentLoan = new System.Windows.Forms.Label();
            this.lblNationalInsurance = new System.Windows.Forms.Label();
            this.lblIncomeTax = new System.Windows.Forms.Label();
            this.lblBand = new System.Windows.Forms.Label();
            this.lblAnnualSalary = new System.Windows.Forms.Label();
            this.incomeTaxGB.SuspendLayout();
            this.studentLoanGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // annualSalaryLabel
            // 
            this.annualSalaryLabel.AutoSize = true;
            this.annualSalaryLabel.Location = new System.Drawing.Point(62, 7);
            this.annualSalaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.annualSalaryLabel.Name = "annualSalaryLabel";
            this.annualSalaryLabel.Size = new System.Drawing.Size(84, 13);
            this.annualSalaryLabel.TabIndex = 0;
            this.annualSalaryLabel.Text = "Annual Salary: £";
            // 
            // annualSalaryTB
            // 
            this.annualSalaryTB.Location = new System.Drawing.Point(150, 4);
            this.annualSalaryTB.Margin = new System.Windows.Forms.Padding(2);
            this.annualSalaryTB.Name = "annualSalaryTB";
            this.annualSalaryTB.Size = new System.Drawing.Size(76, 20);
            this.annualSalaryTB.TabIndex = 1;
            this.annualSalaryTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.annualSalaryTB_KeyPress);
            // 
            // incomeTaxGB
            // 
            this.incomeTaxGB.Controls.Add(this.incomeTaxNoRB);
            this.incomeTaxGB.Controls.Add(this.incomeTaxYesRB);
            this.incomeTaxGB.Location = new System.Drawing.Point(9, 35);
            this.incomeTaxGB.Margin = new System.Windows.Forms.Padding(2);
            this.incomeTaxGB.Name = "incomeTaxGB";
            this.incomeTaxGB.Padding = new System.Windows.Forms.Padding(2);
            this.incomeTaxGB.Size = new System.Drawing.Size(250, 40);
            this.incomeTaxGB.TabIndex = 2;
            this.incomeTaxGB.TabStop = false;
            this.incomeTaxGB.Text = "Do you pay Income Tax?";
            // 
            // incomeTaxNoRB
            // 
            this.incomeTaxNoRB.AutoSize = true;
            this.incomeTaxNoRB.Location = new System.Drawing.Point(141, 17);
            this.incomeTaxNoRB.Margin = new System.Windows.Forms.Padding(2);
            this.incomeTaxNoRB.Name = "incomeTaxNoRB";
            this.incomeTaxNoRB.Size = new System.Drawing.Size(39, 17);
            this.incomeTaxNoRB.TabIndex = 1;
            this.incomeTaxNoRB.TabStop = true;
            this.incomeTaxNoRB.Text = "No";
            this.incomeTaxNoRB.UseVisualStyleBackColor = true;
            // 
            // incomeTaxYesRB
            // 
            this.incomeTaxYesRB.AutoSize = true;
            this.incomeTaxYesRB.Location = new System.Drawing.Point(4, 18);
            this.incomeTaxYesRB.Margin = new System.Windows.Forms.Padding(2);
            this.incomeTaxYesRB.Name = "incomeTaxYesRB";
            this.incomeTaxYesRB.Size = new System.Drawing.Size(43, 17);
            this.incomeTaxYesRB.TabIndex = 0;
            this.incomeTaxYesRB.TabStop = true;
            this.incomeTaxYesRB.Text = "Yes";
            this.incomeTaxYesRB.UseVisualStyleBackColor = true;
            // 
            // studentLoanGB
            // 
            this.studentLoanGB.Controls.Add(this.studentLoanNoRB);
            this.studentLoanGB.Controls.Add(this.studentLoanYesRB);
            this.studentLoanGB.Location = new System.Drawing.Point(11, 89);
            this.studentLoanGB.Margin = new System.Windows.Forms.Padding(2);
            this.studentLoanGB.Name = "studentLoanGB";
            this.studentLoanGB.Padding = new System.Windows.Forms.Padding(2);
            this.studentLoanGB.Size = new System.Drawing.Size(248, 40);
            this.studentLoanGB.TabIndex = 3;
            this.studentLoanGB.TabStop = false;
            this.studentLoanGB.Text = "Do you pay a Student Loan?";
            // 
            // studentLoanNoRB
            // 
            this.studentLoanNoRB.AutoSize = true;
            this.studentLoanNoRB.Location = new System.Drawing.Point(139, 17);
            this.studentLoanNoRB.Margin = new System.Windows.Forms.Padding(2);
            this.studentLoanNoRB.Name = "studentLoanNoRB";
            this.studentLoanNoRB.Size = new System.Drawing.Size(39, 17);
            this.studentLoanNoRB.TabIndex = 2;
            this.studentLoanNoRB.TabStop = true;
            this.studentLoanNoRB.Text = "No";
            this.studentLoanNoRB.UseVisualStyleBackColor = true;
            // 
            // studentLoanYesRB
            // 
            this.studentLoanYesRB.AutoSize = true;
            this.studentLoanYesRB.Location = new System.Drawing.Point(4, 18);
            this.studentLoanYesRB.Margin = new System.Windows.Forms.Padding(2);
            this.studentLoanYesRB.Name = "studentLoanYesRB";
            this.studentLoanYesRB.Size = new System.Drawing.Size(43, 17);
            this.studentLoanYesRB.TabIndex = 1;
            this.studentLoanYesRB.TabStop = true;
            this.studentLoanYesRB.Text = "Yes";
            this.studentLoanYesRB.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(110, 134);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(64, 26);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Annual Salary: £";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Band:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Income Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "National Insurance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Student Loan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Take Home Pay:";
            // 
            // lblTakeHomePay
            // 
            this.lblTakeHomePay.AutoSize = true;
            this.lblTakeHomePay.Location = new System.Drawing.Point(138, 367);
            this.lblTakeHomePay.Name = "lblTakeHomePay";
            this.lblTakeHomePay.Size = new System.Drawing.Size(13, 13);
            this.lblTakeHomePay.TabIndex = 16;
            this.lblTakeHomePay.Text = "0";
            // 
            // lblStudentLoan
            // 
            this.lblStudentLoan.AutoSize = true;
            this.lblStudentLoan.Location = new System.Drawing.Point(138, 330);
            this.lblStudentLoan.Name = "lblStudentLoan";
            this.lblStudentLoan.Size = new System.Drawing.Size(13, 13);
            this.lblStudentLoan.TabIndex = 15;
            this.lblStudentLoan.Text = "0";
            // 
            // lblNationalInsurance
            // 
            this.lblNationalInsurance.AutoSize = true;
            this.lblNationalInsurance.Location = new System.Drawing.Point(138, 296);
            this.lblNationalInsurance.Name = "lblNationalInsurance";
            this.lblNationalInsurance.Size = new System.Drawing.Size(13, 13);
            this.lblNationalInsurance.TabIndex = 14;
            this.lblNationalInsurance.Text = "0";
            // 
            // lblIncomeTax
            // 
            this.lblIncomeTax.AutoSize = true;
            this.lblIncomeTax.Location = new System.Drawing.Point(138, 261);
            this.lblIncomeTax.Name = "lblIncomeTax";
            this.lblIncomeTax.Size = new System.Drawing.Size(13, 13);
            this.lblIncomeTax.TabIndex = 13;
            this.lblIncomeTax.Text = "0";
            // 
            // lblBand
            // 
            this.lblBand.AutoSize = true;
            this.lblBand.Location = new System.Drawing.Point(138, 231);
            this.lblBand.Name = "lblBand";
            this.lblBand.Size = new System.Drawing.Size(13, 13);
            this.lblBand.TabIndex = 12;
            this.lblBand.Text = "0";
            // 
            // lblAnnualSalary
            // 
            this.lblAnnualSalary.AutoSize = true;
            this.lblAnnualSalary.Location = new System.Drawing.Point(138, 198);
            this.lblAnnualSalary.Name = "lblAnnualSalary";
            this.lblAnnualSalary.Size = new System.Drawing.Size(13, 13);
            this.lblAnnualSalary.TabIndex = 11;
            this.lblAnnualSalary.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 467);
            this.Controls.Add(this.lblTakeHomePay);
            this.Controls.Add(this.lblStudentLoan);
            this.Controls.Add(this.lblNationalInsurance);
            this.Controls.Add(this.lblIncomeTax);
            this.Controls.Add(this.lblBand);
            this.Controls.Add(this.lblAnnualSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.studentLoanGB);
            this.Controls.Add(this.incomeTaxGB);
            this.Controls.Add(this.annualSalaryTB);
            this.Controls.Add(this.annualSalaryLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.incomeTaxGB.ResumeLayout(false);
            this.incomeTaxGB.PerformLayout();
            this.studentLoanGB.ResumeLayout(false);
            this.studentLoanGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label annualSalaryLabel;
        private System.Windows.Forms.TextBox annualSalaryTB;
        private System.Windows.Forms.GroupBox incomeTaxGB;
        private System.Windows.Forms.RadioButton incomeTaxNoRB;
        private System.Windows.Forms.RadioButton incomeTaxYesRB;
        private System.Windows.Forms.GroupBox studentLoanGB;
        private System.Windows.Forms.RadioButton studentLoanNoRB;
        private System.Windows.Forms.RadioButton studentLoanYesRB;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTakeHomePay;
        private System.Windows.Forms.Label lblStudentLoan;
        private System.Windows.Forms.Label lblNationalInsurance;
        private System.Windows.Forms.Label lblIncomeTax;
        private System.Windows.Forms.Label lblBand;
        private System.Windows.Forms.Label lblAnnualSalary;
    }
}

