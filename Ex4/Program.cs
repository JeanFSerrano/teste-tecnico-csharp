﻿namespace exercicio4
{

    public class Usuario
    {
        public string Email { get; }
        public string Nome { get; }
        public Guid Senha { get; }

        public Usuario(string email, string nome)
        {
            this.Email = email;
            this.Nome = nome;
            this.Senha = Guid.NewGuid();
        }
    }
    public class Program
    {
        public static List<Usuario> OrdenaUsuarios(List<Usuario> array)
        {

            array.Sort((x, y) => x.Nome.CompareTo(y.Nome));

            for (int i = 0; i < array.Count - 1; i++)
            {
                if (array[i].Nome == array[i + 1].Nome)
                {
                    throw new Exception("Existem usuários com nomes repetidos!");
                }
            }

            foreach (Usuario usuario in array)
            {
                Console.WriteLine(usuario.Email + " - " + usuario.Nome);
            }

            return null;
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!
            // Obs: Como a função retorna uma lista de objetos, a resposta abaixo apenas representa o(s) objeto//(s) retornados!

            OrdenaUsuarios(new List<Usuario> {
                new Usuario("jc@cmu.com.br", "João Carlos"),
                new Usuario("ana@cmu.com.br", "Ana Maria"),
                new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                new Usuario("joaozin@cmu.com.br", "João Marcelo")}); // new List<Usuario> {Usuario{"Ana Maria"}, Usuario{"João Carlos"}, Usuario{"João Marcelo"}, Usuario{"Pedro Almeida"} }

            OrdenaUsuarios(new List<Usuario> { }); // new List<Usuario> {}

            OrdenaUsuarios(new List<Usuario> {
                new Usuario("jc@cmu.com.br", "João Carlos"),
                new Usuario("ana@cmu.com.br", "Ana Maria"),
                new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                new Usuario("joaozin@cmu.com.br", "João Carlos")}); // ERRO

            OrdenaUsuarios(null); // ERRO
        }
    }
}
