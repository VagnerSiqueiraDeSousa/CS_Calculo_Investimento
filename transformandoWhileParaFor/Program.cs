using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * Dessa vez, Clarice resolveu desafiar Fernando a transformar o código a seguir 
 * que utiliza um laço while em um código que utilize o for. Você consegue ajudar Fernando
 * a chegar a resposta do desafio? Compare a sua resposta com a do instrutor e verifique se acertou!
 * 
 * 
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(String[] args)
    {
        int contador = 1;            
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }
    }
}
 
 **/




namespace transformandoWhileParaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("desafio transformando o While em For");

            for (int contador =1; contador <=10; contador ++ )
            {
                Console.WriteLine(contador);

            }



            Console.ReadLine();
        }
    }
}
