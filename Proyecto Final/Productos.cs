using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Productos
    {
        private string nombre;

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


        public Productos()
        {

        }

        public Productos(string nombre)
        {
            this.Nombre = nombre;
        }




    }
}
