using System;

namespace Metodo
{
    class Metodos
    {
        #region Métodos com parâmetros
        //Sobrecarga de métodos
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
