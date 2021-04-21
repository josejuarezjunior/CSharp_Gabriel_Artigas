using System;

namespace Heranca
{
    class Humano
    {
        /*
         *O modificador "virtual" diz que o método pode 
         *ser sobrescrito na classe descendente (que herda da classe 
         *principal), ou seja, permite usar o código da classe principal 
         *ou então ignorar re-escrevendo o código na classe herdada
         *e para isso usando o modificador "override".
         *
         *Sua diferença em relação à um método abstrato, é que no 
         *método abstrato não há uma implementação pré-definida.
        */
        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }
        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.Cabelos");
        }
    }
    class Pessoa : Humano
    {
        //O modificador "override" permite sobrescrever o método da classe base.
        //O modificador "sealed" impede que a sub-classe sobrescreva o método.
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }
        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.Cabelos");
        }
    }
    class Homem : Pessoa
    {
        /*
         * Esse método não pode sobrescrever o método da classe base
         * pois é um método selado, através do modificador "sealed" 
         * na clase base:
        
        public override void Olhos()
        {
            Console.WriteLine("Homem.Olhos");
        }
        */
        public override void Cabelos()
        {
            Console.WriteLine("Homem.Cabelos");
        }

    }
        
}
