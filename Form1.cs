using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        //Método Construtor
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int testeVirgula;
        public int testeParenteses;
        enum Operacoes//enum é uma lista de coisas
        {
            Soma,
            Subtrai,
            Multiplica,
            Divide,
            Nenhuma
        }

        static Operacoes ultimaOperacao = Operacoes.Nenhuma;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "%";
            testeVirgula = 0;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao != Operacoes.Nenhuma)
            {
                FazerCalculo(ultimaOperacao);
            }
            ultimaOperacao = Operacoes.Nenhuma;
            testeVirgula = 0;
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Divide;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
            testeVirgula = 0;
        }


        private void buttonNum_Click(object sender, EventArgs e)
        {
            //  textBoxDisplay.Text += "0";
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void buttonMultiplica_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Multiplica;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
            testeVirgula = 0;
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            ultimaOperacao = Operacoes.Nenhuma;
            testeVirgula = 0;
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Subtrai;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
            testeVirgula = 0;
        }

        private void buttonAdicao_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Soma;
            }
            else
            {
                FazerCalculo(ultimaOperacao);

            }
            textBoxDisplay.Text += (sender as Button).Text;
            testeVirgula = 0;
        }

        private void FazerCalculo(Operacoes ultimaOperacao)
        {
            List<double> ListaDeNumeros = new List<double>();

            switch (ultimaOperacao)
            {
                case Operacoes.Soma:
                    ListaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] + ListaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Subtrai:
                    ListaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] - ListaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Multiplica:
                    ListaDeNumeros = textBoxDisplay.Text.Split('x').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] * ListaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Divide:
                    try
                    {
                        ListaDeNumeros = textBoxDisplay.Text.Split('÷').Select(double.Parse).ToList();
                        textBoxDisplay.Text = (ListaDeNumeros[0] / ListaDeNumeros[1]).ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        textBoxDisplay.Text = "Divisão por zero";
                    }

                    break;
                case Operacoes.Nenhuma:
                    break;
                default:
                    break;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }


        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            if (testeVirgula != 1)
            {

                textBoxDisplay.Text = textBoxDisplay.Text + ",";
                testeVirgula = 1;

            }
            else
            {
                return;
            }

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        { 
        if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
                if (textBoxDisplay.Text.EndsWith(","))
                {
                    testeVirgula = 0;
                }
            }                 
        else
            {
                return;
            }
        }
        private void buttonSinal_Click(object sender, EventArgs e)
        {

        }
    }
}
