using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorIT
{
    class Class1
{
        Lista[] _elems;

        public Class1(int noElems)
        {
            _elems = new Lista[noElems];
            for (int i = 0; i < _elems.Length; i++)
            {
                _elems[i] = new Lista();

            }
        }
        public void Instalar(string nombre, int posicion)
        {
            char car = nombre.ToUpper()[0];
            int indice = Convert.ToInt32(car) - 65;
            if (!EncuentraToken(indice, nombre))
            {
                TipoElem oElem = new TipoElem(nombre, posicion);
                _elems[indice].InsInicio(oElem);
            }
        }
        public bool EncuentraToken(int indice, string nombre)
        {
            Nodo refLista = _elems[indice].Cab;
            while (refLista != null)
            {

            }
            return false;
        }



        public int Mayor()
        {
            int mayor = 0;
            for (int i = 0; i < _elems.Length; i++)
                if (_elems[i].NoNodos > mayor)
                    mayor = _elems[i].NoNodos;
            return mayor;
        }


        public void Inicia()
        {
            for (int i = 0; i < _elems.Length; i++)
            {
                _elems[i].Cab = null;
                _elems[i].NoNodos = 0;

            }
        }
    }
}
