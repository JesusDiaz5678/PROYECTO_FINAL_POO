using System;
using System.Collections.Generic;
using System.Text;

namespace B_Hacienda.Clases
{
    public class Venta
    {
        //ATRIBUTOS
        private DateTime fecha;
        private Potrero potrero;
        private Res res;
        private ulong precio;
        private static readonly ulong precio_Xkilo = 6350;

        //CONSTRUCTOR
        public Venta(Potrero potrero, Res res)
        {
            this.potrero = potrero;
            Res = res;
            fecha = DateTime.Now;
            precio = (ulong)Res.Peso * precio_Xkilo;
        }

        //ACCESORES
        public Potrero Potrero { get => potrero; }

        public static ulong Precio_kilo => precio_Xkilo;

        public DateTime Fecha { get => fecha;}
        public Res Res 
        { 
            get => res;

            set
            {
                bool ver = false;
                foreach (Res reses in Potrero.L_reses)
                {
                    if(reses == value)
                    {
                        ver = true;
                    }
                }

                if(ver == true)
                {
                    res = value;
                }
                else
                {
                    throw new Exception("No pertenece al potrero");
                }
            }
        
        }

        public ulong Precio { get => precio;}

        //saber la venta
        public override string ToString()
        {
            return "Venta de la res: #"+Res.ToString()+" -----> Potrero #"+Potrero.ToString()+"\n-Fecha: "+Fecha+"-\n";
        }
    }
}
