namespace ClassesMetodosEstaticos
{
    static class Matematica
    //Se a classe for estática, todos os membros da classe também serão.
    {
        public static int taxa;

        public static int Adcionar(int valor)
        {
            return valor + taxa;
        }

        public static int Diminuir(int valor)
        {
            return valor - taxa;
        }
    }
}