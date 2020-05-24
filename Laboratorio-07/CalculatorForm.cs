using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_07
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (CalculatorText.Text == "0" && CalculatorText.Text != null)
            {
                return;
            }
            else
            {
                CalculatorText.Text += "0";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (CalculatorText.Text == "0" && CalculatorText.Text != null)
            {
                CalculatorText.Text = "1";
            }
            else
            {
                CalculatorText.Text += "1";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (CalculatorText.Text == "0" && CalculatorText.Text != null)
            {
                CalculatorText.Text = "2";
            }
            else
            {
                CalculatorText.Text += "2";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (CalculatorText.Text == "0" && CalculatorText.Text != null)
            {
                CalculatorText.Text = "3";
            }
            else
            {
                CalculatorText.Text += "3";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (CalculatorText.Text == "0" && CalculatorText.Text != null)
            {
                CalculatorText.Text = "4";
            }
            else
            {
                CalculatorText.Text += "4";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (CalculatorText.Text == "0" && CalculatorText.Text != null)
            {
                CalculatorText.Text = "5";
            }
            else
            {
                CalculatorText.Text += "5";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (CalculatorText.Text == "0" && CalculatorText.Text != null)
            {
                CalculatorText.Text = "6";
            }
            else
            {
                CalculatorText.Text += "6";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (CalculatorText.Text == "0" && CalculatorText.Text != null)
            {
                CalculatorText.Text = "7";
            }
            else
            {
                CalculatorText.Text += "7";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (CalculatorText.Text == "0" && CalculatorText.Text != null)
            {
                CalculatorText.Text = "8";
            }
            else
            {
                CalculatorText.Text += "8";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (CalculatorText.Text == "0" && CalculatorText.Text != null)
            {
                CalculatorText.Text = "9";
            }
            else
            {
                CalculatorText.Text += "9";
            }
        }

        private void ButtonAC_Click(object sender, EventArgs e)
        {
            CalculatorText.Text = "0";
        }

        private void ButtonDEL_Click(object sender, EventArgs e)
        {
            if (CalculatorText.Text == "0" && CalculatorText.Text != null)
            {
                return;
            }
            else
            {
                CalculatorText.Text = CalculatorText.Text.Remove(CalculatorText.Text.Length - 1);
            }
        }
    }
}
