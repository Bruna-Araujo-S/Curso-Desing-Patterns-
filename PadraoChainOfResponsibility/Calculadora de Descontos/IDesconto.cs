using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoChainOfResponsibility.Calculadora_de_Descontos
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
         Desconto Proximo { get; set; }

    }
}
