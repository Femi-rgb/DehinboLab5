namespace SimpleWageCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblGrossPay = new Label();
            txtHoursWorked = new TextBox();
            txtHourlyRate = new TextBox();
            btnCalculatePay = new Button();
            btnReset = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 31);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 0;
            label1.Text = "Number of Hours Worked:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 78);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 1;
            label2.Text = "Hourly Pay Rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 123);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Gross Pay:";
            // 
            // lblGrossPay
            // 
            lblGrossPay.BorderStyle = BorderStyle.FixedSingle;
            lblGrossPay.Location = new Point(289, 122);
            lblGrossPay.Name = "lblGrossPay";
            lblGrossPay.Size = new Size(201, 26);
            lblGrossPay.TabIndex = 3;
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Location = new Point(289, 28);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(200, 27);
            txtHoursWorked.TabIndex = 4;
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Location = new Point(289, 75);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(200, 27);
            txtHourlyRate.TabIndex = 5;
            // 
            // btnCalculatePay
            // 
            btnCalculatePay.Location = new Point(62, 180);
            btnCalculatePay.Name = "btnCalculatePay";
            btnCalculatePay.Size = new Size(114, 68);
            btnCalculatePay.TabIndex = 6;
            btnCalculatePay.Text = "&Calculate Gross Pay";
            btnCalculatePay.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(220, 180);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(114, 68);
            btnReset.TabIndex = 7;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(377, 180);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(114, 68);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 288);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnCalculatePay);
            Controls.Add(txtHourlyRate);
            Controls.Add(txtHoursWorked);
            Controls.Add(lblGrossPay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wage Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblGrossPay;
        private TextBox txtHoursWorked;
        private TextBox txtHourlyRate;
        private Button btnCalculatePay;
        private Button btnReset;
        private Button btnExit;
    }
}
