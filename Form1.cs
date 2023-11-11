using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramDoLiczeniaRMS
{
    public partial class MainForm : Form
    {
        private string[] _lines;
        private decimal maxval = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void readFiles_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "*.txt|*.txt"
            };
            if(ofd.ShowDialog() == DialogResult.OK) 
            {
                this.textBox1.Text = ofd.FileName;
            }
            this._lines = File.ReadAllLines(ofd.FileName);
            this.textbox_maxVal.Text = _lines.Max();
            decimal.TryParse(_lines.Max(), out decimal resoult);
            this.maxval = Math.Abs(resoult);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this._lines != null)
            {
                decimal squareSum = 0;
                string[] lines = this._lines;
                lines = lines.Select(elem => elem.Trim()).ToArray();
                foreach (string line in lines)
                {
                    decimal point = 1;
                    try
                    {
                        point = Convert.ToDecimal(line.Replace('.', ',').Trim());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"{line} jest niepoprawne, spróbuj usunąć spacje");
                        return;
                        throw;
                    }
                    decimal pointSquared = point * point;
                    squareSum += pointSquared;
                }
                int N = lines.Length - 1;
                if (this.textBox_N.Text != string.Empty) N = Convert.ToInt16(textBox_N.Text.Trim());
                squareSum = squareSum / Convert.ToDecimal(N);
                double RMS = Math.Sqrt(Convert.ToDouble(squareSum));
                this.textBox_resoult.Text = RMS.ToString();


                decimal doubleRMS = Convert.ToDecimal(RMS * 2);
                this.textBox_doublerms.Text = doubleRMS.ToString();

                if(doubleRMS > this.maxval)
                {
                    this.button_outcome.BackColor = Color.Green;
                    this.button_outcome.Text = "RMS x 2 jest WIĘKSZY od wartości maksymalnej";
                }
                else
                {
                    this.button_outcome.BackColor = Color.Red;
                    this.button_outcome.Text = "RMS x 2 jest MNIEJSZY od wartości maksymalnej!!!";
                }
            }
        }

        
    }
}
