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

        public void reiniciarParametros()
        {
            _cifraGuardada = -1;
            _operador = "";
        }

        public void guardarParametros(double nuevaCifra,string operador)
        {
            _operador = operador;
            _cifraGuardada = _cifraGuardada == -1 ? nuevaCifra : calcular(nuevaCifra);

        }
        
        public double calcular(double cifraIngresada)
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
