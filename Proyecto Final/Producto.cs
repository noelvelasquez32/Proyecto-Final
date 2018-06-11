using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Final
{
    public partial class Producto : Form
    {
        string Archivo = "C:\\Users\\Wilmar Velàsquez\\Desktop\\Proyecto Final\\Producto.txt";
        public Producto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Producto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos(Convert.ToInt32(txtId.Text),txtNombre.Text,Convert.ToDecimal(txtPrecio.Text),Convert.ToInt32(txtExistencia.Text));

            StreamWriter Escribir = File.AppendText(Archivo);

            Escribir.WriteLine(txtId.Text + "/" + txtNombre.Text +"/"+ txtPrecio.Text +"/"+ txtExistencia.Text );
            MessageBox.Show("Los datos se guardaro");
            Escribir.Close();


        }
    }
}
