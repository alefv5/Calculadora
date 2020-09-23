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
        private Calculadora calculadora;

        public Form1()
        {
            InitializeComponent();
            calculadora = new Calculadora();
        }

        private void modificarPantalla(string elemento)
        {
            Pantalla.Text = Pantalla.Text + elemento;
        }

        private void botonNumeros_Click(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            modificarPantalla(botonPresionado.Text);
        }

        private void botonOperador_Click(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            calculadora.definirOperador(botonPresionado.Text);
            calculadora.IngresarCifra(double.Parse(Pantalla.Text));
            Pantalla.Clear();
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            double res = calculadora.Calcular(double.Parse(Pantalla.Text));
            Pantalla.Text = res.ToString();
            calculadora.borrarCifraGuardada();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            calculadora.borrarCifraGuardada();
            Pantalla.Clear();
        }
    }
}
