using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    internal class nodo_doble
    {
        private int numero;
        private nodo_doble Siguiente;
        private nodo_doble atras;

        public int Numero { get => numero; set => numero = value; }
        internal nodo_doble Siguiente1 { get => Siguiente; set => Siguiente = value; }
        internal nodo_doble Atras { get => atras; set => atras = value; }
    }
}
