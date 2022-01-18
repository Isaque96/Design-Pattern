namespace Design_Pattern
{
    internal class SemDesconto : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconto(Orcamento orcamento)
        {
            return 0;
        }
    }
}
