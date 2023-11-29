using NuGet.Protocol.Plugins;
using System.Net.NetworkInformation;

namespace Conculator
{
    public partial class Form1 : Form
    {
        public string operetion = "";
        public double number1;
        public bool color;
        public double M;
        public bool Drobi;

        Colculator conculator = new Colculator();

        public Form1()
        {
            InitializeComponent();
            infoClik.Focus();
            color = false;
            Drobi = true;
        }


        private void button_C_Click(object sender, EventArgs e)
        {
            infoClik.Text = "";
            operetion = "";
            number1 = 0;
            info.Text = "";
            infoClik.Focus();

        }
        private void runZnak(string oper)
        {
            if (infoClik.Text != "На ноль делить нельзя!")
            {
                if (operetion != "")
                {
                    double n2;
                    n2 = Convert.ToDouble(infoClik.Text);

                    number1 = conculator.Run(operetion, number1, n2);
                    operetion = oper;
                    info.Text = number1 + operetion;

                }
                else
                {
                    number1 = Convert.ToDouble(infoClik.Text);
                    operetion = oper;
                    info.Text = number1 + operetion;
                }
                infoClik.Text = "";
                infoClik.Focus();
            }
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            if (infoClik.Text != "")
            {
                double n2;
                n2 = Convert.ToDouble(infoClik.Text);
                info.Text = number1 + operetion + infoClik.Text + '=';
                if (operetion == "÷" && infoClik.Text == "0")
                {
                    infoClik.Text = "На ноль делить нельзя!";
                }
                else
                {
                    infoClik.Text = Convert.ToString(conculator.Run(operetion, number1, n2));
                    operetion = "";
                }
                infoClik.Focus();
                Drobi = true;
            }
        }

        private void infoClik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                infoClik.Text += e.KeyChar.ToString();
            }
            e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter) { button_equals_Click(null, null); }
            if (e.KeyChar == '/') { Znak_Delit_Click(null, null); }
            if (e.KeyChar == '+') { Znak_Plus_Click(null, null); }
            if (e.KeyChar == '-') { Znak_Minus_Click(null, null); }
            if (e.KeyChar == '*') { Znak_Umnotit_Click(null, null); }
            if (e.KeyChar == ',') { button_Drobi_Click(null, null); }
            infoClik.Focus();
        }

        private void Znak_Delit_Click(object sender, EventArgs e)
        {
            if (infoClik.Text != "")
            {
                string operation = "÷";
                runZnak(operation);
                infoClik.Focus();
                Drobi = true;
            }
        }

        private void Znak_Umnotit_Click(object sender, EventArgs e)
        {
            if (infoClik.Text != "")
            {
                string operation = "×";
                runZnak(operation);
                infoClik.Focus();
                Drobi = true;
            }
        }

        private void Znak_Minus_Click(object sender, EventArgs e)
        {
            if (infoClik.Text != "")
            {
                string operation = "-";
                runZnak(operation);
                infoClik.Focus();
                Drobi = true;
            }

        }

        private void Znak_Plus_Click(object sender, EventArgs e)
        {
            if (infoClik.Text != "")
            {
                string operation = "+";
                runZnak(operation);
                infoClik.Focus();
                Drobi = true;
            }
        }

        private void plusMinus_Click(object sender, EventArgs e)
        {
            double dn = -Convert.ToDouble(infoClik.Text);
            infoClik.Text = dn.ToString();
            infoClik.Focus();
        }

        private void button_Drobi_Click(object sender, EventArgs e)
        {

            if (Drobi)
            {
                if (infoClik.Text == "")
                {
                    infoClik.Text = "0" + ',';
                }
                else { infoClik.Text += ','; }
            }
            infoClik.Focus();
            Drobi = false;
        }

        private void Color_Click(object sender, EventArgs e)
        {
            if (!color)
            {
                Buttons.BackColor = Color.Black;
                Buttons.ForeColor = Color.White;
                BackColor = Color.Black;
                info.ForeColor = Color.White;
                infoClik.ForeColor = Color.White;
                infoClik.BackColor = Color.Black;

                color = true;
            }
            else
            {
                Buttons.BackColor = Color.White;
                Buttons.ForeColor = Color.Black;
                BackColor = Color.White;
                info.ForeColor = Color.Black;
                infoClik.ForeColor = Color.Black;
                infoClik.BackColor = Color.White;
                color = false;
            }
            infoClik.Focus();
        }

        private void DeleteSimvol_Click(object sender, EventArgs e)
        {
            infoClik.Text = infoClik.Text.Remove(infoClik.Text.Length - 1);
            infoClik.Focus();
        }

        private void MPlus_Click(object sender, EventArgs e)
        {

            if (double.TryParse(infoClik.Text, out double value))
            {
                M = Convert.ToDouble(infoClik.Text);
            }

        }

        private void MMinus_Click(object sender, EventArgs e)
        {
            M = 0;
        }

        private void M_Click(object sender, EventArgs e)
        {
            infoClik.Text = Convert.ToString(M);
        }

        private void number_2_Click(object sender, EventArgs e)
        {
            if (infoClik.Text != "На ноль делить нельзя!" && infoClik.Text.Length < 16)
            {
                Button B = (Button)sender;
                infoClik.Text = infoClik.Text + B.Text;
            }
            infoClik.Focus();
        }
    }
}