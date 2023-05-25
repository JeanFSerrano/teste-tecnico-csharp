using System.Text.Json;

namespace Ex8
{
    public class Frota
    {
        private string Nome { get; set; }
        private string Cnpj { get; set; }
        public List<Veiculo> Veiculo { get; set; }

        public Frota(string nome, string cnpj)
        {
            Nome = nome;
            Cnpj = cnpj;
            Veiculo = new List<Veiculo>();
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            Veiculo.Add(veiculo);
        }

        public static int qtd4Portas(List<Veiculo> veiculo)
        {
            int count = veiculo.Count(v => v.qtdPortasSimples == 4);
            Console.WriteLine($"Quantidade de veículos com 4 portas da frota: {count + 1}.");
            return count;
        }

        public static int qtdTotaldeLugares(List<Veiculo> veiculo)
        {
            int total = veiculo
            .Where(v => v.qtdLugares > 0)
            .Sum(v => v.qtdLugares);

            Console.WriteLine($"Quantidade total de de lugares da frota: {total}.");

            return total;
        }

        public static List<double> mediaKmRodados(List<Veiculo> veiculo)
        {
            List<double> kms = veiculo.Where(v => v.kmsRodados >= 0).Select(v => v.kmsRodados).ToList();

            Console.WriteLine($"A média de kms rodados da frota é: {(double)kms.Average()}.");

            return kms;
        }

        public static void veiculosMaisNovos(List<Veiculo> veiculo)
        {
            var maisNovos = veiculo
            .OrderByDescending(v => v.ano)
            .Take(2);

            Console.WriteLine($"Veiculos mais novos: {JsonSerializer.Serialize(maisNovos)}");
        }

        public static void veiculosMaisRodados(List<Veiculo> veiculo)
        {
            var maisRodados = veiculo
            .OrderByDescending(v => v.kmsRodados)
            .Take(2);

            Console.WriteLine($"Veiculos mais rodados: {JsonSerializer.Serialize(maisRodados)}");
        }

        public static void veiculosMaisAntigos(List<Veiculo> veiculosLTDA, List<Veiculo> veiculosSA)
        {
            var maisAntigos = veiculosLTDA.Concat(veiculosSA)
            .OrderBy(v => v.ano)
            .Take(2);

            Console.WriteLine($"Veiculos mais antigos: {JsonSerializer.Serialize(maisAntigos)}");
        }

        public static void frotaMaiorQtdDeVans(List<Veiculo> veiculosLTDA, List<Veiculo> veiculosSA)
        {
            int cont1 = 0;
            int cont2 = 0;

            foreach (Veiculo v in veiculosLTDA)
            {
                if (v.tipoVeiculo == TipoVeiculo.Van)
                {
                    cont1++;
                }
            }

            foreach (Veiculo v in veiculosSA)
            {
                if (v.tipoVeiculo == TipoVeiculo.Van)
                {
                    cont2++;
                }
            }

            if (cont1 > cont2)
            {
                Console.WriteLine($"A frota LTDA é a frota com maior número de vans: {cont1}");
            }
            else
            {
                Console.WriteLine($"A frota SA é a frota com maior número de vans, a quantidade é: {cont2}");
            }
        }
    }
}