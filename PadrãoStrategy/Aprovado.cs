using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesingPatterns;

namespace CursoDesingPatterns
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado!");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já esta aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento em estado de aprovação não pode ser reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
