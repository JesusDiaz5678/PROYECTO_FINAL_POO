using System;
using System.Collections.Generic;
using System.Text;

namespace B_Hacienda.Clases
{
    public class Viva : Vacuna
    {
        //ATRIBUTOS
        public enum l_gdo_atenuacion {g10, g20, g30 };
        private l_gdo_atenuacion gdo_atenuacion;



        //CONSTRUCTOR
        public Viva(string nombre, l_lote lote, l_gdo_atenuacion gdo_atenuacion ) : base(nombre, lote)
        {
            this.gdo_atenuacion = gdo_atenuacion;
                
        }
        



        //ACCESOR
        internal l_gdo_atenuacion Gdo_atenuacion { get => gdo_atenuacion;}

    }
}
