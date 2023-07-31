using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class Positivo : IEstadoDaConta
    {
        public void Saca(Conta conta, double valor)
        {
            double novoSaldo = conta.Saldo - valor;

            if (novoSaldo < 0)
                conta.Estado = new Negativo();

            conta.Saldo = novoSaldo;
        }

        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }
    }
}
