using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace CT_Helper
{
    public partial class PrintPreview : Form
    {
        public PrintPreview()
        {
            InitializeComponent();       
        }

        Bitmap memoryImage;
        
        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            DialogResult result = printDialog1.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
                this.Hide();
            }
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = CreateGraphics();
            Size s = ClientSize;
            memoryImage = new Bitmap(s.Width - 40, s.Height - 50, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(Location.X + 10, Location.Y + 35, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 10, 20);
        }
    }
}
