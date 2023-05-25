namespace exercicio1
{
    public class Program
    {
        public static List<string> FiltraTerminadasEmA(List<string> array)

        {
            List<string> terminadosEmA = new List<string>();

            foreach (string palavra in array)
            {
                string palavraToLowerCase = palavra.ToLower();

                if (palavraToLowerCase.EndsWith("a"))
                {
                    terminadosEmA.Add(palavra);
                }
            }

            Console.WriteLine("Palavras terminadas em 'a'");

                foreach (string palavra in terminadosEmA)
                {
                    Console.WriteLine(palavra);
                }
        
            return terminadosEmA;
        }

        public static void Main(string[] args)
        {
            FiltraTerminadasEmA(new List<string> { "Pera", "Maçã", "Banana", "Uva", "Abacate" }); // new List<string> {"Pera", "Banana", "Uva"}
            FiltraTerminadasEmA(new List<string> { "BANANA", "AZEITE", "Sacola", "MERCADO" }); // new List<string> {"BANANA", "Sacola"}
            FiltraTerminadasEmA(new List<string> { }); // new List<string> {}
        }
    }
}

