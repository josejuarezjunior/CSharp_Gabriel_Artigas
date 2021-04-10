using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    class Program
    {
        delegate void Operacao(double num1, double num2);
        static void Main(string[] args)
        {
            Matematica matematica = new Matematica();

            Operacao conta = null;

            conta += matematica.Soma;
            conta += matematica.Subtração;
            conta += matematica.Multiplicacao;
            conta += matematica.Divisao;

            conta(10, 2);

            Console.WriteLine("-------------------------------");

            conta -= matematica.Soma;
            conta -= matematica.Multiplicacao;

            conta(10, 2);


        }
    }
}
