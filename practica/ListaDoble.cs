using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica
{
    internal class ListaDoble
    {
        private nodo_doble primero;
        private nodo_doble ultimo;

        public void insertar(int num)
        {
            nodo_doble nuevo = new nodo_doble();
            nuevo.Numero = num;
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente1 = nuevo;
                nuevo.Atras = ultimo;
                ultimo = nuevo;
            }
        }
        public void Mostrar(ListBox lista)
        {
            nodo_doble actual = primero;

            while (actual != null)
            {
                lista.Items.Add(actual.Numero);
                actual = actual.Siguiente1;
            }
        }
        public void Eliminar(int num)
        {
            nodo_doble actual = primero;
            while(actual != null)
            {
                if (actual.Numero == num)
                {
                    if (actual == primero)
                    {
                        primero = primero.Siguiente1;
                        if (primero != null)
                        {
                            primero.Atras = null;
                        }
                    }else if (actual == ultimo)
                    {
                        ultimo = ultimo.Atras;
                        if (ultimo != null)
                        {
                            ultimo.Siguiente1 = null;
                        }
                    }
                    else
                    {
                        actual.Atras.Siguiente1 = actual.Siguiente1; 
                        actual.Siguiente1.Atras = actual.Atras;
                    }
                    return;
                }
            }
        }
    }
}

