using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoChainOfResponsibility.Calculadora_de_Descontos
{
    public class SemDesconto : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
