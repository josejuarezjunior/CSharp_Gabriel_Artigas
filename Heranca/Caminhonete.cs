using System;

namespace Heranca
{
    //O modificador "sealed" em uma classe impede que outras classes herdem dela!
    sealed class Caminhonete : Carro
    {
        public bool CabineExtendida { get; set; }
    }
}
