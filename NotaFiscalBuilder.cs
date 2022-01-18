namespace Design_Pattern
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime DataDeEmissao { get; set; }

        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public IList<AcaoPosGerarNota> TodasAcoesASeremExecutadas = new List<AcaoPosGerarNota>();

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new(RazaoSocial, Cnpj, DataDeEmissao, valorTotal, impostos, todosItens, Observacoes);

            foreach (var acao in TodasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        public void AdicionaAcao(AcaoPosGerarNota novaAcao)
        {
            TodasAcoesASeremExecutadas.Add(novaAcao);
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            DataDeEmissao = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }
    }
}
