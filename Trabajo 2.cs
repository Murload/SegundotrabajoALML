using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_2
{
    public partial class Form1 : Form
    {

        Calculos operacion = new Calculos();
        
        

        double primero, segundo;
        string operador;

         public Form1()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operador = "!";
            primero = double.Parse(txtnumeros.Text);
            txtnumeros.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "¿Desea cerrar la calculadora?";
            string title = "Trabajo 2";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtnumeros.Text);

            double sum;
            double res;
            double mul;
            double div;
            double fac;

            switch (operador)
            {
                case "+":
                    {
                        sum = operacion.sumas((primero), (segundo));
                        lblrespuestas.Text = sum.ToString();
                    }
                    break;
                case "-":
                    {
                        res = operacion.resta((primero), (segundo));
                        lblrespuestas.Text = res.ToString();
                    }
                    break;
                case "*":
                    {
                        mul = operacion.multiplicacion((primero), (segundo));
                        lblrespuestas.Text = mul.ToString();
                    }
                    break;
                case "/":
                    {
                        div = operacion.division((primero), (segundo));
                        lblrespuestas.Text = div.ToString();
                    }
                    break;
                case "!":
                    {
                        fac = operacion.factorial(primero);
                        lblrespuestas.Text = fac.ToString();
                    
                    
                    }
                    break; 
            }
           



        }

        private void btn7_Click(object sender, EventArgs e)
        {

           txtnumeros.Text = txtnumeros.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtnumeros.Text = txtnumeros.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtnumeros.Text = txtnumeros.Text + "9";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtnumeros.Text = txtnumeros.Text + "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtnumeros.Text = txtnumeros.Text + "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtnumeros.Text = txtnumeros.Text + "4";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtnumeros.Text = txtnumeros.Text + "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtnumeros.Text = txtnumeros.Text + "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtnumeros.Text = txtnumeros.Text + "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtnumeros.Text = txtnumeros.Text + "0";
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txtnumeros.Text);
            txtnumeros.Clear();

        }

        private void btnpor_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txtnumeros.Text);
            txtnumeros.Clear();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txtnumeros.Text);
            txtnumeros.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtnumeros.Clear();
            lblrespuestas.Text = "";

        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txtnumeros.Text);
            txtnumeros.Clear();
        }
    }
}
