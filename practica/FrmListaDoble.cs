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
    public partial class FrmListaDoble : Form
    {
        ListaDoble ld = new ListaDoble();
        public FrmListaDoble()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Insertar_Click(object sender, EventArgs e)
        {
            listBox_Numeros.Items.Clear();
            ld.insertar(int.Parse(textBoxNum.Text));
            ld.Mostrar(listBox_Numeros);
            textBoxNum.Clear();
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            ld.Eliminar(Convert.ToInt32(textBoxNum.Text));
            listBox_Numeros.Items.Clear();
            ld.Mostrar(listBox_Numeros);
            textBoxNum.Clear() ;
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
