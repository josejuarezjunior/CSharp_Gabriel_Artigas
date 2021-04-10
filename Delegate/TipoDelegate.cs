using System;

namespace Delegate
{
    class Delegate
    {
        public void Soma(double num1, double num2)
        {
            Console.WriteLine($"A soma é {num1+num2}");
        }
        public void Subtração(double num1, double num2)
        {
            Console.WriteLine($"A subtração é {num1 - num2}");
        }
        public void Multiplicacao(double num1, double num2)
        {
            Console.WriteLine($"A multiplicação é {num1 * num2}");
        }
        public void Divisao(double num1, double num2)
        {
            Console.WriteLine($"A divisão é {num1 / num2}");
        }
    }
}
