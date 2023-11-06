
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "(*.jpg)|*.jpg"
        };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(ofd.FileName);
                var engine = new TesseractEngine($"C:\\Users\\Podral3\\Desktop\\tessdata", "eng", EngineMode.Default);
                string bruh = engine.Process(bmp).GetText();
                this.textBox1.Text = bruh;
            }
        }
    }
}
