﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class Multiplicador : AcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator) { this.Fator = fator; }

        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(notaFiscal.Valor * this.Fator);
        }
    }
}
