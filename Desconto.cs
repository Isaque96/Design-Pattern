namespace Design_Pattern
{
    public interface Desconto
    {
        double Desconto(Orcamento orcamento);
        Desconto Proximo { get; set; }
    }
}
