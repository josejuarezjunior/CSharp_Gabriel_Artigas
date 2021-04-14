using System;

namespace MetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constutor
            Pessoa p1 = new Pessoa();
            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.sobreNome);
            Console.WriteLine(p1.anoNascimento);
            Console.WriteLine(p1.idade);

            p1.nome = "Juarez";
            Console.WriteLine(p1.nome);
            Console.WriteLine();

            Pessoa p2 = new Pessoa("Jose Juarez", "Souza", 1989);
            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.sobreNome);
            Console.WriteLine(p2.anoNascimento);
            Console.WriteLine(p2.idade);
            #endregion
        }
    }
}
