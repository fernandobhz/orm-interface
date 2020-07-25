using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class VisitaTecnica : iSolicitacao
    {
        public int nr_solicitacao { get; set; }
        public string dsSolicitacao { get; set; }
        public string nmSolicitante { get; set; }


        public void imprimir()
        {
        }
    }
}
