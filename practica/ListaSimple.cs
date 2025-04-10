using practica.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica
{
    internal class ListaSimple
    {
        private Nodo primero = null;
        public void Insertar(int num)
        {
            Nodo nuevo = new Nodo();
            nuevo.Numero = num;
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Nodo actual = primero;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }
        public void Mostrar(ListBox list)
        {
            Nodo actual = primero;
            while (actual != null)
            {
                list.Items.Add(actual.Numero);
                actual = actual.Siguiente;
            }
        }
        public void Eliminar(int num)
        {
            Nodo actual = primero;
            Nodo anterior = null;
            while (actual != null)
            {
                if (actual.Numero == num)
                {
                    if (actual == primero)
                    {
                        primero = primero.Siguiente;
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    return;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }
        }
        public bool Buscar(int num)
        {
            Nodo actual = primero;
            while(actual != null)
            {
                if(actual.Numero == num)
                {
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }
        public void Ordenar()
        {
            Nodo actual = primero;
            while(actual != null)
            {
                Nodo sig = actual.Siguiente;
                if (actual.Numero > sig.Numero)
                {
                    int temp = actual.Numero;
                    actual.Numero = sig.Numero;
                    sig.Numero = temp;
                }
                sig = sig.Siguiente;
            }
            actual = actual.Siguiente;
        }
    }
}

