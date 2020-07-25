using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    interface iSolicitacao
    {
        int nr_solicitacao { get; set; }
        string dsSolicitacao { get; set; }
        string nmSolicitante { get; set; }


        void imprimir();
    }
}
