using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMACION_LOGICA_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroDeArticulos registroClientes = new RegistroDeArticulos();
            registroClientes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            articulos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Presupuesto presupuesto = new Presupuesto();
            presupuesto.ShowDialog();
        }
    }
}
