using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {

           
          
            int nascimento, atual, proximo, a;
           
           
            Console.WriteLine(" digite sua data de nascimento: ");
            nascimento = int.Parse(Console.ReadLine());
            Console.WriteLine(" qual o ano atual: ");
            atual = int.Parse(Console.ReadLine());
            a = atual - nascimento;
            proximo = 2022 - nascimento;
            Console.WriteLine("A sua idade é " + a + " Em 2022 você terá " + proximo);
  




        }
    }
}
