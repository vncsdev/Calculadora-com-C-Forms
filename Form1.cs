using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "0"; 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtVisor.Text += ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(txtVisor.Text != "")
            {
                valor2 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);

                switch (operacao)
                {
                    case "+":
                        txtVisor.Text = Convert.ToString(valor1 + valor2);
                        break;
                    case "-":
                        txtVisor.Text = Convert.ToString(valor1 - valor2);
                        break;
                    case "*":
                        txtVisor.Text = Convert.ToString(valor1 * valor2);
                        break;
                    case "/":
                        txtVisor.Text = Convert.ToString(valor1 / valor2);
                        break;

                }

                lblOperador.Text = "=";
            }
            else
            {
                MessageBox.Show("Informe um valor!");

            }

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
                lblOperador.Text = "-";
                operacao = "-";
                txtVisor.Clear();
            }
            else
            {
                MessageBox.Show("Informe um valor!");
            }
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
                lblOperador.Text = "*";
                operacao = "*";
                txtVisor.Clear();
            }
            else
            {
                MessageBox.Show("Informe um valor!");
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
                lblOperador.Text = "/";
                operacao = "/";
                txtVisor.Clear();
            }
            else
            {
                MessageBox.Show("Informe um valor!");
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if(txtVisor.Text != "")
            {
                txtVisor.Clear();
                txtVisor.Focus();
            }
            else
            {
                MessageBox.Show("Informe um valor!");
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {

            if(txtVisor.Text != "")
            {
                txtVisor.Clear();

                valor1 = 0;
                valor2 = 0;

                lblOperador.Text = "";
                txtVisor.Focus();
            }
            else
            {
                MessageBox.Show("Informe um valor!");
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {

            if(txtVisor.Text != "")
            {
                valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
                lblOperador.Text = "+";
                operacao = "+";
                txtVisor.Clear();
            }
            else
            {
                MessageBox.Show("Informe um valor!");
            }
        }
    }
}
