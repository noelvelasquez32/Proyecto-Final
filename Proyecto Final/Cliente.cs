using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Cliente
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;
        private string apellido;
        private int edad;
        private string nit;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public string Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }



        public Cliente()
        {

        }

        public Cliente(int id,string nombre, string apellido, int edad, string nit)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Nit = nit;

        }


    }
}
