using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace qr_code_maker1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("QRCODE");
            listBox1.Items.Add("BARCODE");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter();
            if (richTextBox1.Text != null) 
            {
                if (listBox1.SelectedItem != null)
                {
                    if (listBox1.SelectedItem.Equals("QRCODE"))
                    {
                        writer.Format = BarcodeFormat.QR_CODE;
                        writer.Options = new ZXing.Common.EncodingOptions { Height = 300, Width = 300 };
                        pictureBox1.Image = writer.Write(richTextBox1.Text);
                    }

                    else if (listBox1.SelectedItem.Equals("BARCODE"))
                    {
                        writer.Format = BarcodeFormat.CODE_128;
                        pictureBox1.Image = writer.Write(richTextBox1.Text);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName + ".png");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
