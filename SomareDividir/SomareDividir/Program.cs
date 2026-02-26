using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomareDividir
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();


            Console.WriteLine("--- Mini Calculadora ---");
            Console.WriteLine("Soma (10 + 5): " + calc.Somar(10, 5));
            Console.WriteLine("Divisão (10 / 4): " + calc.Dividir(10, 4));
            Console.WriteLine("multiplicação (10 * 7): " + calc.Multiplicar(10, 7));
            Console.WriteLine("subtrair (40 - 10): " + calc.Subtrair(40, 10));


            Console.ReadKey();
        }
    }
}
