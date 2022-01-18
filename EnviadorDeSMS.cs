namespace Design_Pattern
{
    public class EnviadorDeSMS : AcaoPosGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine($"Enviado um SMS para o celular de {nf.Cnpj}");
        }
    }
}
