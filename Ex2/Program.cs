namespace exercicio2
{
    public class Program
    {
        public static int ContaAparicoes(string frase, string palavra)
        {
            int count = 0;

            int index = frase.IndexOf(palavra);

            while (index != -1)
            {
                count++;
                index = frase.IndexOf(palavra, index + palavra.Length);
            }

            Console.WriteLine($"A palavra '{palavra}' aparece {count} vezes em '{frase}'");

            return 0;
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!
            ContaAparicoes("Banana", "a"); // 3
            ContaAparicoes("Banana", "na"); // 2
            ContaAparicoes("Banana", "ka"); // 0
            ContaAparicoes("BBBBBBBBB", "BB"); // 4
        }
    }
}

