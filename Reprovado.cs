namespace Design_Pattern
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos Reprovados não recebem DESCONTO extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está Reprovado, não pode ser Aprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em Estado de Reprovado!");
        }
    }
}
