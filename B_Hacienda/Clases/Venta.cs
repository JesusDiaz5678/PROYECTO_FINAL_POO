using System;
using System.Collections.Generic;
using System.Text;

namespace B_Hacienda.Clases
{
    internal class Venta
    {
        //ATRIBUTOS
        private DateTime fecha;
        private Potrero potrero;
        private Res res;
        private ulong precio;
        private static readonly ulong precio_kilo = 6350;

        //CONSTRUCTOR
        public Venta(Potrero potrero, Res res)
        {
            this.potrero = potrero;
            this.res = res;
            fecha = DateTime.Now;
        }

        //ACCESORES
        public Potrero Potrero { get => potrero; }
        public Res Res { get => res; }
        public ulong Precio
        {
            get => precio;

            set
            {
                precio = (ulong)Res.Peso * precio_kilo;
            }

        }

        public static ulong Precio_kilo => precio_kilo;
    }
}
