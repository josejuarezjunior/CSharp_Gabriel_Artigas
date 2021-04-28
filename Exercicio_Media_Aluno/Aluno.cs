using System;

namespace Exercicio_Media_Aluno
{
    class Aluno
    {

        //Atributos
        public string Nome { get; set; }

        //Array que irá guardar as notas do aluno
        //O uso do underlinde(_) é uma conveção em C#, para atributos privados!
        private double[] _notas;

        //Construtor
        public Aluno(string nome, int provas)
        {
            Nome = nome;
            _notas = new double[provas];
        }


        //Métodos

        /* 
         * O método Media está utilizando um método privado(CalcularMedia).
         * Nesse caso vemos conceito de encapsulamento!
         * O método Media não precisa saber como a média é calculada,
         * apenas precisa do valor da média!
        */
        public double Media
        {
            get
            {
                return CalculoMedia();
            }
        }

        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write($"Nota #{i+1}: ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }

        //O cálculo da média fica à cargo desse método privado!
        private double CalculoMedia()
        {
            double total = 0;
            for (int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];
            }
            return total / _notas.Length;
        }

    }
}
