using System;

namespace Calculator
 {
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); //ele limpa a tela
            Console.WriteLine("PRIMEIRO VALOR: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("SEU NOME: ");
            string nome = Console.ReadLine();
            

            Console.WriteLine("ola " + nome + " seu saldo é de " + v1);
            //testando o git
        }
    }
 }
