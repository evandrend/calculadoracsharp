using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWindowsDez
{
    public partial class Form1 : Form
    {
        bool click_operacao = true;
        double num1=0,num2=0;
        double resultado=0;
        //comentei
        string op;

        public void escreva(int numero_lido)
        {
            if (click_operacao == true)
            {
                num1 = double.Parse(textBox1.Text);
                
                textBox1.Text = numero_lido.ToString();
                click_operacao = false;
            }
            else
            {
                textBox1.Text += numero_lido;

            }
        }
        public void manipulando()
        {
            double resultado = 0;
            num2 = double.Parse(textBox1.Text);
            if (op == "+")
            {
                resultado = num2 + num1;
                textBox1.Text = resultado.ToString();
                op = "";

            }
            else if (op == "-")
            {
                resultado = num1 - num2;
                textBox1.Text = resultado.ToString();


            }

            else if (op == "X")
            {
                resultado = num1 * num2;
                textBox1.Text = resultado.ToString();


            }
            else if (op == "÷")
            {
                resultado = num1 / num2;
                textBox1.Text = resultado.ToString();


            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            escreva(7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            escreva(8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            escreva(9);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            escreva(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            escreva(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            escreva(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            escreva(1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            escreva(2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            escreva(3);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            escreva(0);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
            int tamanho = textBox1.Text.Length;
            if (tamanho == 0)
            {
                textBox1.Text = "0";
            }
            op = "÷";
            label1.Text = textBox1.Text + " " + op;
            click_operacao = true;
            
       
        }

        private void button18_Click(object sender, EventArgs e)
        {

            int tamanho = textBox1.Text.Length;
            if (tamanho == 0)
            {
                textBox1.Text = "0";
            }
            op = "X";
            label1.Text = textBox1.Text + " " + op;
            click_operacao = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int tamanho = textBox1.Text.Length;
            if (tamanho == 0)
            {
                textBox1.Text = "0";
            }
            op = "-";
            label1.Text = textBox1.Text + " " + op;
            click_operacao = true;
            

        }

        private void button20_Click(object sender, EventArgs e)
        {
            int tamanho = textBox1.Text.Length;
            if (tamanho == 0)
            {
                textBox1.Text = "0";
            }
            op = "+";
            label1.Text = textBox1.Text + " " + op;
            click_operacao = true;
           
         
           
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label1.Text="";
            manipulando();
            click_operacao = true;
        
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = 0.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = 0.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            click_operacao = true;
            int tamanho = textBox1.Text.Length;
            if (tamanho > 0)
            {
                if (tamanho == 1)
                {
                    textBox1.Text = 0.ToString();
                }
                else
                textBox1.Text = textBox1.Text.Substring(0, tamanho - 1);
            
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            resultado = (double.Parse(textBox1.Text)) * (double.Parse(textBox1.Text));
            label1.Text = "( " + textBox1.Text + " )^2";
            textBox1.Text = resultado.ToString();
            click_operacao = true;
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            resultado = Math.Sqrt(double.Parse(textBox1.Text));
            label1.Text = "Sqrt( " + textBox1.Text + " )";
            textBox1.Text = resultado.ToString();
            click_operacao = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            resultado = 1 / (double.Parse(textBox1.Text));
            label1.Text = "1/( " + textBox1.Text + " )";
            textBox1.Text = resultado.ToString();
            click_operacao = true;
        }
      
        private void button12_Click(object sender, EventArgs e)
        {
            int tamanho=textBox1.Text.Length;
            if (tamanho !=0 )
            {

                textBox1.Text = ",";    
                
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            resultado = 0.001* (double.Parse(textBox1.Text));
            label1.Text = "( " + textBox1.Text + " )/100";
            textBox1.Text = resultado.ToString();
            click_operacao = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resultado = -1* (double.Parse(textBox1.Text));
            label1.Text = "negate( " + textBox1.Text + " )";
            textBox1.Text = resultado.ToString();
            click_operacao = true;
        }

      
    }
}
