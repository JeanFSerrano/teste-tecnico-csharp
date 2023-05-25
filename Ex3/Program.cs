namespace exercicio3
{
    public class Program
    {
        public static int ContaDias(string data1, string data2)
        {
            DateTime data1Formatada = DateTime.Parse(data1);
            DateTime data2Formatada = DateTime.Parse(data2);

            if (data1.Contains("/") || data2.Contains("/"))
            {
                Console.WriteLine("Erro: Uma das datas inseridas está em formato incorreto, use '-' ao invés de '/'.");
                return 0;
            }

            TimeSpan diferenca = (data1Formatada - data2Formatada).Duration();

            int dias = (int) diferenca.TotalDays;
            string diasFormatado = dias.ToString("N0");

            Console.WriteLine($"A diferença em dias entre {data1} e {data2} é de {diasFormatado} dias.");
            return 0;
        }

        public static void Main(string[] args)
        {
            ContaDias("2023-02-01", "2023-02-02"); // 1
            ContaDias("2023-02-01", "2023-02-15"); // 14
            ContaDias("2023-02-01", "2022-02-01"); // 365
            ContaDias("2022-02-01", "2023-02-01"); // 365
            ContaDias("2023-02-01", "2023-02-01"); // 0
            ContaDias("2023-02-01", "2023/02/01"); // ERRO
        }
    }
}

