using CursoDesingPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class Conta
    {
        public double Saldo { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public IEstadoDaConta Estado { get; set; }


        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }
        public Conta()
        {
            Estado = new Positivo();
        }

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

    }
}
