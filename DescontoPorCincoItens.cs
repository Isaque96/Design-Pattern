namespace Design_Pattern
{
    public class DescontoPorCincoItens : Desconto
    {
        public Desconto Proximo { get; set; }
        public double Desconto(Orcamento orcamento)
        {
            if(orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }

            return Proximo.Desconto(orcamento);
        }
    }
}
