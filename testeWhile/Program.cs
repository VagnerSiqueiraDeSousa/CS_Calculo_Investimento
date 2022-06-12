using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste com Operador logico ");
            

            int contador = 1;

            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            Console.ReadLine();
        }

    }
}
// Este programa foi feito como um desafio para descobrimos onde estava o erro da logica
// Aqui no caso não tinha a variavel contador++ onde deixava o programa executa sem para.

//Na expressão condicional do while é possível utilizar qualquer operador de comparação (< [menor], > [maior], <= [menor ou igual], >= [maior ou igual], == [igual a] e != [diferente de]) e qualquer operador lógico (&& [and], || [ou]).
//O while sempre precisará de uma expressão condicional que definirá quando o laço deve ser interrompido.