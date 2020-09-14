using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resp;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);
            switch(operador)
            {
                case "+":
                    resp = primero + segundo;
                    Pantalla.Text = resp.ToString();
                    break;
                case "-":
                    resp = primero - segundo;
                    Pantalla.Text = resp.ToString();
                    break;
                case "*":
                    resp = primero * segundo;
                    Pantalla.Text = resp.ToString();
                    break;
                case "/":
                    resp = primero / segundo;
                    Pantalla.Text = resp.ToString();
                    break;
            }
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void botonMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void botonDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void botonPunto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void botonDEL_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }
    }
}
