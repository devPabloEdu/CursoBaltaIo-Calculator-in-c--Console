using System;

namespace Calculator
 {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESCOLHA UMA DE NOSSAS OPERAÇÕES :");
            Console.WriteLine("----------------------");
            Console.WriteLine("soma - subtracao - divisao - multiplicacao");
            Console.WriteLine("----------------------");

            string operacaoSelecionada = Console.ReadLine();

            string resultadoOperacoes = Calculadora(operacaoSelecionada);

            Console.WriteLine(resultadoOperacoes);
        }
        public static string Calculadora(string acao){

            float resultadoOperacoesfinal;

            switch(acao){
                case "soma" : Soma();
                break;
                case "subtracao" : Subtracao();
                break;
                case "divisao" : Divisao();
                break;
                case "multiplicacao" : Multiplicacao();
                break;
                default : return "Prezado, usuario, insira uma operação válida!!";
            }
            return "operação concluida!";
        }
        static void Soma(){
            Console.Clear(); //ele limpa a tela

            Console.WriteLine("PRIMEIRO VALOR: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("SEGUNDO VALOR:");
            float v2 = float.Parse(Console.ReadLine());   
             
            float resultado = v1 + v2;    
            Console.WriteLine("");   
            Console.WriteLine($"O resultado da soma é: {resultado}");

            Console.ReadKey();
        }
        static void Subtracao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor : ");
            float subtracaoValor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("SEGUNDO VALOR : ");
            float subtracaoValor2 = float.Parse(Console.ReadLine());

            float resultadoSubtracao = subtracaoValor1 - subtracaoValor2;
            Console.WriteLine(""); 
            Console.WriteLine($"O resultado da subtração é : {resultadoSubtracao}");  

            Console.ReadKey();
    }
        static void Divisao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor : ");
            float divisaoValor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("SEGUNDO VALOR : ");
            float divisaoValor2 = float.Parse(Console.ReadLine());

            float resultadoDivisao = divisaoValor1 / divisaoValor2;
            Console.WriteLine(""); 
            Console.WriteLine($"O resultado da subtração é : {resultadoDivisao}");
        }
        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor : ");
            float mValor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("SEGUNDO VALOR : ");
            float mValor2 = float.Parse(Console.ReadLine());

            float resultadoM = mValor1 * mValor2;
            Console.WriteLine(""); 
            Console.WriteLine($"O resultado da subtração é : {resultadoM}");
        }
    }   
 }
