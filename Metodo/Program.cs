using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos metodo = new Metodos();
            metodo.Cumprimentar();
            Console.WriteLine();

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine();
            metodo.Cumprimentar(nome);
        }
    }
}
