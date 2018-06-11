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
    public partial class Form1 : Form
    {


        string lineaT;
        string usuario;
        string contraseña;
        string usuarioa;
        string contraseñaa;

        bool correcto = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string fileName = @"C:\Users\Wilmar Velàsquez\Desktop\Proyecto Final\Usuarios.txt";
;
            //Abrimos el archivo, en este caso lo abrimos para lectura
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader archivo = new StreamReader(stream);

            usuarioa = Convert.ToString(textBox1.Text);
            contraseñaa = Convert.ToString(textBox2.Text);

            while (archivo.Peek() > -1)
            {
                lineaT = archivo.ReadLine();
                string[] campos = lineaT.Split('#');
                usuario = (campos[0]);
                contraseña = (campos[1]);


                if (usuarioa == usuario && contraseñaa == contraseña)
                {
                    correcto = true;

                    Seleccion llamar = new Seleccion();
                    llamar.Show();
                    break;


                }
                else
                {
                    correcto = false;
                    MessageBox.Show("incorrecto");
                    break;
                    

                }
            }

            //if (usuarioa == usuario && contraseñaa == contraseña)
            //{
            //    correcto = true;


            //}
            //else
            //{
            //    correcto = false;

            //}
            //if (correcto == false)
            //{
            //    MessageBox.Show("Datos incorrectos");
            //}
            //else
            //{

            //    Seleccion llamar = new Seleccion();
            //    llamar.Show();

            //}

            archivo.Close();

        }
    }
}
