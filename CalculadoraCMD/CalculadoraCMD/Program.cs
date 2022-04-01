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
            Potencia = 4,
            Raiz = 5,
            Sair = 6,
        } 

        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair)
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine("_________________________________________________________________\n");
            Console.WriteLine("Bem Vindo a Minha Primeira Calculadora!\nSelicione uma das opções:");
            Console.WriteLine("_________________________________________________________________\n");

            Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Potencia\n5 - Raiz\n6 - Sair");

                        /*Casting*/
            Menu opcao = (Menu)int.Parse(Console.ReadLine());

            Console.WriteLine(opcao);

            switch (opcao)
	        {
	            case Menu.Sair:
                        escolheuSair = true;
                break;
	        }

            }


            
        
        }
    }
}
