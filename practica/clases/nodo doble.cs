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
        private string nombre; //analisis de casos Sem 4
        private byte edad; //analisis de casos Sem 4
        private nodo_doble Siguiente;
        private nodo_doble atras;

        public int Numero { get => numero; set => numero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public byte Edad { get => edad; set => edad = value; }
        internal nodo_doble Siguiente1 { get => Siguiente; set => Siguiente = value; }
        internal nodo_doble Atras { get => atras; set => atras = value; }
    }
}
