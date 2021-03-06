using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraCMD
{
    internal class Program
    {

        enum Menu
        {
            Soma = 1,
            Subtracao = 2,
            Multiplicacao = 3,
            Divisão = 4,
            Potencia = 5,
            Raiz = 6,
            Sair = 7,
        }

        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();

                Console.WriteLine("_________________________________________________________________\n");
                Console.WriteLine("Bem Vindo a Minha Primeira Calculadora!\nSelecione uma das opções:");
                Console.WriteLine("_________________________________________________________________\n");

                Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Potencia\n6 - Raiz\n7 - Sair");

                /*Casting*/
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        break;

                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;

                    case Menu.Divisão:
                        Divisao();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                }


                Console.Clear();
            }




        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois Números:");
            Console.WriteLine("Digite o primeiro Número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro Segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois Números:");
            Console.WriteLine("Digite o primeiro Número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado da subtrção entre {a} e {b}: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois Números:");
            Console.WriteLine("Digite o primeiro Número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado da multiplicação entre {a} e {b}: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisão de dois Números:");
            Console.WriteLine("Digite o primeiro Número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a / b;
            Console.WriteLine($"O resultado da divisão entre {a} e {b}: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Potência de dois Números:");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado da potência entre a base {baseNum} e o expoente {expo}: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de dois Numeros:");
            Console.WriteLine("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"A raiz do número {a} é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

    }

}
