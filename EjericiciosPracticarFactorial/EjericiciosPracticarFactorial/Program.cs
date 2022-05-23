using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericiciosPracticarFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El Factorial De Un Numero");
            int n = 0;
            int c = 0;
            int factorial = 1;
            Console.WriteLine("Ingrese Un  Numero");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=n; i++)

            {

                c = c + 1;
                factorial = factorial * c;
            }

            Console.WriteLine("El Factorial De " + n + " es: "+ factorial);
            Console.ReadKey();
        }
    }

}