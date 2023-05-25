namespace Ex8;

public class Program
{
    public static void Main(string[] args)
    {
        Frota frotaLTDA = new Frota("Cooperativa de veículos CMCar LTDA", "03.019.756/0001-70");

        Veiculo van1_FrotaLTDA = new Veiculo(TipoVeiculo.Van, "Ford Transit", 12, 2008, 97000, 2, 1);
        Veiculo van2_FrotaLTDA = new Veiculo(TipoVeiculo.Van, "Citroen Jumper", 12, 2008, 95000, 2, 1);
        Veiculo van3_FrotaLTDA = new Veiculo(TipoVeiculo.Van, "Citroen Jumper", 12, 2012, 17000, 2, 1);
        Veiculo van4_FrotaLTDA = new Veiculo(TipoVeiculo.Van, "Citroen Jumper", 12, 2023, 0, 2, 1);
        Veiculo van5_FrotaLTDA = new Veiculo(TipoVeiculo.Van, "Fiat Ducato", 12, 2006, 15000, 4, 1);

        Veiculo carro1_FrotaLTDA = new Veiculo(TipoVeiculo.Carro, "Fiat Palio", 5, 2009, 15000, 2, 0);
        Veiculo carro2_FrotaLTDA = new Veiculo(TipoVeiculo.Carro, "Fiat Ducato", 5, 2009, 25000, 2, 0);
        Veiculo carro3_FrotaLTDA = new Veiculo(TipoVeiculo.Carro, "Ford Ká", 5, 2015, 76560, 4, 0);
        Veiculo carro4_FrotaLTDA = new Veiculo(TipoVeiculo.Carro, "Chevrolet Onix", 5, 2010, 15000, 4, 0);

        Veiculo moto1_FrotaLTDA = new Veiculo(TipoVeiculo.Moto, "Yamaha Flup", 2, 2023, 0, 0, 0);

        frotaLTDA.AdicionarVeiculo(van1_FrotaLTDA);
        frotaLTDA.AdicionarVeiculo(van2_FrotaLTDA);
        frotaLTDA.AdicionarVeiculo(van3_FrotaLTDA);
        frotaLTDA.AdicionarVeiculo(van4_FrotaLTDA);
        frotaLTDA.AdicionarVeiculo(van5_FrotaLTDA);
        frotaLTDA.AdicionarVeiculo(carro1_FrotaLTDA);
        frotaLTDA.AdicionarVeiculo(carro2_FrotaLTDA);
        frotaLTDA.AdicionarVeiculo(carro2_FrotaLTDA);
        frotaLTDA.AdicionarVeiculo(carro3_FrotaLTDA);
        frotaLTDA.AdicionarVeiculo(moto1_FrotaLTDA);

        Frota frotaSA = new Frota("Consórcio de veículos CMCar S.A", "26.402.504/0001-21");

        Veiculo van1_FrotaSA = new Veiculo(TipoVeiculo.Van, "Ford Transit", 12, 2018, 65000, 2, 1);
        Veiculo van2_FrotaSA = new Veiculo(TipoVeiculo.Van, "Fiat Ducato", 12, 2007, 15400, 2, 1);

        Veiculo carro1_FrotaSA = new Veiculo(TipoVeiculo.Carro, "Fiat Palio", 5, 2019, 35000, 2, 0);
        Veiculo carro2_FrotaSA = new Veiculo(TipoVeiculo.Van, "Chevrolet Onix", 5, 2012, 65000, 4, 0);

        Veiculo moto1_FrotaSA = new Veiculo(TipoVeiculo.Moto, "Yamaha Flup", 2, 2023, 0, 0, 0);
        Veiculo moto2_FrotaSA = new Veiculo(TipoVeiculo.Moto, "Yamaha Flup", 2, 2023, 10000, 0, 0);
        Veiculo moto3_FrotaSA = new Veiculo(TipoVeiculo.Moto, "Yamaha Flup", 2, 2022, 5500, 0, 0);
        Veiculo moto4_FrotaSA = new Veiculo(TipoVeiculo.Moto, "Honda CB300", 2, 2023, 0, 0, 0);

        frotaSA.AdicionarVeiculo(van1_FrotaSA);
        frotaSA.AdicionarVeiculo(van2_FrotaSA);
        frotaSA.AdicionarVeiculo(carro1_FrotaSA);
        frotaSA.AdicionarVeiculo(carro2_FrotaSA);
        frotaSA.AdicionarVeiculo(moto1_FrotaSA);
        frotaSA.AdicionarVeiculo(moto2_FrotaSA);
        frotaSA.AdicionarVeiculo(moto3_FrotaSA);
        frotaSA.AdicionarVeiculo(moto4_FrotaSA);

        Console.WriteLine($"Quantidade de veículos da frota LTDA: {frotaLTDA.Veiculo.Count}.");
        Frota.qtd4Portas(frotaLTDA.Veiculo);
        Frota.qtdTotaldeLugares(frotaLTDA.Veiculo);
        Frota.mediaKmRodados(frotaSA.Veiculo);
        Frota.veiculosMaisNovos(frotaLTDA.Veiculo);
        Frota.veiculosMaisRodados(frotaSA.Veiculo);
        Frota.veiculosMaisAntigos(frotaLTDA.Veiculo, frotaSA.Veiculo);
        Frota.frotaMaiorQtdDeVans(frotaLTDA.Veiculo, frotaSA.Veiculo);


        // a) A quantidade de veículos da frota 1. Resposta: 10

        // b) A quantidade de carros com 4 portas na empresa. Resposta: 3

        // c) O total de lugares (capacidade) disponíveis da frota 1. Resposta: 82

        // d) A média de quilômetros rodados de todos os veículos da frota 2. Resposta: 24.487,5

        // e) O(s) veículo(s) mais novo(s) da frota 1 (retornar em forma de lista, pois pode haver mais de um). Resposta: Veiculo 4 e Veiculo 10

        // f) O(s) veículo(s) mais rodado(s) da frota 2 (retornar em forma de lista, pois pode haver mais de um). Resposta: Veiculo 11 e Veiculo 14

        // g) O(s) veículo(s) mais antigo(s) da empresa (retornar em forma de lista, pois pode haver mais de um). Resposta: Veiculo 5

        // h) A frota com a maior quantidade de vans (retornar em forma de lista, pois pode haver mais de um) Resposta: Frota 1

    }
}


