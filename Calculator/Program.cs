using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            BemVindo();
            Console.Clear();
            Console.WriteLine("Selecione as opções abaixo: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Resto da Divisão");
            Console.WriteLine("6 - Exponenciação");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("----------");
            Console.WriteLine("");
            Console.WriteLine("");

            short result = short.Parse(Console.ReadLine());

            switch (result)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Resto(); break;
                case 6: Exponenciacao(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
            Sair();
        }
        static void BemVindo()
        { 
            Console.Clear();
            Console.WriteLine("Seja bem vindo a calculadora em C#!");
            Console.WriteLine("Pressione qualquer tecla para CONTINUAR !");
            Console.ReadKey();
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Insira um numero a seguir: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro numero a seguir: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double sum = number1 + number2;
            Console.WriteLine($"O resultado dos numeros informados é {sum}");
            Console.WriteLine("Pressione qualquer tecla para CONTINUAR !");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("A segunda conta a seguir será a SUBTRACAO");
            Console.WriteLine("");

            Console.WriteLine("Insira um numero a seguir: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro numero a seguir: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double subtracao = number1 - number2;
            Console.WriteLine($"O resultado dos numeros informados é {subtracao}");
            Console.WriteLine("Pressione qualquer tecla para CONTINUAR !");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("A terceira conta a seguir será a MULTIPLICACAO");
            Console.WriteLine("");

            Console.WriteLine("Insira um numero a seguir: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro numero a seguir: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double multiplicacao = number1 * number2;
            Console.WriteLine($"O resultado dos numeros informados é {multiplicacao}");
            Console.WriteLine("Pressione qualquer tecla para CONTINUAR !");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("A quarta conta a seguir é a DIVISÃO");
            Console.WriteLine("");

            Console.WriteLine("Insira um numero a seguir: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro numero a seguir");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double divisao = number1 / number2;
            Console.WriteLine($"O resultado dos numeros informados é {divisao}");
            Console.WriteLine("Pressione qualquer tecla para CONTINUAR !");
            Console.ReadKey();
            Menu();
        }
        static void Resto()
        {
            Console.Clear();

            Console.WriteLine("A quinta conta a seguir é o RESTO DA DIVISÃO");
            Console.WriteLine("");

            Console.WriteLine("Insira um numero a seguir: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro numero a seguir");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double resto = number1 % number2;
            Console.WriteLine($"O resultado dos numeros informados é {resto}");
            Console.WriteLine("Pressione qualquer tecla para CONTINUAR !");
            Console.ReadKey();
            Menu();
        }
        static void Exponenciacao()
        {
            Console.Clear();

            Console.WriteLine("A ultima conta que sera a seguir é a EXPONENCIACAO");
            Console.WriteLine("");

            Console.WriteLine("Insira um numero a seguir: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro numero a seguir");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double exponenciacao = Math.Pow(number1, number2);
            Console.WriteLine($"O resultado dos numeros informados é {exponenciacao}");
            Console.WriteLine("Pressione qualquer tecla para FINALIZAR !");
            Console.ReadKey();
            Menu();
        }
        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar nossa calculadora, volte sempre!");
            Console.WriteLine("Pressione a tecla ZERO para sair!");
        }
    }
}
