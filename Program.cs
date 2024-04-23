using System;

namespace calculator
{

    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que Deseja Fazer? ");
            Console.WriteLine("");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("---------------------");

            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }
        static void Soma()
        {

            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float numberTwo = float.Parse(Console.ReadLine());

            float result = numberOne + numberTwo;

            Console.WriteLine("");

            Console.WriteLine($"O Resultado da soma é: {result}");
            Console.ReadKey();
            Menu();

        }
        static void Subtracao()

        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float numberTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = numberOne - numberTwo;
            Console.WriteLine($"O Resultado da Subtração é: {result}");
            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float numberTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = numberOne / numberTwo;
            Console.WriteLine($"O Resultado da Divisão é: {result}");
            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {

            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float numberTwo = float.Parse(Console.ReadLine());


            float result = numberOne * numberTwo;

            Console.WriteLine("");

            Console.WriteLine($"O Resultado da Multiplicação é: {result}");
            Console.ReadKey();
            Menu();

        }
    }

}