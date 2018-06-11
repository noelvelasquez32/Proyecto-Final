using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Detalle_venta
    {
        private int idproducto;
        private decimal total;
        private int cantidad;

        public int Idproducto
        {
            get
            {
                return idproducto;
            }

            set
            {
                idproducto = value;
            }
        }

        public decimal Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }


        public Detalle_venta()
        {

        }

        public Detalle_venta(int idproducto, decimal total, int cantidad)
        {
            this.Idproducto = idproducto;
            this.Total = total;
            this.Cantidad = cantidad;

        }

    }
}
