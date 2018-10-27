using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double volume, raio, altura;
            const Double PI = 3.14159;

            Console.Write(" Informe o valor do raio: ");
            raio = double.Parse(Console.ReadLine());


            Console.Write(" Informe a altura: ");
            altura = double.Parse(Console.ReadLine());

            volume = PI * Math.Pow(raio,2) * altura;

            Console.Write(" O volume da lata é :" + volume);
            

        }
    }
}
