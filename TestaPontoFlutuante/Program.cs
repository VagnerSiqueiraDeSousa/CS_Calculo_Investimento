using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Oi Vagner, Vamos fazer teste com ponto flutuante");

            double salario = 1250.70;
            Console.WriteLine("O Seu salario é " + salario);


            double divisao = 5.0 / 2;
            Console.WriteLine("5.0 / 2 = " + divisao + " o resultado é " +  divisao);

            double peso = 4.0;
            int quantidade = 10;
            Console.WriteLine(peso * quantidade);


           

            Console.WriteLine("A Execução terminou pressoine entre para Sair ...");
            Console.ReadLine();
        }
    }
}
