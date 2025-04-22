using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica.clases
{
    internal class ListaDobleAnalisis
    {
        private nodo_doble primero = null;
        private nodo_doble ultimo = null;

        public void Insertar(string nombre, byte edad)
        {
            nodo_doble nuevo = new nodo_doble();
            nuevo.Nombre = nombre;
            nuevo.Edad = edad;
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
        public void mostrar(ListView list)
        {
            nodo_doble actual = primero;
            while (actual != null)
            {
                ListViewItem item = new ListViewItem(actual.Nombre);
                item.SubItems.Add(actual.Edad.ToString());
                list.Items.Add(item);
                actual = actual.Siguiente1;
            }
        }
        public nodo_doble buscar(string nombre)
        {
            nodo_doble actual = primero;
            while (actual != null)
            {
                if(actual.Nombre == nombre)
                {
                    return actual;
                }
                actual = actual.Siguiente1;
            }
            return null;
        }
        public void modificar(string actualnom, string nuevonom, byte nuevaed)
        {
            nodo_doble modi = buscar(actualnom);
            if (modi != null)
            {
                modi.Nombre = nuevonom;
                modi.Edad = nuevaed;
            }
            else
            {
                MessageBox.Show("no se encontro el nombre a modificar. ");
            }
        }
        public void eliminar(string nombre)
        {
            nodo_doble eli = buscar(nombre);
            if (eli != null)
            {
                if(eli == primero)
                {
                    primero = primero.Siguiente1;
                    if (primero != null)
                    {
                        primero.Atras= null;
                    }
                }else if(eli == ultimo)
                {
                    ultimo = ultimo.Atras;
                    if(ultimo != null)
                    {
                        ultimo.Siguiente1 = null;
                    }
                }
                else
                {
                    eli.Atras.Siguiente1 = eli.Siguiente1;
                    eli.Siguiente1.Atras = eli.Atras;
                }
            }
        }
    }
}
