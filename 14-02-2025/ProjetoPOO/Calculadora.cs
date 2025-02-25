using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoPOO;


namespace ProjetoPOO
{
    public class Calculadora
    {
        public double Numero1;
        public double Numero2;
        
        public double Soma()
        {
            return Numero1 + Numero2;
        }

        public double Subtracao()
        {
            return Numero1 - Numero2;
        }

        public double Multiplicacao()
        {
            return Numero1 * Numero2;
        }

        public double Divisao()
        {
            return Numero1 / Numero2;
        }

        public double Potenciacao()
        {
            return Math.Pow(Numero1, Numero2);
        }

        public double RaizQuadrada()
        {
            return Math.Sqrt(Numero1 * Numero2);
        }
    }

}



