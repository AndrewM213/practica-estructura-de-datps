using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica
{
    public partial class FrmListaDobleAnalisis : Form
    {
        clases.ListaDobleAnalisis lda = new clases.ListaDobleAnalisis();
        public FrmListaDobleAnalisis()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Insertar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textEdad.Text))
            {
                MessageBox.Show("por favor complete todos los campos");
            }
            else
            {
                try
                {
                    listView1.Items.Clear();
                    lda.Insertar(textNombre.Text.Trim(), byte.Parse(textEdad.Text));
                    lda.mostrar(listView1);
                    textNombre.Clear();
                    textEdad.Clear();
                } catch(Exception ex) 
                {
                    MessageBox.Show("error al ingresar, ingrese una edad valida");
                }
            }
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("por favor, ingrese un nombre a buscar");
            }
            else
            {
                nodo_doble buscar = lda.buscar(textNombre.Text.Trim());
                if (buscar != null)
                {
                    MessageBox.Show("Nombre: " + buscar.Nombre + "\nEdad: " + buscar.Edad);
                }
                else
                {
                    MessageBox.Show("No se encontro el nombre en la lista: ");
                }
                    
            }
        }

        private void button_Modificar_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                string seleccionado = listView1.SelectedItems[0].Text;
                if (string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textEdad.Text))
                {
                    MessageBox.Show("por favor complete todos los campos para modificar. ");
                }
                else
                {
                    lda.modificar(seleccionado, textNombre.Text.Trim(), byte.Parse(textEdad.Text));
                    listView1.Items.Clear();
                    lda.mostrar(listView1);
                    textEdad.Clear();
                    textNombre.Clear();
                }
            }
            else
            {
                MessageBox.Show("seleccione un elemento en la lista para modificar. ");
            }
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string seleccionado = listView1.SelectedItems[0].Text;
                lda.eliminar(seleccionado);
                listView1.Items.Clear();
                lda.mostrar(listView1);
            }
            else
            {
                MessageBox.Show("Seleccione  un elemento en la lista para eliminar. ");
            }
        }
    } 
}
