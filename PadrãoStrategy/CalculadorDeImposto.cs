using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class CalculadorDeImposto
    {
        public void Calcula(Orcamento orcamento, Imposto estrategiaDeImposto)
        {
            double resultado = estrategiaDeImposto.Calcula(orcamento);
            Console.WriteLine(resultado);
        }

      
    }
}
