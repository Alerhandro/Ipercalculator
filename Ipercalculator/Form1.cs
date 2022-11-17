using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ipercalculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operador = "";
        bool operador_presionado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((resultado.Text == "0") || (operador_presionado))
                resultado.Clear();
            
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if(!resultado.Text.Contains("."))
                    resultado.Text = resultado.Text + b.Text;
            }
            else
              resultado.Text = resultado.Text +b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
        }

        private void operador_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                iqual.PerformClick();
                operador_presionado = true;
                operador = b.Text;
                label1.Text = value + " " + operador;
            }
            else
            {
                operador = b.Text;
                value = Double.Parse(resultado.Text);
                operador_presionado = true;
                label1.Text = value + " " + operador;
            }
        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            switch (operador)
            {
                case "+":
                    resultado.Text = (value + Double.Parse(resultado.Text)).ToString();
                    break;

                case "-":
                    resultado.Text = (value - Double.Parse(resultado.Text)).ToString();
                    break;

                case "*":
                    resultado.Text = (value * Double.Parse(resultado.Text)).ToString();
                    break;

                case "/":
                    resultado.Text = (value / Double.Parse(resultado.Text)).ToString();
                    break;

                default:
                    break;

            }//final switch
            value = Int32.Parse(resultado.Text);
            operador = "";
            operador_presionado = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    um.PerformClick();
                    break;
                case "2":
                    dois.PerformClick();
                    break;
                case "3":
                    tres.PerformClick();
                    break;
                case "4":
                    quatro.PerformClick();
                    break;
                case "5":
                    cinco.PerformClick();
                    break;
                case "6":
                    seis.PerformClick();
                    break;
                case "7":
                    sete.PerformClick();
                    break;
                case "8":
                    oito.PerformClick();
                    break;
                case "9":
                    nove.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "+":
                    mais.PerformClick();
                    break;
                case "-":
                    menos.PerformClick();
                    break;
                case "*":
                    vez.PerformClick();
                    break;
                case "=":
                    iqual.PerformClick();
                    break;
                default:
                    break;

            }
        }
    }
}
