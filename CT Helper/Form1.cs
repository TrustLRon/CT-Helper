using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CT_Helper
{
    public partial class Form1 : Form
    {
        public Boolean CTCAScan;
        public Boolean CABGScan;
        public Boolean TROScan;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //clearBtn_Click(null, null);
            weightBox.Text = "";
            heightBox.Text = "";
            //DLPClearBtn_Click(null, null);
            CTCADLPBox.Text = "";
            CaScoreDLPBox.Text = "";
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
                            MessageBox.Show("If the patients chest is not too big or muscular,\nconsider 50mL, otherwise use 75mL.", "Borderline",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show("If the patients chest is not too big or muscular,\nconsider 50mL, otherwise use 75mL.", "Borderline", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (heightBox.Enabled == false)
            {
                heightBox.Enabled = true;
                weightBox.Enabled = true;
                CTCABtn.Enabled = true;
                CABGBtn.Enabled = true;
                TROBtn.Enabled = true;
                calculateBMIBtn.Enabled = true;
                clearBtn.Text = "Clear";
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to clear the BMI calculation?", "Clear BMI?",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    weightBox.Text = "";
                    heightBox.Text = "";
                    weightBox.Enabled = true;
                    heightBox.Enabled = true;
                    CTCABtn.Enabled = true;
                    CABGBtn.Enabled = true;
                    TROBtn.Enabled = true;
                    calculateBMIBtn.Enabled = true;
                    contrastAmount.Text = "?";
                    BMILabel.Text = "?";
                }
            }
        }

        private void CTCABtn_CheckedChanged(object sender, EventArgs e)
        {
            contrastAmount.Text = "?";
        }

        private void CABGBtn_CheckedChanged(object sender, EventArgs e)
        {
            contrastAmount.Text = "?";
        }

        private void TROBtn_CheckedChanged(object sender, EventArgs e)
        {
            contrastAmount.Text = "?";
        }

        private void CaScoreDLPBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CaScoreDLPBox.Text))
                {
                    //MessageBox.Show("Please fill in the DLP",
                    //    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    //MessageBox.Show("Please fill in the DLP",
                    //    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void DLPClearBtn_Click(object sender, EventArgs e)
        {
            if (CTCADLPBox.Enabled == false)
            {
                CaScoreDLPBox.Enabled = true;
                CTCADLPBox.Enabled = true;
                CTCADLPBtn.Enabled = true;
                CaScoreDLPBtn.Enabled = true;
                DLPClearBtn.Text = "Clear";
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to clear the DLP calculation?", "Clear DLP?",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    CaScoreDLPBox.Text = "";
                    CTCADLPBox.Text = "";
                    CaScoreDLPBox.Enabled = true;
                    CTCADLPBox.Enabled = true;
                    CTCADLPBtn.Enabled = true;
                    CaScoreDLPBtn.Enabled = true;
                    CaScoreDLPTotal.Text = "0";
                    CTCADLPTotal.Text = "0";
                }
            }
        }

        private void CaScoreDLPEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                CaScoreDLPBtn_Click(null, null);
                CTCADLPBtn_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }

        private void BMIEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                calculateBMIBtn_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }

        private void CTCADLPEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                CTCADLPBtn_Click(null, null);
                CaScoreDLPBtn_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }

        private void nameEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                nextBtn0_Click(null, null);
                e.SuppressKeyPress = true;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            PrintPreview print = new PrintPreview();

            if (CTCABtn.Checked == true)
            {
                print.examTypeText.Text = "CTCA";
            }
            else if (CABGBtn.Checked == true)
            {
                print.examTypeText.Text = "CABG";
            }
            else if (TROBtn.Checked == true)
            {
                print.examTypeText.Text = "Triple Rule Out";
            }

            print.name.Text = printName.Text;
            print.bmiText.Text = BMILabel.Text;
            print.scannedText.Text = minCombo.Text + " to " + maxCombo.Text;
            print.caScoreDLPText.Text = CaScoreDLPBox.Text + "mGy.cm";
            print.caScoreDoseText.Text = CaScoreDLPTotal.Text + "mSv";
            print.ctcaDLPText.Text = CTCADLPBox.Text + "mGy.cm";
            print.ctcaDoseText.Text = CTCADLPTotal.Text + "mSv";
            print.radText.Text = radBox.Text;
            print.ppwText.Text = ppwBox.Text;
            print.chestText.Text = chestCheckBox.Text;
            print.caScoreScanText.Text = caScoreScanBox.Text;
            print.widenText.Text = widenBox.Text;
            print.betalocText.Text = betalocBox.Text;
            print.betalocAmountText.Text = betaCombo.Text;
            print.nitroText.Text = nitroBox.Text;
            print.ctcaScanText.Text = ctcaScanBox.Text;
            print.chestScanText.Text = chestScanBox.Text;
            print.emailText.Text = emailBox.Text;
            print.ecgText.Text = ecgBox.Text;
            print.bestSentText.Text = bestCheckBox.Text;
            print.volsSentText.Text = sendVolBox.Text;
            print.bloodPressureText.Text = bloodPressureBox.Text;
            print.bestText.Text = bestCombo.Text;

            print.Show(this);
        }


        private void nextBtn0_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lastName.Text) &&
                !string.IsNullOrWhiteSpace(firstName.Text))
            {
                lastName.Enabled = false;
                firstName.Enabled = false;
                patientClearBtn.Text = "Edit";
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Please make sure Patient Name is not empty",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nextBtn1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(heightBox.Text) &&
                !string.IsNullOrWhiteSpace(weightBox.Text))
            {
                heightBox.Enabled = false;
                weightBox.Enabled = false;
                CTCABtn.Enabled = false;
                CABGBtn.Enabled = false;
                TROBtn.Enabled = false;
                calculateBMIBtn.Enabled = false;
                tabControl1.SelectedIndex = 2;
                clearBtn.Text = "Edit";
            }
            else
            {
                MessageBox.Show("Please make sure Height and Weight are not empty",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nextBtn2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(radBox.Text) &&
                !string.IsNullOrWhiteSpace(ppwBox.Text) &&
                !string.IsNullOrWhiteSpace(widenBox.Text) &&
                !string.IsNullOrWhiteSpace(nitroBox.Text) &&
                !string.IsNullOrWhiteSpace(betalocBox.Text) &&
                !string.IsNullOrWhiteSpace(ctcaScanBox.Text) &&
                !string.IsNullOrWhiteSpace(chestScanBox.Text) &&
                !string.IsNullOrWhiteSpace(ecgBox.Text) &&
                !string.IsNullOrWhiteSpace(sendVolBox.Text) &&
                !string.IsNullOrWhiteSpace(bloodPressureBox.Text) &&
                !string.IsNullOrWhiteSpace(emailBox.Text) &&
                !string.IsNullOrWhiteSpace(caScoreScanBox.Text) &&
                !string.IsNullOrWhiteSpace(bestCheckBox.Text) &&
                !string.IsNullOrWhiteSpace(chestCheckBox.Text) &&

                !string.IsNullOrWhiteSpace(betaCombo.Text) &&
                !string.IsNullOrWhiteSpace(minCombo.Text) &&
                !string.IsNullOrWhiteSpace(maxCombo.Text) &&
                !string.IsNullOrWhiteSpace(bestCombo.Text) &&

                checkBox1.Checked == true &&
                checkBox2.Checked == true &&
                checkBox3.Checked == true &&
                checkBox4.Checked == true &&
                checkBox5.Checked == true &&
                checkBox6.Checked == true &&
                checkBox7.Checked == true &&
                checkBox8.Checked == true &&
                checkBox9.Checked == true &&
                checkBox10.Checked == true &&
                checkBox11.Checked == true &&
                checkBox12.Checked == true &&
                checkBox13.Checked == true &&
                checkBox14.Checked == true)
            {
                radBox.Enabled = false;
                ppwBox.Enabled = false;
                widenBox.Enabled = false;
                nitroBox.Enabled = false;
                betalocBox.Enabled = false;
                ctcaScanBox.Enabled = false;
                chestScanBox.Enabled = false;
                ecgBox.Enabled = false;
                sendVolBox.Enabled = false;
                bloodPressureBox.Enabled = false;
                emailBox.Enabled = false;
                caScoreScanBox.Enabled = false;
                bestCheckBox.Enabled = false;
                chestCheckBox.Enabled = false;
                betaCombo.Enabled = false;
                minCombo.Enabled = false;
                maxCombo.Enabled = false;
                bestCombo.Enabled = false;

                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
                checkBox14.Enabled = false;

                checkListClearBtn.Text = "Edit";
                tabControl1.SelectedIndex = 3;
            }
            else
            {
                MessageBox.Show("Please make sure all sections are complete",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nextBtn3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CaScoreDLPBox.Text) &&
                !string.IsNullOrWhiteSpace(CTCADLPBox.Text))
            {
                CaScoreDLPBox.Enabled = false;
                CTCADLPBox.Enabled = false;
                CTCADLPBtn.Enabled = false;
                CaScoreDLPBtn.Enabled = false;
                DLPClearBtn.Text = "Edit";
                tabControl1.SelectedIndex = 4;
            }
            else
            {
                MessageBox.Show("Please make sure DLP's are complete",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public int hasPrinted = 0;

        private void finishBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("If you have finished with the current patient and\nhave printed their CTCA Sheet, press ok to\nclear everything and start again.", "Restart?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                firstName.Text = "";
                firstName.Enabled = true;
                lastName.Text = "";
                lastName.Enabled = true;

                CaScoreDLPBox.Text = "";
                CaScoreDLPBox.Enabled = true;
                CTCADLPBox.Text = "";
                CTCADLPBox.Enabled = true;
                CaScoreDLPTotal.Text = "0";
                CaScoreDLPTotal.Enabled = true;
                CTCADLPTotal.Text = "0";
                CTCADLPTotal.Enabled = true;
                CTCADLPBtn.Enabled = true;
                CaScoreDLPBtn.Enabled = true;
                weightBox.Text = "";
                weightBox.Enabled = true;
                heightBox.Text = "";
                heightBox.Enabled = true;
                CTCABtn.Enabled = true;
                CABGBtn.Enabled = true;
                TROBtn.Enabled = true;
                calculateBMIBtn.Enabled = true;
                contrastAmount.Text = "?";
                BMILabel.Text = "?";

                radBox.Text = "";
                radBox.Enabled = true;
                ppwBox.Text = "";
                ppwBox.Enabled = true;
                widenBox.Text = "";
                widenBox.Enabled = true;
                nitroBox.Text = "";
                nitroBox.Enabled = true;
                betalocBox.Text = "";
                betalocBox.Enabled = true;
                ctcaScanBox.Text = "";
                ctcaScanBox.Enabled = true;
                chestScanBox.Text = "";
                chestScanBox.Enabled = true;
                ecgBox.Text = "";
                ecgBox.Enabled = true;
                sendVolBox.Text = "";
                sendVolBox.Enabled = true;
                bloodPressureBox.Text = "";
                bloodPressureBox.Enabled = true;
                emailBox.Text = "";
                emailBox.Enabled = true;
                caScoreScanBox.Text = "";
                caScoreScanBox.Enabled = true;
                bestCheckBox.Text = "";
                bestCheckBox.Enabled = true;
                chestCheckBox.Text = "";
                chestCheckBox.Enabled = true;
                betaCombo.Text = "";
                betaCombo.Enabled = true;
                minCombo.Text = "";
                minCombo.Enabled = true;
                maxCombo.Text = "";
                maxCombo.Enabled = true;
                bestCombo.Text = "";
                bestCombo.Enabled = true;

                checkBox1.Checked = false;
                checkBox1.Enabled = true;
                checkBox2.Checked = false;
                checkBox2.Enabled = true;
                checkBox3.Checked = false;
                checkBox3.Enabled = true;
                checkBox4.Checked = false;
                checkBox4.Enabled = true;
                checkBox5.Checked = false;
                checkBox5.Enabled = true;
                checkBox6.Checked = false;
                checkBox6.Enabled = true;
                checkBox7.Checked = false;
                checkBox7.Enabled = true;
                checkBox8.Checked = false;
                checkBox8.Enabled = true;
                checkBox9.Checked = false;
                checkBox9.Enabled = true;
                checkBox10.Checked = false;
                checkBox10.Enabled = true;
                checkBox11.Checked = false;
                checkBox11.Enabled = true;
                checkBox12.Checked = false;
                checkBox12.Enabled = true;
                checkBox13.Checked = false;
                checkBox13.Enabled = true;
                checkBox14.Checked = false;
                checkBox14.Enabled = true;

                PrintBtn.Enabled = true;

                tabControl1.SelectedIndex = 0;
            }
        }
        

        private void checkListClearBtn_Click(object sender, EventArgs e)
        {
            if (radBox.Enabled == false)
            {
                radBox.Enabled = true;
                ppwBox.Enabled = true;
                widenBox.Enabled = true;
                nitroBox.Enabled = true;
                betalocBox.Enabled = true;
                ctcaScanBox.Enabled = true;
                chestScanBox.Enabled = true;
                ecgBox.Enabled = true;
                sendVolBox.Enabled = true;
                bloodPressureBox.Enabled = true;
                emailBox.Enabled = true;
                caScoreScanBox.Enabled = true;
                bestCheckBox.Enabled = true;
                chestCheckBox.Enabled = true;
                betaCombo.Enabled = true;
                minCombo.Enabled = true;
                maxCombo.Enabled = true;
                bestCombo.Enabled = true;

                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                checkBox10.Enabled = true;
                checkBox11.Enabled = true;
                checkBox12.Enabled = true;
                checkBox13.Enabled = true;
                checkBox14.Enabled = true;

                checkListClearBtn.Text = "Clear";
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to clear the Check List?", "Clear Check List?",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    radBox.Text = "";
                    radBox.Enabled = true;
                    ppwBox.Text = "";
                    ppwBox.Enabled = true;
                    widenBox.Text = "";
                    widenBox.Enabled = true;
                    nitroBox.Text = "";
                    nitroBox.Enabled = true;
                    betalocBox.Text = "";
                    betalocBox.Enabled = true;
                    ctcaScanBox.Text = "";
                    ctcaScanBox.Enabled = true;
                    chestScanBox.Text = "";
                    chestScanBox.Enabled = true;
                    ecgBox.Text = "";
                    ecgBox.Enabled = true;
                    sendVolBox.Text = "";
                    sendVolBox.Enabled = true;
                    bloodPressureBox.Text = "";
                    bloodPressureBox.Enabled = true;
                    emailBox.Text = "";
                    emailBox.Enabled = true;
                    caScoreScanBox.Text = "";
                    caScoreScanBox.Enabled = true;
                    bestCheckBox.Text = "";
                    bestCheckBox.Enabled = true;
                    chestCheckBox.Text = "";
                    chestCheckBox.Enabled = true;
                    betaCombo.Text = "";
                    betaCombo.Enabled = true;
                    minCombo.Text = "";
                    minCombo.Enabled = true;
                    maxCombo.Text = "";
                    maxCombo.Enabled = true;
                    bestCombo.Text = "";
                    bestCombo.Enabled = true;

                    checkBox1.Checked = false;
                    checkBox1.Enabled = true;
                    checkBox2.Checked = false;
                    checkBox2.Enabled = true;
                    checkBox3.Checked = false;
                    checkBox3.Enabled = true;
                    checkBox4.Checked = false;
                    checkBox4.Enabled = true;
                    checkBox5.Checked = false;
                    checkBox5.Enabled = true;
                    checkBox6.Checked = false;
                    checkBox6.Enabled = true;
                    checkBox7.Checked = false;
                    checkBox7.Enabled = true;
                    checkBox8.Checked = false;
                    checkBox8.Enabled = true;
                    checkBox9.Checked = false;
                    checkBox9.Enabled = true;
                    checkBox10.Checked = false;
                    checkBox10.Enabled = true;
                    checkBox11.Checked = false;
                    checkBox11.Enabled = true;
                    checkBox12.Checked = false;
                    checkBox12.Enabled = true;
                    checkBox13.Checked = false;
                    checkBox13.Enabled = true;
                    checkBox14.Checked = false;
                    checkBox14.Enabled = true;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("An Insignificant Production.\nCreated in C# using Visual Studio", 
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {                
                BMI bmi = new BMI();
                bmi.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Something went wrong, try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
        
        private void dLPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DLP dlp = new DLP();
                dlp.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Something went wrong, try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will clear the current patient and start again.\n\nAre you sure?", "Start New?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                firstName.Text = "";
                firstName.Enabled = true;
                lastName.Text = "";
                lastName.Enabled = true;

                CaScoreDLPBox.Text = "";
                CaScoreDLPBox.Enabled = true;
                CTCADLPBox.Text = "";
                CTCADLPBox.Enabled = true;
                CaScoreDLPTotal.Text = "0";
                CaScoreDLPTotal.Enabled = true;
                CTCADLPTotal.Text = "0";
                CTCADLPTotal.Enabled = true;
                CTCADLPBtn.Enabled = true;
                CaScoreDLPBtn.Enabled = true;
                weightBox.Text = "";
                weightBox.Enabled = true;
                heightBox.Text = "";
                heightBox.Enabled = true;
                CTCABtn.Enabled = true;
                CABGBtn.Enabled = true;
                TROBtn.Enabled = true;
                calculateBMIBtn.Enabled = true;
                contrastAmount.Text = "?";
                BMILabel.Text = "?";

                radBox.Text = "";
                radBox.Enabled = true;
                ppwBox.Text = "";
                ppwBox.Enabled = true;
                widenBox.Text = "";
                widenBox.Enabled = true;
                nitroBox.Text = "";
                nitroBox.Enabled = true;
                betalocBox.Text = "";
                betalocBox.Enabled = true;
                ctcaScanBox.Text = "";
                ctcaScanBox.Enabled = true;
                chestScanBox.Text = "";
                chestScanBox.Enabled = true;
                ecgBox.Text = "";
                ecgBox.Enabled = true;
                sendVolBox.Text = "";
                sendVolBox.Enabled = true;
                bloodPressureBox.Text = "";
                bloodPressureBox.Enabled = true;
                emailBox.Text = "";
                emailBox.Enabled = true;
                caScoreScanBox.Text = "";
                caScoreScanBox.Enabled = true;
                bestCheckBox.Text = "";
                bestCheckBox.Enabled = true;
                chestCheckBox.Text = "";
                chestCheckBox.Enabled = true;
                betaCombo.Text = "";
                betaCombo.Enabled = true;
                minCombo.Text = "";
                minCombo.Enabled = true;
                maxCombo.Text = "";
                maxCombo.Enabled = true;
                bestCombo.Text = "";
                bestCombo.Enabled = true;

                checkBox1.Checked = false;
                checkBox1.Enabled = true;
                checkBox2.Checked = false;
                checkBox2.Enabled = true;
                checkBox3.Checked = false;
                checkBox3.Enabled = true;
                checkBox4.Checked = false;
                checkBox4.Enabled = true;
                checkBox5.Checked = false;
                checkBox5.Enabled = true;
                checkBox6.Checked = false;
                checkBox6.Enabled = true;
                checkBox7.Checked = false;
                checkBox7.Enabled = true;
                checkBox8.Checked = false;
                checkBox8.Enabled = true;
                checkBox9.Checked = false;
                checkBox9.Enabled = true;
                checkBox10.Checked = false;
                checkBox10.Enabled = true;
                checkBox11.Checked = false;
                checkBox11.Enabled = true;
                checkBox12.Checked = false;
                checkBox12.Enabled = true;
                checkBox13.Checked = false;
                checkBox13.Enabled = true;
                checkBox14.Checked = false;
                checkBox14.Enabled = true;

                PrintBtn.Enabled = true;

                tabControl1.SelectedIndex = 0;
            }
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TopMost == true)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }
            
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            printName.Text = firstName.Text + " " + lastName.Text;
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            printName.Text = firstName.Text + " " + lastName.Text;
        }

        private void patientClearBtn_Click(object sender, EventArgs e)
        {
            if (firstName.Enabled == false)
            {
                firstName.Enabled = true;
                lastName.Enabled = true;
                patientClearBtn.Text = "Clear";
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to clear Patient Name?", "Clear Name?",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
                if (result == DialogResult.OK)
                {
                    lastName.Text = "";
                    firstName.Text = "";
                }
            }

        }

        private void prevBtn1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void prevBtn2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void prevBtn3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void prevBtn4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
