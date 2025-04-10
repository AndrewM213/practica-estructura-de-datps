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
    public partial class FrmListaSimple : Form
    {
        ListaSimple ls = new ListaSimple();
        public FrmListaSimple()
        {
            InitializeComponent();
        }
        private void listBox_Numeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Numeros.Items.Clear();
            ls.Insertar(int.Parse(textBoxNum.Text));
            ls.Mostrar(listBox_Numeros);
            textBoxNum.Clear();
        }
        private void button_Insertar_Click(object sender, EventArgs e)
        {
            ls.Insertar(int.Parse(textBoxNum.Text));
            listBox_Numeros.Items.Clear();
            ls.Mostrar(listBox_Numeros);
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            ls.Eliminar(int.Parse(textBoxNum.Text));
            listBox_Numeros.Items.Clear();
            ls.Mostrar(listBox_Numeros);
            textBoxNum.Clear();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            if(ls.Buscar(int.Parse(textBoxNum.Text)) == true)
            {
                MessageBox.Show("El numero si existe en la lista");

            }
            else
            {
                MessageBox.Show("El numero no existe en la lista");
            }
        }

        private void button_Ordenar_Click(object sender, EventArgs e)
        {
            ls.Ordenar();
            listBox_Numeros.Items.Clear ();
            ls.Mostrar(listBox_Numeros);
        }
    }
}
