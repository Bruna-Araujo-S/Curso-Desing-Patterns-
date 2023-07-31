using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Observacoes { get; set; }
        public DateTime Data { get; set; }

        private double ValorTotal;
        private double Impostos;
        private IList<ItemDaNota> todositens = new List<ItemDaNota>();
        private IList<AcaoAposGerarNota> todasAcoesASeremExecutadas;

        public NotaFiscalBuilder(IList<AcaoAposGerarNota> lista)
        {
            this.todasAcoesASeremExecutadas = lista;
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal notaFiscal = new NotaFiscal(RazaoSocial, Cnpj, ValorTotal, Impostos, Data, Observacoes);

            foreach (AcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(notaFiscal);
            }
            return notaFiscal;
        }


        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todositens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;

            return this;
        }
        public NotaFiscalBuilder ComObservacoes (string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            Data = DateTime.Now;
            return this;
        }
    }
}
