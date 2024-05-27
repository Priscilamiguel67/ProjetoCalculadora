using System;

namespace projetodeCodigocalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUAL OPERAÇÃO DESEJA REALIZAR?");
            Console.WriteLine("1: Adição");
            Console.WriteLine("2: Multiplicação");
            Console.WriteLine("3: Divisão");
            Console.WriteLine("4: Subtração");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE O PRIMEIRO VALOR:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE O SEGUNDO VALOR:");
            int num2 = int.Parse(Console.ReadLine());

            Calculadora calculadora = new Calculadora(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            int result = 0;
            bool operacaoValida = true;

            switch (operacao)
            {
                case 1:
                    result = calculadora.somar(num1, num2);
                    break;
                case 2:
                    result = calculadora.multiplicar(num1, num2);
                    break;
                case 3:
                    result = calculadora.dividir(num1, num2);
                    break;
                case 4:
                    result = calculadora.subtrair(num1, num2);
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    operacaoValida = false;
                    break;
            }

            if (operacaoValida)
            {
                Console.WriteLine("O resultado é: " + result);
            }

            /*Console.WriteLine("Histórico de operações:");
            foreach (var item in calculadora.historico())
            {
                Console.WriteLine(item);
            }*/
        }
    }
}
