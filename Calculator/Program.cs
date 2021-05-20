using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Soma()
        {
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float result = v1 + v2;
            Console.WriteLine($"Soma dos Valores é: " + result);
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float result = v1 - v2;
            Console.WriteLine($"Subtração dos Valores é: " + result);
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float result = v1 / v2;
            Console.WriteLine($"Divisão dos Valores é: " + result);
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float result = v1 * v2;
            Console.WriteLine($"Multiplicação dos Valores é: " + result);
            Console.ReadKey();
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação de calculo gostaria de fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.WriteLine("0 - Fechar Calculadora");
            Console.WriteLine("-----------------------");

            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 0:
                    Console.WriteLine("Obrigado, Volte sempre!!");
                    System.Environment.Exit(0);
                    break;
                default: Menu(); break;
            }
        }
    }
}
