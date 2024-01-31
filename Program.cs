using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool realizarOperacao = true;

            while (realizarOperacao)
            {
                Console.WriteLine("Qual operação deseja fazer?");
                Console.WriteLine("1- Adição");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Multiplicação");
                Console.WriteLine("4- Divisão");
                Console.WriteLine("5- Porcentagem");
                Console.WriteLine("6- Raiz Quadrada");
                Console.WriteLine("7- Potenciação");

                int operacao = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (operacao)
                {
                    case 1:
                        resultado = Adicao(num1, LerNumero());
                        break;
                    case 2:
                        resultado = Subtracao(num1, LerNumero());
                        break;
                    case 3:
                        resultado = Multiplicacao(num1, LerNumero());
                        break;
                    case 4:
                        resultado = Divisao(num1, LerNumero());
                        break;
                    case 5:
                        resultado = Porcentagem(num1, LerNumero());
                        break;
                    case 6:
                        resultado = RaizQuadrada(num1);
                        break;
                    case 7:
                        resultado = Potenciacao(num1, LerNumero());
                        break;
                    default:
                        Console.WriteLine("Número ou Operação inválido. O programa será encerrado.");
                        return;
                }

                Console.WriteLine($"O resultado da operação é: {resultado}");

                Console.WriteLine("Deseja realizar mais uma operação? (Sim/Não)");

                string resposta = Console.ReadLine();

                if (resposta.ToLower() != "sim")
                {
                    realizarOperacao = false;
                }
            }

            Console.WriteLine("Programa encerrado.");
            Console.ReadLine();
        }

        private static double LerNumero()
        {
            Console.WriteLine("Digite o segundo número: ");

            double numero;
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Número inválido. Por favor, insira um número válido.");
            }

            return numero;
        }


        public static double Adicao(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public static double Subtracao(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public static double Multiplicacao(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public static double Porcentagem(double num1, double num2)
        {
            return num1 * (num2 / 100);
        }

        public static double RaizQuadrada(double num1)
        {
            return Math.Sqrt(num1);
        }

        public static double Potenciacao(double baseNumero, double expoente)
        {
            return Math.Pow(baseNumero, expoente);
        }

        public static double Divisao(double numero1, double numero2)
        {
            if (numero2 != 0)
            {
                return numero1 / numero2;
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida.");
                return 0;
            }
        }
    }
}
