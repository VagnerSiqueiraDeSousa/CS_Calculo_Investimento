using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_bool
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double salario = 3000.0 ;
            bool foiPromovida = true;

            if (foiPromovida)
            {
                foiPromovida = true;
            }

            else
            {
                foiPromovida = false;
            }
            if(salario >= 4000.0 && foiPromovida)
            {
                Console.WriteLine("Você foi Promovido");
            }

            else
            {
                Console.WriteLine("Infelizmento a sua promoção ainda não chegou");
            }
            Console.WriteLine(salario);

            Console.ReadLine();
        }
    }
}
