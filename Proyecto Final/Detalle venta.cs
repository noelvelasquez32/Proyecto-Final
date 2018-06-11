using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Detalle_venta
    {
        private int iddetalle;
        private int idventa;
        private int idproducto;
        private string nombreProducto;
        private decimal total;
        private int cantidad;
        private decimal precio;

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

        public string NombreProducto
        {
            get
            {
                return nombreProducto;
            }

            set
            {
                nombreProducto = value;
            }
        }

        public int Iddetalle
        {
            get
            {
                return iddetalle;
            }

            set
            {
                iddetalle = value;
            }
        }

        public int Idventa
        {
            get
            {
                return idventa;
            }

            set
            {
                idventa = value;
            }
        }

        public Detalle_venta()
        {

        }

        public Detalle_venta(int iddetalle,int idventa,int idproducto, string nombreproducto, decimal total, int cantidad, decimal precio)
        {
            this.Iddetalle = iddetalle;
            this.Idventa = idventa;
            this.Idproducto = idproducto;
            this.NombreProducto = nombreProducto;
            this.Total = total;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

        public string guardar(Detalle_venta detalle)
        {
            string respuesta = "";

            int iddetalle;
            int idventa;
            int idproducto;
            string nombreproducto;
            decimal total;
            int cantidad;
            decimal precio;

            iddetalle = detalle.Iddetalle;
            idventa = detalle.Idventa;
            idproducto = detalle.Idproducto;
            nombreproducto = detalle.NombreProducto;
            total = detalle.Total;
            cantidad = detalle.Cantidad;
            precio = detalle.Precio;

            respuesta = "guardo";

            return respuesta;

        }
        
    }
}
