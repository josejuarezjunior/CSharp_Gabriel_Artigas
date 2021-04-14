using System;


namespace ClassesMetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classe estática
            //A classe Matematica sendo estática, não é instânciada. É acessada diretamento pelo seu nome.

            Matematica.taxa = 10;

            int valor1 = Matematica.Adcionar(200);
            int valor2 = Matematica.Diminuir(200);

            Console.WriteLine($"Valor 1: {valor1}.");
            Console.WriteLine($"Valor 2: {valor2}.");
            #endregion

            #region Membros estáticos
            Console.WriteLine();
            Pessoa.maioridade = 21;

            Pessoa p1 = new Pessoa();
            p1.nome = "Jose Juarez";
            p1.idade = Pessoa.CalcularIdade(1989);

            Console.WriteLine($"Nome de p1: {p1.nome}");
            Console.WriteLine($"Idade de p1: {p1.idade}");
            Console.WriteLine($"A maioridade é: {Pessoa.maioridade}.");

            Console.ReadKey();

            #endregion
        }
    }
}
