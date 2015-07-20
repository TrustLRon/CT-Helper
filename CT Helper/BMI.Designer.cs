namespace CT_Helper
{
    partial class BMI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.weightBox = new System.Windows.Forms.NumericUpDown();
            this.heightBox = new System.Windows.Forms.NumericUpDown();
            this.ExamLabel = new System.Windows.Forms.Label();
            this.BMITitle = new System.Windows.Forms.Label();
            this.BMIHeaderLabel = new System.Windows.Forms.Label();
            this.contrastAmount = new System.Windows.Forms.Label();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.TROBtn = new System.Windows.Forms.RadioButton();
            this.CABGBtn = new System.Windows.Forms.RadioButton();
            this.CTCABtn = new System.Windows.Forms.RadioButton();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.calculateBMIBtn = new System.Windows.Forms.Button();
            this.BMILabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).BeginInit();
            this.SuspendLayout();
            // 
            // weightBox
            // 
            this.weightBox.DecimalPlaces = 2;
            this.weightBox.Location = new System.Drawing.Point(159, 105);
            this.weightBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(120, 20);
            this.weightBox.TabIndex = 24;
            this.weightBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BMIEnter);
            // 
            // heightBox
            // 
            this.heightBox.DecimalPlaces = 2;
            this.heightBox.Location = new System.Drawing.Point(159, 79);
            this.heightBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(120, 20);
            this.heightBox.TabIndex = 23;
            this.heightBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BMIEnter);
            // 
            // ExamLabel
            // 
            this.ExamLabel.AutoSize = true;
            this.ExamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamLabel.Location = new System.Drawing.Point(53, 49);
            this.ExamLabel.Name = "ExamLabel";
            this.ExamLabel.Size = new System.Drawing.Size(41, 13);
            this.ExamLabel.TabIndex = 32;
            this.ExamLabel.Text = "Exam:";
            // 
            // BMITitle
            // 
            this.BMITitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.BMITitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMITitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BMITitle.Location = new System.Drawing.Point(0, 0);
            this.BMITitle.Name = "BMITitle";
            this.BMITitle.Size = new System.Drawing.Size(353, 33);
            this.BMITitle.TabIndex = 31;
            this.BMITitle.Text = "Calculate BMI and Contrast";
            this.BMITitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BMIHeaderLabel
            // 
            this.BMIHeaderLabel.AutoSize = true;
            this.BMIHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIHeaderLabel.Location = new System.Drawing.Point(97, 184);
            this.BMIHeaderLabel.Name = "BMIHeaderLabel";
            this.BMIHeaderLabel.Size = new System.Drawing.Size(33, 13);
            this.BMIHeaderLabel.TabIndex = 30;
            this.BMIHeaderLabel.Text = "BMI:";
            // 
            // contrastAmount
            // 
            this.contrastAmount.AutoSize = true;
            this.contrastAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrastAmount.Location = new System.Drawing.Point(136, 211);
            this.contrastAmount.Name = "contrastAmount";
            this.contrastAmount.Size = new System.Drawing.Size(24, 26);
            this.contrastAmount.TabIndex = 29;
            this.contrastAmount.Text = "?";
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrastLabel.Location = new System.Drawing.Point(17, 220);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(113, 13);
            this.contrastLabel.TabIndex = 28;
            this.contrastLabel.Text = "Contrast Required:";
            // 
            // TROBtn
            // 
            this.TROBtn.AutoSize = true;
            this.TROBtn.Location = new System.Drawing.Point(219, 47);
            this.TROBtn.Name = "TROBtn";
            this.TROBtn.Size = new System.Drawing.Size(96, 17);
            this.TROBtn.TabIndex = 22;
            this.TROBtn.Text = "Triple Rule-Out";
            this.TROBtn.UseVisualStyleBackColor = true;
            this.TROBtn.CheckedChanged += new System.EventHandler(this.TROBtn_CheckedChanged);
            this.TROBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BMIEnter);
            // 
            // CABGBtn
            // 
            this.CABGBtn.AutoSize = true;
            this.CABGBtn.Location = new System.Drawing.Point(159, 47);
            this.CABGBtn.Name = "CABGBtn";
            this.CABGBtn.Size = new System.Drawing.Size(54, 17);
            this.CABGBtn.TabIndex = 20;
            this.CABGBtn.Text = "CABG";
            this.CABGBtn.UseVisualStyleBackColor = true;
            this.CABGBtn.CheckedChanged += new System.EventHandler(this.CABGBtn_CheckedChanged);
            this.CABGBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BMIEnter);
            // 
            // CTCABtn
            // 
            this.CTCABtn.AutoSize = true;
            this.CTCABtn.Checked = true;
            this.CTCABtn.Location = new System.Drawing.Point(100, 47);
            this.CTCABtn.Name = "CTCABtn";
            this.CTCABtn.Size = new System.Drawing.Size(53, 17);
            this.CTCABtn.TabIndex = 19;
            this.CTCABtn.TabStop = true;
            this.CTCABtn.Text = "CTCA";
            this.CTCABtn.UseVisualStyleBackColor = true;
            this.CTCABtn.CheckedChanged += new System.EventHandler(this.CTCABtn_CheckedChanged);
            this.CTCABtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BMIEnter);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(84, 81);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(69, 13);
            this.heightLabel.TabIndex = 27;
            this.heightLabel.Text = "Height (m):";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(76, 107);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(77, 13);
            this.weightLabel.TabIndex = 25;
            this.weightLabel.Text = "Weight (kg):";
            // 
            // calculateBMIBtn
            // 
            this.calculateBMIBtn.Location = new System.Drawing.Point(147, 143);
            this.calculateBMIBtn.Name = "calculateBMIBtn";
            this.calculateBMIBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBMIBtn.TabIndex = 26;
            this.calculateBMIBtn.Text = "Calculate";
            this.calculateBMIBtn.UseVisualStyleBackColor = true;
            this.calculateBMIBtn.Click += new System.EventHandler(this.calculateBMIBtn_Click);
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMILabel.Location = new System.Drawing.Point(136, 175);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(24, 26);
            this.BMILabel.TabIndex = 21;
            this.BMILabel.Text = "?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.ExamLabel);
            this.Controls.Add(this.BMITitle);
            this.Controls.Add(this.BMIHeaderLabel);
            this.Controls.Add(this.contrastAmount);
            this.Controls.Add(this.contrastLabel);
            this.Controls.Add(this.TROBtn);
            this.Controls.Add(this.CABGBtn);
            this.Controls.Add(this.CTCABtn);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.calculateBMIBtn);
            this.Controls.Add(this.BMILabel);
            this.Name = "BMI";
            this.Text = "BMI";
            this.Load += new System.EventHandler(this.BMI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown weightBox;
        private System.Windows.Forms.NumericUpDown heightBox;
        private System.Windows.Forms.Label ExamLabel;
        private System.Windows.Forms.Label BMITitle;
        private System.Windows.Forms.Label BMIHeaderLabel;
        private System.Windows.Forms.Label contrastAmount;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.RadioButton TROBtn;
        private System.Windows.Forms.RadioButton CABGBtn;
        private System.Windows.Forms.RadioButton CTCABtn;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button calculateBMIBtn;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.Button button1;

    }
}