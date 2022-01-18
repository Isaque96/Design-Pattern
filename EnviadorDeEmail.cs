using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public class EnviadorDeEmail : AcaoPosGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine($"Enviado para o E-mail do {nf.Cnpj}");
        }
    }
}
