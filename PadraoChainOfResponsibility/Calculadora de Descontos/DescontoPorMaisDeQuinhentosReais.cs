using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoChainOfResponsibility.Calculadora_de_Descontos
{
    public class DescontoPorMaisDeQuinhentosReais : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }
    }
}
