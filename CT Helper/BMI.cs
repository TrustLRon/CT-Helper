using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CT_Helper
{
    public partial class BMI : Form
    {
        public Boolean CTCAScan;
        public Boolean CABGScan;
        public Boolean TROScan;

        public BMI()
        {
            InitializeComponent();
        }

        private void TROBtn_CheckedChanged(object sender, EventArgs e)
        {
            contrastAmount.Text = "?";
        }

        private void CABGBtn_CheckedChanged(object sender, EventArgs e)
        {
            contrastAmount.Text = "?";
        }

        private void CTCABtn_CheckedChanged(object sender, EventArgs e)
        {
            contrastAmount.Text = "?";
        }

        private void calculateBMIBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(weightBox.Text) ||
                    string.IsNullOrWhiteSpace(heightBox.Text))
                {
                    MessageBox.Show("Please fill in both the Height and Weight",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Decimal weight = Decimal.Parse(weightBox.Text);
                    Decimal height = Decimal.Parse(heightBox.Text);
                    Decimal BMI = weight / (height * height);

                    BMILabel.Text = Math.Round(BMI, 0).ToString();

                    if (CTCABtn.Checked == true)
                    {
                        if (Decimal.Parse(BMILabel.Text) < 30)
                        {
                            contrastAmount.Text = "50mL";
                        }
                        else if (Decimal.Parse(BMILabel.Text) >= 30 && Decimal.Parse(BMILabel.Text) <= 37)
                        {
                            contrastAmount.Text = "50mL / 75mL";
                        }
                        else
                        {
                            contrastAmount.Text = "75mL";
                        }
                    }

                    if (CABGBtn.Checked == true)
                    {
                        if (Decimal.Parse(BMILabel.Text) < 30)
                        {
                            contrastAmount.Text = "75mL";
                        }
                        else if (Decimal.Parse(BMILabel.Text) >= 30 && Decimal.Parse(BMILabel.Text) <= 37)
                        {
                            contrastAmount.Text = "50mL / 75mL";
                        }
                        else
                        {
                            contrastAmount.Text = "100mL";
                        }
                    }

                    if (TROBtn.Checked == true)
                    {
                        if (Decimal.Parse(BMILabel.Text) < 30)
                        {
                            contrastAmount.Text = "100mL";
                        }
                        else
                        {
                            contrastAmount.Text = "125mL";
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something's wrong, try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BMILabel.Text = "?";
                contrastAmount.Text = "?";
                weightBox.Text = "";
                heightBox.Text = "";

            }
        }

        private void BMI_Load(object sender, EventArgs e)
        {
            weightBox.Text = "";
            heightBox.Text = "";
            contrastAmount.Text = "?";
            BMILabel.Text = "?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void BMIEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                calculateBMIBtn_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }
    }
}
