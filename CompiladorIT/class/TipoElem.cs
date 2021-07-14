using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorIT
{
    class TipoElem
{
        private string _clase;
        private string _nombre;
        private int _posicion;
        private string _valor;
        private string _tipo;
        private int _noBytes;
        private int posicion;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Clase { get; internal set; }

        public TipoElem(string nombre, int posicion)
        {
            _clase = "";
            _nombre = nombre;
            _posicion = posicion;
        }
        public int Posicion
        {
            get { return _posicion; }
            set { _posicion = value; }
        }


    }
}
