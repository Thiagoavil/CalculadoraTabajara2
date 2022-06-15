using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabajara2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            while (true)
            {
                #region Menu Principal

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela Principal\n");

                Console.WriteLine("1 - Para Adição ");
                Console.WriteLine("2 - Para Subtração ");
                Console.WriteLine("3 - Para Multiplicação ");
                Console.WriteLine("4 - Para Divisão ");

                Console.WriteLine("Digite S para sair\n");

                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                #endregion

                #region Realizar Calculo

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                string operacao = "";

                switch (opcao)
                {
                    case "1":
                        operacao = "Adição";
                        break;

                    case "2":
                        operacao = "Multiplicação";
                        break;

                    case "3":
                        operacao = "Adição";
                        break;

                    case "4":
                        operacao = "Divisão";
                        break;

                    default:
                        break;
                }

                string subtitulo = $"Novo calculo de {operacao}";

                Console.WriteLine(subtitulo + "\n");

                Console.Write($"Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Digite o segundo número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case "1":
                        resultado = RealizarAdicao(primeiroNumero, segundoNumero);
                        break;

                    case "2":
                        resultado = Subtracao(primeiroNumero, segundoNumero);
                        break;

                    case "3":
                        operacao = "Adição";
                        break;

                    case "4":
                        resultado = RealizarDivisao(primeiroNumero, segundoNumero);
                        break;

                    default:
                        break;
                }
                #endregion

                #region Mostrar Resultado
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela de Resultados\n");

                Console.Write($"O resultado da operação de {operacao} é: {resultado}");

                Console.WriteLine();

                Console.ReadLine();

                Console.Clear();
                #endregion
            }
        }

        private static double RealizarDivisao(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero / segundoNumero;
        }

        private static double RealizarAdicao(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }
        public static double Subtracao(double x1, double x2)
        {
            return x1 - x2;
        }
    }
}