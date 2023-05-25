using System.Linq;

namespace exercicio4
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
        public static List<Usuario> IdentificaDuplicados(List<Usuario> array)
        {
            List<Usuario> usuariosDuplicados = new List<Usuario>();

            try
            {
                usuariosDuplicados = array.GroupBy(u => u.Email)
                .Where(g => g.Count() > 1)
                .SelectMany(g => g)
                .ToList();
            }
            catch (System.Exception)
            {
                if (array == null)
                    Console.WriteLine("Erro: Não há registros nesta lista!");
            }

            foreach (var usuario in usuariosDuplicados)
            {

                Console.WriteLine("Usuários com e-mails duplicados: {0}", usuario.Nome);
            }

            return usuariosDuplicados;
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!
            // Obs: Como a função retorna uma lista de objetos, a resposta abaixo apenas representa o(s) objeto(s) retornados!

            IdentificaDuplicados(new List<Usuario> {
                new Usuario("jc@cmu.com.br", "João Carlos"),
                new Usuario("ana@cmu.com.br", "Ana Maria"),
                new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                new Usuario("joaozin@cmu.com.br", "João Marcelo")}); // new List<Usuario> {}

            IdentificaDuplicados(new List<Usuario> {
                new Usuario("joaozin@cmu.com.br", "João Carlos"),
                new Usuario("ana@cmu.com.br", "Ana Maria"),
                new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                new Usuario("joaozin@cmu.com.br", "João Marcelo")}); // new List<Usuario> {Usuario{"João Carlos"}, Usuario{"João Marcelo"}}

            IdentificaDuplicados(new List<Usuario> { }); // new List<Usuario> {}

            IdentificaDuplicados(null); // ERRO
        }
    }
}
