using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorIT
{
    class Lista
{
        Nodo _cabLista;
        int _noNodos;
        public Lista()
        {
            _cabLista = null;
            _noNodos = 0;
        }
        public Nodo Cab
        {
            get { return _cabLista; }
            set { _cabLista = value; }
        }
        public void InsInicio(TipoElem oElem)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Info = oElem;
            nuevoNodo.Sig = _cabLista;
            _cabLista = nuevoNodo;
            _noNodos++;
        }
        public int NoNodos
        {
            get { return _noNodos; }
            set { _noNodos = value; }
        }
    }
}
