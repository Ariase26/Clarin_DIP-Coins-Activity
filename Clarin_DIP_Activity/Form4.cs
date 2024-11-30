using AForge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcess2;

namespace Clarin_DIP_Activity
{
    public partial class Form4 : Form
    {
        Bitmap original;
        Bitmap processed;

        public Form4()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 backToHome = new Form1();
            backToHome.FormClosed += (s, args) => this.Show();
            backToHome.Show();
            this.Hide();
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap originalImage = new Bitmap(ofd.FileName);

                    if (original != null)
                    {
                        original.Dispose();
                    }

                    original = originalImage;

                    pictureBox1.Image = original;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Invalidate();

                    pictureBox2.Image = null;
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

        }

        private void countCointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(original == null)
                return;

            processed = new Bitmap(original.Width, original.Height);
            BitmapFilter.Binary(original, processed, 200);

            Coins.CountCoin(processed, ref lbl_numbercoins, ref lbl_totalcoins, ref lbl_fivecents, ref lbl_tencents, ref lbl_twentyfivecents, ref lbl_onepeso, ref lbl_fivepeso);
            Debug.WriteLine($"Total Coins: {lbl_totalcoins.Text}, Total Value: {lbl_fivecents.Text}");

            pictureBox2.Image = processed;
        }
    }
}
