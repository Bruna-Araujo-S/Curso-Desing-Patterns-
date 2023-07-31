using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public int CNPJ { get; set; }
        public DateTime DatadeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens  { get; set; }
        public string Observacoes { get; set; }

        public NotaFiscal(string razaoSocial, int cnpj, double valorBruto, double imposto, string observacoes, IList<ItemDaNota> itens, DateTime dataDeEmissao)
        {
            this.RazaoSocial = razaoSocial;
            this.ValorBruto = valorBruto;
            this.DatadeEmissao = dataDeEmissao;
            this.Observacoes = observacoes;
            this.ValorBruto += valorBruto;
            this.CNPJ = cnpj;
            this.Impostos = imposto;
            this.Itens = itens;
        }
    }
}
