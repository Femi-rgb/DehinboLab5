namespace Formula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            lblInterestRate = new Label();
            btnReset = new Button();
            btnCalculate = new Button();
            label5 = new Label();
            lblYears = new Label();
            txtPresentValue = new TextBox();
            txtFutureValue = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            picFormula = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFormula).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblInterestRate);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblYears);
            groupBox1.Controls.Add(txtPresentValue);
            groupBox1.Controls.Add(txtFutureValue);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(320, 352);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Interest Rate";
            // 
            // lblInterestRate
            // 
            lblInterestRate.BorderStyle = BorderStyle.FixedSingle;
            lblInterestRate.Location = new Point(157, 214);
            lblInterestRate.Name = "lblInterestRate";
            lblInterestRate.Size = new Size(136, 26);
            lblInterestRate.TabIndex = 10;
            lblInterestRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(200, 278);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 52);
            btnReset.TabIndex = 9;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(14, 278);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 52);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 215);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 6;
            label5.Text = "Interest Rate:";
            // 
            // lblYears
            // 
            lblYears.BorderStyle = BorderStyle.FixedSingle;
            lblYears.Location = new Point(157, 157);
            lblYears.Name = "lblYears";
            lblYears.Size = new Size(136, 26);
            lblYears.TabIndex = 5;
            lblYears.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPresentValue
            // 
            txtPresentValue.Location = new Point(157, 103);
            txtPresentValue.Margin = new Padding(4);
            txtPresentValue.Name = "txtPresentValue";
            txtPresentValue.Size = new Size(136, 30);
            txtPresentValue.TabIndex = 4;
            txtPresentValue.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFutureValue
            // 
            txtFutureValue.Location = new Point(157, 44);
            txtFutureValue.Margin = new Padding(4);
            txtFutureValue.Name = "txtFutureValue";
            txtFutureValue.Size = new Size(136, 30);
            txtFutureValue.TabIndex = 3;
            txtFutureValue.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 158);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 2;
            label3.Text = "Years:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 1;
            label2.Text = "Present Value:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Future Value:";
            // 
            // picFormula
            // 
            picFormula.Image = (Image)resources.GetObject("picFormula.Image");
            picFormula.Location = new Point(377, 13);
            picFormula.Name = "picFormula";
            picFormula.Size = new Size(328, 144);
            picFormula.SizeMode = PictureBoxSizeMode.Zoom;
            picFormula.TabIndex = 1;
            picFormula.TabStop = false;
            picFormula.Click += picFormula_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 385);
            Controls.Add(picFormula);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dehinbo Abdulwahab";
            Load += Form1_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFormula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblInterestRate;
        private Button btnReset;
        private Button btnCalculate;
        private Label label5;
        private Label lblYears;
        private TextBox txtPresentValue;
        private TextBox txtFutureValue;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox picFormula;
    }
}
