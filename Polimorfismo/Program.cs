using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * As classes podem ser instanciadas à partir da classe base (Forma), pois são sub-classes da mesma.
            */
            //Forma a = new Forma(); Classe abstrata, não pode ser instanciada
            Forma b = new Triangulo();
            Forma c = new Circulo();
            Forma d = new Retangulo();

            //Console.WriteLine("Forma");  Classe abstrata, não pode ser instanciada
            //a.Desenhar();  Classe abstrata, não pode ser instanciada
            Console.WriteLine("Triângulo");
            b.Desenhar();
            Console.WriteLine("Círculo");
            c.Desenhar();
            Console.WriteLine("Retângulo");
            d.Desenhar();

            Console.ReadKey();
        }
    }
}
