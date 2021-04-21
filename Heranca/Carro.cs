using System;

namespace Heranca
{
    class Carro : Veiculo
    {
        /*
        * Ao implementar um método abstrato é necessário
        * implementar o método "override" que
        * fornece uma nova implementação do método 
        * herdado de uma classe base. O método que é substituído 
        * por uma declaração override é conhecido como o método 
        * base substituído. Um override método deve ter a mesma 
        * assinatura que o método base substituído.
       */
        public override void Acelerar()
        {
            Console.WriteLine("O carro acelerou!"); ;
        }

        public override void Parar()
        {
            Console.WriteLine("O carro parou!");
        }
        public void LigarMotor()
        {
            Console.WriteLine("Ligou o motor!");
        }
    }
}
