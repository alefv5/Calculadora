using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        private double _cifraGuardada;
        private string _operador;

        public Calculadora()
        {
            _cifraGuardada = -1;
            _operador = "";
        }

        public void definirOperador(string operador)
        {
            _operador = operador;
        }

        public void borrarCifraGuardada()
        {
            _cifraGuardada = -1;
        }

        public void IngresarCifra(double nuevaCifra)
        {
            if(_cifraGuardada == -1)
            {
                _cifraGuardada = nuevaCifra;
            }
            else
            {
                _cifraGuardada = Calcular(nuevaCifra);
            }
        }
        
        public double Calcular(double cifraIngresada)
        {
            double resultado = 0;
            switch (_operador)
            {
                case "+":
                    resultado = _cifraGuardada + cifraIngresada;
                    break;
                case "-":
                    resultado = _cifraGuardada - cifraIngresada;
                    break;
                case "*":
                    resultado = _cifraGuardada * cifraIngresada;
                    break;
                case "/":
                    resultado = _cifraGuardada / cifraIngresada;
                    break;
            }
            return resultado;
        }

    }
}
