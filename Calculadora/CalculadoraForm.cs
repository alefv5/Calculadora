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
    public partial class CalculadoraForm : Form
    {
        private Calculadora calculadora;

        public CalculadoraForm()
        {
            InitializeComponent();
            calculadora = new Calculadora();
        }

        private void introducirAPantalla(string nuevoNumero)
        {
            Pantalla.Text = Pantalla.Text + nuevoNumero;
        }

        private void botonNumeros_Click(object sender, EventArgs e)
        {
            Button numeroPresionado = (Button)sender;
            introducirAPantalla(numeroPresionado.Text);
        }

        private void botonOperador_Click(object sender, EventArgs e)
        {
            Button operadorPresionado = (Button)sender;
            calculadora.guardarParametros(double.Parse(Pantalla.Text), operadorPresionado.Text);
            Pantalla.Clear();
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            double res = calculadora.calcular(double.Parse(Pantalla.Text));
            Pantalla.Text = res.ToString();
            calculadora.reiniciarParametros();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            calculadora.reiniciarParametros();
            Pantalla.Clear();
        }

    }
}
