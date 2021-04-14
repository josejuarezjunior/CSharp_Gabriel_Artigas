using System;

namespace ClassesMetodosEstaticos
{
    class Pessoa
    {
        //Membro estático:
        public static int maioridade = 18;

        public string nome;
        public int idade;

        public void Apresentar()
        {
            Console.WriteLine($"Olá eu sou {nome}");
        }
        //Método estático
        public static int CalcularIdade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;
        }
    }
}
