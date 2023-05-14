using System;
using System.Collections.Generic;
using System.Text;

namespace B_Hacienda.Clases
{
    //Vacuna es una Superclase
    public abstract class Vacuna
    {
        //ATRIBUTOS
        private string nombre;
        public enum l_lote {A10, B10, C10, A11, B11, C11, A12, B12, C12};
        private l_lote lote;
        private DateTime fecha_aplicacion;


        //CONSTRUCTOR
        protected Vacuna(string nombre, l_lote lote)
        {
            Nombre = nombre;
            this.lote = lote;
            fecha_aplicacion = DateTime.Now;
        }

        //ACCESORES
        public string Nombre
        { 
            get => nombre;

            set
            {
                if (value.Length > 4 && !String.IsNullOrWhiteSpace(value)
                    && !String.IsNullOrEmpty(value))
                {
                    nombre = value.ToUpper();
                }
                else
                {
                    throw new Exception("El nombre de la vacuna no puede tener espacios nulos, ni estar en blanco");
                }
            }
        
        }
        
        public DateTime Fecha_aplicacion { get => fecha_aplicacion; }
        internal l_lote Lote { get => lote;}
    }
}
