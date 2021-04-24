using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    //Classe abstrata, não pode ser instanciada
    abstract public class Forma
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Raio { get; set; }

        //"virtual" indica que é um método que pode ser sobrescrito
        public virtual void Desenhar() 
        {
            Console.WriteLine("Preparando-se para desenhar.");
        }

        //"virtual" indica que é um método que pode ser sobrescrito
        //Abaixo a implementação padrão, caso o método não seja sobrescrito.
        public virtual void Area()
        {
            double area = Largura * Altura;
            Console.WriteLine($"Area: {area}.");
        }

    }
    public class Circulo : Forma
    {
        //Polimorfismo aqui. O método está se comportando de maneira diferente da classe base!
        public override void Desenhar()
        {
            //base.Desenhar, está retornando a implementação do método na classe base também.
            base.Desenhar();
            Console.WriteLine("Desenhando um círculo.");
        }

        //Polimorfismo aqui. O método está se comportando de maneira diferente da classe base!
        public override void Area()
        {
            double area = 3.14 * Math.Pow(Raio, 2);
            Console.WriteLine($"Area Círculo: {area}.");
        }

    }
    public class Retangulo : Forma
    {
        //Polimorfismo aqui. O método está se comportando de maneira diferente da classe base!
        public override void Desenhar()
        {
            //base.Desenhar, está retornando a implementação do método na classe base.
            base.Desenhar();
        }

        public override void Area()
        {
            base.Area();
        }

    }
    public class Triangulo : Forma
    {
        //Polimorfismo aqui. O método está se comportando de maneira diferente da classe base!
        public override void Desenhar()
        {
            //base.Desenhar, está retornando a implementação do método na classe base também.
            base.Desenhar();
            Console.WriteLine("Desenhando um Triângulo.");
        }

        //Polimorfismo aqui. O método está se comportando de maneira diferente da classe base!
        public override void Area()
        {
            double area = (Largura * Altura) / 2;
            Console.WriteLine($"Area triângulo: {area}.");
        }

    }
}
