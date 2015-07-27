namespace CT_Helper
{
    partial class DLP
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
            this.CTCADLPBox = new System.Windows.Forms.NumericUpDown();
            this.CaScoreDLPBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CTCADLPBtn = new System.Windows.Forms.Button();
            this.CaScoreDLPBtn = new System.Windows.Forms.Button();
            this.CTCADLPTotal = new System.Windows.Forms.Label();
            this.CaScoreDLPTotal = new System.Windows.Forms.Label();
            this.DLPLabel = new System.Windows.Forms.Label();
            this.CTCADLPLabel = new System.Windows.Forms.Label();
            this.CaDLPLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CTCADLPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaScoreDLPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CTCADLPBox
            // 
            this.CTCADLPBox.DecimalPlaces = 2;
            this.CTCADLPBox.Location = new System.Drawing.Point(114, 128);
            this.CTCADLPBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CTCADLPBox.Name = "CTCADLPBox";
            this.CTCADLPBox.Size = new System.Drawing.Size(87, 20);
            this.CTCADLPBox.TabIndex = 15;
            this.CTCADLPBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CTCADLPEnter);
            // 
            // CaScoreDLPBox
            // 
            this.CaScoreDLPBox.DecimalPlaces = 2;
            this.CaScoreDLPBox.Location = new System.Drawing.Point(114, 102);
            this.CaScoreDLPBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CaScoreDLPBox.Name = "CaScoreDLPBox";
            this.CaScoreDLPBox.Size = new System.Drawing.Size(87, 20);
            this.CaScoreDLPBox.TabIndex = 13;
            this.CaScoreDLPBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaScoreDLPEnter);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 33);
            this.label2.TabIndex = 22;
            this.label2.Text = "Calculate Effective Dose";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Effective Dose";
            // 
            // CTCADLPBtn
            // 
            this.CTCADLPBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CTCADLPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTCADLPBtn.Location = new System.Drawing.Point(207, 125);
            this.CTCADLPBtn.Name = "CTCADLPBtn";
            this.CTCADLPBtn.Size = new System.Drawing.Size(75, 23);
            this.CTCADLPBtn.TabIndex = 17;
            this.CTCADLPBtn.Text = "Calculate";
            this.CTCADLPBtn.UseVisualStyleBackColor = false;
            this.CTCADLPBtn.Click += new System.EventHandler(this.CTCADLPBtn_Click);
            // 
            // CaScoreDLPBtn
            // 
            this.CaScoreDLPBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CaScoreDLPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaScoreDLPBtn.Location = new System.Drawing.Point(207, 98);
            this.CaScoreDLPBtn.Name = "CaScoreDLPBtn";
            this.CaScoreDLPBtn.Size = new System.Drawing.Size(75, 23);
            this.CaScoreDLPBtn.TabIndex = 16;
            this.CaScoreDLPBtn.Text = "Calculate";
            this.CaScoreDLPBtn.UseVisualStyleBackColor = false;
            this.CaScoreDLPBtn.Click += new System.EventHandler(this.CaScoreDLPBtn_Click);
            // 
            // CTCADLPTotal
            // 
            this.CTCADLPTotal.AutoSize = true;
            this.CTCADLPTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTCADLPTotal.Location = new System.Drawing.Point(326, 130);
            this.CTCADLPTotal.Name = "CTCADLPTotal";
            this.CTCADLPTotal.Size = new System.Drawing.Size(13, 13);
            this.CTCADLPTotal.TabIndex = 20;
            this.CTCADLPTotal.Text = "0";
            // 
            // CaScoreDLPTotal
            // 
            this.CaScoreDLPTotal.AutoSize = true;
            this.CaScoreDLPTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaScoreDLPTotal.Location = new System.Drawing.Point(326, 103);
            this.CaScoreDLPTotal.Name = "CaScoreDLPTotal";
            this.CaScoreDLPTotal.Size = new System.Drawing.Size(13, 13);
            this.CaScoreDLPTotal.TabIndex = 19;
            this.CaScoreDLPTotal.Text = "0";
            // 
            // DLPLabel
            // 
            this.DLPLabel.AutoSize = true;
            this.DLPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLPLabel.Location = new System.Drawing.Point(144, 84);
            this.DLPLabel.Name = "DLPLabel";
            this.DLPLabel.Size = new System.Drawing.Size(31, 13);
            this.DLPLabel.TabIndex = 18;
            this.DLPLabel.Text = "DLP";
            // 
            // CTCADLPLabel
            // 
            this.CTCADLPLabel.AutoSize = true;
            this.CTCADLPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTCADLPLabel.Location = new System.Drawing.Point(69, 130);
            this.CTCADLPLabel.Name = "CTCADLPLabel";
            this.CTCADLPLabel.Size = new System.Drawing.Size(39, 13);
            this.CTCADLPLabel.TabIndex = 14;
            this.CTCADLPLabel.Text = "CTCA";
            // 
            // CaDLPLabel
            // 
            this.CaDLPLabel.AutoSize = true;
            this.CaDLPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaDLPLabel.Location = new System.Drawing.Point(20, 104);
            this.CaDLPLabel.Name = "CaDLPLabel";
            this.CaDLPLabel.Size = new System.Drawing.Size(88, 13);
            this.CaDLPLabel.TabIndex = 12;
            this.CaDLPLabel.Text = "Calcium Score";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(313, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CTCADLPBox);
            this.Controls.Add(this.CaScoreDLPBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CTCADLPBtn);
            this.Controls.Add(this.CaScoreDLPBtn);
            this.Controls.Add(this.CTCADLPTotal);
            this.Controls.Add(this.CaScoreDLPTotal);
            this.Controls.Add(this.DLPLabel);
            this.Controls.Add(this.CTCADLPLabel);
            this.Controls.Add(this.CaDLPLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DLP";
            this.Text = "DLP";
            ((System.ComponentModel.ISupportInitialize)(this.CTCADLPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaScoreDLPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CTCADLPBox;
        private System.Windows.Forms.NumericUpDown CaScoreDLPBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CTCADLPBtn;
        private System.Windows.Forms.Button CaScoreDLPBtn;
        private System.Windows.Forms.Label CTCADLPTotal;
        private System.Windows.Forms.Label CaScoreDLPTotal;
        private System.Windows.Forms.Label DLPLabel;
        private System.Windows.Forms.Label CTCADLPLabel;
        private System.Windows.Forms.Label CaDLPLabel;
        private System.Windows.Forms.Button button1;
    }
}