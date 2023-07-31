using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public string Observacoes { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public double Valor { get;  set; }
        public double ValorTotal { get; }
        public DateTime Data { get; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataEmissao, double valorBruto, double impostos, string observacoes, IList<ItemDaNota> itens)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            ValorBruto = valorBruto;
            Impostos = impostos;
            DataEmissao = dataEmissao;
            Observacoes = observacoes;
            Itens = itens;
        }

        public NotaFiscal(string razaoSocial, string cnpj, double valorTotal, double impostos, DateTime data, string observacoes)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            ValorTotal = valorTotal;
            Impostos = impostos;
            Data = data;
            Observacoes = observacoes;
        }
    }
}
