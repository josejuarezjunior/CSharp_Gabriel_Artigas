using System;

namespace Metodos
{
    class Metodos
    {
        #region Métodos com parâmetros
        public void Cumprimentar()
        {
            Console.WriteLine("Seja bem vindo!");
        }
        public void Cumprimentar(string nome)
        {
            Console.WriteLine($"Seja bem vindo {nome}!");
        }
        #endregion
    }
}
