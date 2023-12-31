﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos Finalizados não recebem desconto extra");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já esta finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já esta finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já esta finalizado");
        }
    }
}
