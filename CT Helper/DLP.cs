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
    public partial class DLP : Form
    {
        public DLP()
        {
            InitializeComponent();
            CTCADLPBox.Text = "";
            CaScoreDLPBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CTCADLPEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                CTCADLPBtn_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }

        private void CaScoreDLPEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                CaScoreDLPBtn_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }

        private void CaScoreDLPBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CaScoreDLPBox.Text))
                {
                    MessageBox.Show("Please fill in the DLP",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double CaScoreDLP = double.Parse(CaScoreDLPBox.Text);
                    CaScoreDLP = CaScoreDLP * 0.014;

                    CaScoreDLPTotal.Text = Math.Round(CaScoreDLP, 1).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Something's wrong, try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CaScoreDLPTotal.Text = "0";
            }
        }

        private void CTCADLPBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CTCADLPBox.Text))
                {
                    MessageBox.Show("Please fill in the DLP",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double CTCADLP = double.Parse(CTCADLPBox.Text);
                    CTCADLP = CTCADLP * 0.014;

                    CTCADLPTotal.Text = Math.Round(CTCADLP, 1).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Something's wrong, try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CTCADLPTotal.Text = "0";
            }
        }
    }
}
