using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
            Subtracao();
            Multiplicacao();
            Divisao();
            Resto();
            Exponenciacao();
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Seja bem vindo a calculadora em C#!");
            Console.WriteLine("A primeira conta a seguir será a SOMA");
            Console.WriteLine("");

            Console.WriteLine("Insira um numero a seguir: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro numero a seguir: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double sum = number1 + number2;
            Console.WriteLine($"O resultado dos numeros informados é {sum}" );
            Console.WriteLine("Pressione qualquer tecla para CONTINUAR !");
            Console.ReadKey(); 
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
        }
    }
}
