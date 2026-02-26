using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomareDividir
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public double Dividir(int a, int b)
        {
            if (b == 0)
            {
                
                Console.WriteLine("Erro, não divide por zero");
                return 0;
            }
            return (double)a / b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

    }
}
