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
    public partial class FrmListaCircular : Form
    {
        ListaCircular lc = new ListaCircular();
        public FrmListaCircular()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button_Insertar_Click(object sender, EventArgs e)
        {
            listBox_Numeros.Items.Clear();
            lc.Insertar(Convert.ToInt32(textBoxNum.Text));
            lc.Mostrar(listBox_Numeros);
            textBoxNum.Clear();
        }
        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            lc.Eliminar(Convert.ToInt32(textBoxNum.Text));
            listBox_Numeros.Items.Clear();
            lc.Mostrar(listBox_Numeros);
            textBoxNum.Clear(); 
        }


        private void textBoxNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox_Numeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
