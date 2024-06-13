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

            Console.WriteLine("SEGUNDO VALOR:");
            float v2 = float.Parse(Console.ReadLine());   
             
            float resultado = v1 + v2;    
            Console.WriteLine("");   
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da soma é : {resultado}");

        }
    }
 }
