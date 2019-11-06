using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double valor1, valor2, R;
        char operacao;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void numero1_Click(object sender, EventArgs e)
        {
            batata12.Text += 1;
            batata13.Text += 1;
        }

        private void numero2_Click(object sender, EventArgs e)
        {
            batata12.Text += 2;
            batata13.Text += 2;

        }

        private void numero3_Click(object sender, EventArgs e)
        {
            batata12.Text += 3;
            batata13.Text += 3;
        }

        private void numero4_Click(object sender, EventArgs e)
        {
            batata12.Text += 4;
            batata13.Text += 4;
        }

        private void numero5_Click(object sender, EventArgs e)
        {
            batata12.Text += 5;
            batata13.Text += 5;
        }

        private void numero6_Click(object sender, EventArgs e)
        {
            batata12.Text += 6;
            batata13.Text += 6;
        }

        private void numero7_Click(object sender, EventArgs e)
        {
            batata12.Text += 7;
            batata13.Text += 7;
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            batata12.Text += 8;
            batata13.Text += 8;
        }

        private void igual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(batata13.Text);
            switch (operacao)
            {
                case '+':
                    R = valor1 + valor2;
                    break;
                case '-':
                    R = valor1 - valor2;
                    break;
                case '*':
                    R = valor1 * valor2;
                    break;
                case '/':
                    if (valor2 != 0)
                    {
                        R = valor1 / valor2;
                    }
                    else
                    {
                        MessageBox.Show("invalido");
                    }
                    break;
            }

            batata13.Text = R.ToString();
        }

        private void mais_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(batata13.Text);
            batata12.Text += "+";
            operacao = '+';
            batata13.Clear();
        }

        private void menos_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(batata13.Text);
            batata12.Text += "-";
            operacao = '-';
            batata13.Clear();
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(batata13.Text);
            batata12.Text += "*";
            operacao = '*';
            batata13.Clear();
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(batata13.Text);
            batata12.Text += "/";
            operacao = '/';
            batata13.Clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                batata12.Text = batata12.Text.Substring(0, batata12.Text.Length - 1);
                batata13.Text = batata13.Text.Substring(0, batata13.Text.Length - 1);
            }
            catch
            {


            }
        }

        private void numero9_Click(object sender, EventArgs e)
        {
            batata12.Text += 9;
            batata13.Text += 9;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            batata12.Text += 0;
            batata13.Text += 0;
        }
    }
}
