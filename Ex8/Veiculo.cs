namespace Ex8
{
    public enum TipoVeiculo
    {
        Carro,
        Van,
        Moto,
    }

    public class Veiculo
    {
        public string modelo { get; set; }
        public byte qtdLugares { get; set; }
        public int ano { get; set; }
        public double kmsRodados { get; set; }
        public byte qtdPortasSimples { get; set; }
        private byte qtdPortasDeCorrer { get; set; }
        public TipoVeiculo tipoVeiculo { get; set; }

        public Veiculo() { }

        public Veiculo(TipoVeiculo tipoVeiculo, string modelo, byte qtdLugares, int ano, double kmsRodados, byte qtdPortasSimples, byte qtPortasDeCorrer)
        {
            this.tipoVeiculo = tipoVeiculo;
            this.modelo = modelo;
            this.qtdLugares = qtdLugares;
            this.ano = ano;
            this.kmsRodados = kmsRodados;
            this.qtdPortasSimples = qtdPortasSimples;
            this.qtdPortasDeCorrer = qtPortasDeCorrer;
        }
    }
}