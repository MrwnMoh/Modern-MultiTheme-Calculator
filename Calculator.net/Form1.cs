using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.net
{
    public partial class Form1 : Form
    {

        double resultValue = 0;       
        private void AddOperator(string op)
        {
            if (!string.IsNullOrEmpty(InputTextBox.Text))
            {
                resultValue = double.Parse(InputTextBox.Text);
                CalculationTrackerBox.Text += resultValue.ToString() + op;
                InputTextBox.Text = "";
            }

        }
        private void Numbers_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (InputTextBox.Text.Contains("."))
                {
                    return;
                }
                if (string.IsNullOrEmpty(InputTextBox.Text))
                {
                    InputTextBox.Text += "0" + btn.Text;
                    return;
                }
            }

            InputTextBox.Text += btn.Text;
        }

        private void ApplyDarkTheme(Control parent)
        {

            foreach (Control C in parent.Controls)
            {
                if (C is Button && C.BackgroundImage == null)
                {
                    C.BackColor = Color.FromArgb(150, 150, 150);
                    C.ForeColor = Color.Black;

                    if (C.Text == "=")
                    {
                        C.BackColor = Color.FromArgb(45, 45, 45);
                        C.ForeColor = Color.Black;
                    }
                    if ("+-/X%".Contains(C.Text))
                    {
                        C.BackColor = Color.SandyBrown;
                        C.ForeColor = Color.Black;

                    }

                }

                if (C is TextBox)
                {
                    C.ForeColor = Color.Black;
                }

                if (C.HasChildren)
                {
                    ApplyDarkTheme(C);
                }

            }


        }
        private void ApplyLightTheme(Control parent)
        {

            foreach (Control C in parent.Controls)
            {
                if (C is Button && C.BackgroundImage == null)
                {
                    C.BackColor = Color.FromArgb(230, 230, 230);
                    C.ForeColor = Color.Black;

                    if (C.Text == "=")
                    {
                        C.BackColor = Color.FromArgb(0, 122, 204);
                        C.ForeColor = Color.White;
                    }

                    if ("+-/X%".Contains(C.Text))
                    {
                        C.BackColor = Color.FromArgb(255, 200, 100);
                        C.ForeColor = Color.White;
                    }


                }

                if (C is TextBox)
                {
                    C.BackColor = Color.White;
                    C.ForeColor = Color.FromArgb(0, 122, 204);
                }

                if (C.HasChildren)
                {
                    ApplyLightTheme(C);
                }
            }
        }
        private void SetThemes(byte ThemColor)
        {


            if (ThemColor == 3)
            {
                this.BackColor = Color.WhiteSmoke;

                ApplyNatureTheme(this);
            }
            else if (ThemColor == 1)
            {
                this.BackColor = Color.FromArgb(20, 20, 20);

                ApplyDarkTheme(this);

            }
            else
            {
                this.BackColor = Color.White;
                ApplyLightTheme(this);
            }


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Numbers_Click(sender, e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Numbers_Click(sender, e);

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Numbers_Click(sender, e);

        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
            Numbers_Click(sender, e);

        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            Numbers_Click(sender, e);

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Numbers_Click(sender, e);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Numbers_Click(sender, e);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Numbers_Click(sender, e);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Numbers_Click(sender, e);

        }
        private void button6_Click(object sender, EventArgs e)
        {
            Numbers_Click(sender, e);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Numbers_Click(sender, e);

        }
        private void button8_Click(object sender, EventArgs e)
        {
            Numbers_Click(sender, e);

        }
        private void button9_Click(object sender, EventArgs e)
        {
            Numbers_Click(sender, e);

        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            AddOperator("*");

        }
        private void buttonEqq_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(InputTextBox.Text))
           { CalculationTrackerBox.Text += InputTextBox.Text;

            DataTable dt = new DataTable();
            var result = dt.Compute(CalculationTrackerBox.Text, "");

            InputTextBox.Text = result.ToString();

            ResultText.Text = "= " + result.ToString();

                CalculationTrackerBox.Text = "";
            }

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddOperator("+");

        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            AddOperator("-");

        }
        private void button15_Click(object sender, EventArgs e)
        {
            AddOperator("/");
        }
        private void buttonAC_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = "";              
            CalculationTrackerBox.Text = "";
            ResultText.Text = "0";
            resultValue = 0;
        }
        private void buttonDellet_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(InputTextBox.Text))
                InputTextBox.Text =  InputTextBox.Text.Remove(InputTextBox.Text.Length - 1);
        }
        private void buttonMod_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InputTextBox.Text))
            {
                double val = double.Parse(InputTextBox.Text);
                val = val / 100; 
                InputTextBox.Text = val.ToString();
            }
        }
        private void ApplyNatureTheme(Control parent)
        {

            foreach (Control C in parent.Controls)
            {
                if (C is Button && C.BackgroundImage == null)
                {
                    C.BackColor = Color.FromArgb(79, 111, 82);
                    C.ForeColor = Color.White;

                    if(C.Text == "=")
                    {
                        C.BackColor = Color.FromArgb(30, 73, 60);
                    }
                    if("+-/X%".Contains(C.Text))
                    {
                        C.BackColor = Color.FromArgb(20, 101, 81);
                    }

                }

                if (C is TextBox)
                {
                    C.BackColor = Color.WhiteSmoke;
                    C.ForeColor = Color.FromArgb(79, 111, 82);

                }

                if(C.HasChildren)
                {
                    ApplyNatureTheme(C);
                }

            }


        }
        private void ButtonNuterl_Click(object sender, EventArgs e)
        {
            SetThemes(3);
        }
        private void buttonDark_Click(object sender, EventArgs e)
        {
            SetThemes(1);

        }
        private void buttonLight_Click(object sender, EventArgs e)
        {
            SetThemes(2);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
