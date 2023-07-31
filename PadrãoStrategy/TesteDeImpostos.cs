﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class TesteDeImpostos : Imposto
    {
        public static void Main(string[] args)
        {
            Imposto impostos = new ImpostoMuitoAlto(new ICMS());

            Orcamento orcamento = new Orcamento(500.0);

            Console.WriteLine(impostos.Calcula(orcamento));
        }

        public override double Calcula(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }
    }
}
