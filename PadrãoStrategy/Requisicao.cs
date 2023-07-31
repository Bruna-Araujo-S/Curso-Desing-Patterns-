using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class Requisicao
    {
        public Formato Formato { get; set; }

        public Requisicao(Formato formato)
        {
            Formato = formato;
        }
    }
}
