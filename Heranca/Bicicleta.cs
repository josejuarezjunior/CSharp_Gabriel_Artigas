using System;

namespace Heranca
{
    //O modificador "sealed" em uma classe impede que outras classes herdem dela!
    sealed class Bicicleta : Veiculo
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
            Console.WriteLine("A bicicleta acelerou!"); ;
        }

        public override void Parar()
        {
            Console.WriteLine("A bicicleta parou!");
        }
        public void Pedalar()
        {
            Console.WriteLine("Pedalando!");
        }
    }
}
