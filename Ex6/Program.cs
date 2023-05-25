using System.Linq;

namespace exercicio6
{
    public class Program
    {
        public static List<List<int>> QuebraLista(List<int> array, int y)
        {

            List<List<int>> resultado = new List<List<int>>();

            int tamanho = array.Count;
            int qtdListas = (int)Math.Ceiling((double)tamanho / y);

            for (int i = 0; i < qtdListas; i++)
            {
                List<int> sublista = new List<int>();
                for (int j = 0; j < y && i * y + j < tamanho; j++)
                {
                    sublista.Add(array[i * y + j]);
                }

                resultado.Add(sublista);
            }

            Console.Write("[ ");
            foreach (List<int> sublista in resultado)
            {
                Console.Write("[ ");
                foreach (int item in sublista)
                {
                    Console.Write(item + " ");
                }
                Console.Write("] ");
            }
            Console.WriteLine("]");

            return resultado;
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!

            QuebraLista(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3); // new List<List<int>>{new List<int>{1, 2, 3}, new List<int>{4, 5, 6}, new List<int>{7, 8, 9}}
            QuebraLista(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3); // new List<List<int>>{new List<int>{1, 2, 3}, new List<int>{4, 5, 6}, new List<int>{7, 8, 9}, new List<int>{10}}
            QuebraLista(new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 }, 4); // new List<List<int>>{new List<int>{2, 4, 6, 8}, new List<int>{10, 12, 14, 16}}
            QuebraLista(new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 }, 40); // new List<List<int>>{new List<int>{2, 4, 6, 8, 10, 12, 14, 16}}
            QuebraLista(new List<int> { }, 4); // new List<int>{}
        }
    }
}

