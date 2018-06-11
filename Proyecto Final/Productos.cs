using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Productos
    {
        private int id;
        private string nombre;
        private decimal precio;
        private int existencia;
       

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

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public decimal Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public int Existencia
        {
            get
            {
                return existencia;
            }

            set
            {
                existencia = value;
            }
        }

        public Productos()
        {

        }

        public Productos(int id,string nombre, decimal precio, int existencia)
        {
            this.Id = id;
            this.Nombre = nombre;
   
            this.Precio = precio;
            this.Existencia = existencia;
        }





    }
}
