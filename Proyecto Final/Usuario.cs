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
    public partial class Usuario : Form
    {
        string Archivo = "C:\\Users\\Wilmar Velàsquez\\Desktop\\Proyecto Final\\Usuarios.txt";
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Usuariovendedor producto = new Usuariovendedor (Convert.ToInt32(txtId.Text), txtUsuario.Text, txtContrasena.Text);

                StreamWriter Escribir = File.AppendText(Archivo);

                Escribir.WriteLine(txtId.Text + "/" + txtUsuario.Text + "/" + txtContrasena.Text);
                MessageBox.Show("Los datos se guardaro");
                Escribir.Close();


            }
        }
    }
}
