namespace MetodoConstrutor
{
    class Pessoa
    {
        public string nome;
        public string sobreNome;
        public int anoNascimento;
        public int idade;

        public Pessoa()
        {
            //Constutor padrão dessa classe, caso não seja preenchido
            nome = "Descohecido";
            sobreNome = "Nenhum";
            anoNascimento = 0;
            idade = 0;
        }

        //Sobrecarga(overloading) de método construtor:

        public Pessoa(string nome, string sobreNome)
        {
            //Constutor padrão dessa classe, caso não seja preenchido
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.anoNascimento = 2002;
            idade = Idade();
        }

        //Sobrecarga(overloading) de método construtor:
        public Pessoa(string nome, string sobreNome, int anoNascimento)
        {
            //Constutor padrão dessa classe, caso não seja preenchido
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.anoNascimento = anoNascimento;
            idade = Idade();
        }

        private int Idade()
        {
            return 2021 - anoNascimento;
        }

    }

}