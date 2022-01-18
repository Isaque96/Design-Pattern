namespace Design_Pattern
{
    class Program
    {
        static void Main()
        {
            //Imposto iss = new ISS();
            //Imposto icms = new ICMS();
            //Orcamento orcamento = new Orcamento(500.0);
            //CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            //// Calculando o ISS
            //calculador.RealizaCalculo(orcamento, iss);

            //// Calculando o ICMS        
            //calculador.RealizaCalculo(orcamento, icms);


            //CalculadorDeDescontos calculador = new();

            //Orcamento orcamento = new(500);
            //orcamento.AdicionarItem(new("Caneta", 250));
            //orcamento.AdicionarItem(new("Lápis", 250));
            //orcamento.AdicionarItem(new("Geladeira", 250));
            //orcamento.AdicionarItem(new("Fogão", 250));
            //orcamento.AdicionarItem(new("Mesa", 250));
            //orcamento.AdicionarItem(new("Cama", 250));

            //double desconto = calculador.Calcula(orcamento);
            //Console.WriteLine(desconto.ToString());

            //Imposto iss = new ISS(new ICMS(new IKCV()));
            //Orcamento orcamento = new(500);

            //double valor = iss.Calcula(orcamento);

            //Console.WriteLine(valor);

            //try
            //{
            //    Orcamento reforma = new(500);

            //    Console.WriteLine(reforma.Valor);

            //    reforma.AplicaDescontoExtra();
            //    Console.WriteLine(reforma.Valor);

            //    reforma.Aprova();
            //    reforma.AplicaDescontoExtra();
            //    Console.WriteLine(reforma.Valor);

            //    reforma.Finaliza();

            //    reforma.AplicaDescontoExtra();

            //    reforma.Finaliza();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}

            NotaFiscalBuilder criar = new();
            criar
                .ParaEmpresa("Caelum Ensino e Inovação")
                .ComCnpj("23.456.789/0001-12")
                .ComItem(new ItemDaNota("Item 1", 100.0))
                .ComItem(new ItemDaNota("Item 2", 200.0))
                .NaDataAtual()
                .ComObservacoes("Aquela observação que você conhece!");

            criar.AdicionaAcao(new EnviadorDeEmail());
            criar.AdicionaAcao(new NotaFiscalDAO());
            criar.AdicionaAcao(new EnviadorDeSMS());

            NotaFiscal nf = criar.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
        }
    }
}