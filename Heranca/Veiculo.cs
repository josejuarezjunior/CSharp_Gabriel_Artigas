using System;

namespace Heranca
{
    /*
     * Ao declarar a classe como "abstact", ela não pode ser instanciada.
     * Somente suas sub-classes.
    */
    abstract class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }

        /*
         * Ao declarar o método como "abstract", a sub-classe será obrigada à
         * implementar esse método. E cada sua sub-classe pode ter sua própria
         * implementação.
        */
        abstract public void Acelerar();

        abstract public void Parar();
    }
}
