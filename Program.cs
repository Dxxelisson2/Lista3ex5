using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double valor1;

            do
            {
                Console.WriteLine("digte o valor positivo para inicar a tabuada ");
                valor1 = double.Parse(Console.ReadLine());

                if (valor1 <= 0)
                {
                    Console.WriteLine("valor invalido para geração da tabuada");
                    Console.WriteLine();
                    
                }

                else
                {
                    Console.WriteLine("Valor Aceito Tabuada sendo Gerada...");

                }
            } while (valor1 <= 0);

            

            for (double i = 0; i < 11; i++)
            {
                double resultado = valor1 * i;
                Console.WriteLine(valor1 + "x" + i + "=" + resultado);
            }
                

            

        }
    }
}
