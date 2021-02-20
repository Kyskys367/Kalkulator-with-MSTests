using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        Maths math = new Maths();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            float result = math.plus(textBoxFirstNum.Text, textBoxSecondNum.Text);
            labelResult.Text = result.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            float result = math.minus(textBoxFirstNum.Text, textBoxSecondNum.Text);
            labelResult.Text = result.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            float result = math.multi(textBoxFirstNum.Text, textBoxSecondNum.Text);
            labelResult.Text = result.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBoxSecondNum.Text) == 0)
            {
                MessageBox.Show("Nie należy dzielić przez zero!!");
            }
            else
            {
                float result = math.div(textBoxFirstNum.Text, textBoxSecondNum.Text);
                labelResult.Text = result.ToString();
            }            
        }
    }
}
