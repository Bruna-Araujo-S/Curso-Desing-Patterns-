﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesingPatterns;

namespace CursoDesingPatterns
{
    public class CalculadorDeDesconto
    {
        static void Main(string[] args)
        {
            Desconto d1 = new DescontoPorCincoItens();
            Desconto d2 = new DescontoPorMaisDeQuinhentosReais();
            Desconto d3 = new DescontoPorVendaCasada();
            Desconto d4 = new SemDesconto();


            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            Orcamento orcamento = new Orcamento(500.0);

            double desconto = d1.Desconta(orcamento);
            Console.WriteLine(desconto);
        }
    }
}
