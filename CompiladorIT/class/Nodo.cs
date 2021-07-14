using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorIT
{
    public class Nodo
{        
            TipoElem _oInfo;
            Nodo _sig;
           /* public TipoElem Info
            {
                get { return _oInfo; }
                set { _oInfo = value; }
            }*/
            public Nodo Sig
            {
                get { return _sig; }
                set { _sig = value; }
            }

        internal TipoElem Info { get; set; }
    }
    }

