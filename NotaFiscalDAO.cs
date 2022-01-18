namespace Design_Pattern
{
    public class NotaFiscalDAO : AcaoPosGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine($"Salvo no banco do {nf.RazaoSocial}");
        }
    }
}
