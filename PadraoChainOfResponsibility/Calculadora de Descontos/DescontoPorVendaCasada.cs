using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoChainOfResponsibility.Calculadora_de_Descontos
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }


        public double Calcula(Orcamento orcamento)
        {
            if (aconteceuVendaCasadaEm(orcamento)) return orcamento.Valor * 0.05;
            else return Calcula(orcamento);
        }

        private bool aconteceuVendaCasadaEm(Orcamento orcamento)
        {
            return existe("CANETA", orcamento) && existe("LAPIS", orcamento);
        }

        private bool existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem)) return true;
            }
            return false;
        }
    }
}
