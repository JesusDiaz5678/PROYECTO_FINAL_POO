using System;
using System.Collections.Generic;
using System.Text;

namespace B_Hacienda.Clases
{
    public class Bacteriana : Vacuna
    {
        //ATRIBUTOS
        private byte pdo_aplicacion; //dias

        //CONSTRUCTOR
        public Bacteriana(string nombre, l_lote lote, byte pdo_aplicacion) : base(nombre, lote)
        {
            Pdo_aplicacion = pdo_aplicacion;
        }

        public byte Pdo_aplicacion
        {
            get
            {
                return pdo_aplicacion;
            }

            //Validar que los dias esten entre 2-4 semanas
            set
            {
                if(value > 0 && (value >= 14 && value <=28))
                {
                    Pdo_aplicacion = value;
                }
                else if(value < 0)
                {
                    throw new Exception("Ingrese un número mayor a 0");
                }
                else
                {
                    throw new Exception("El periodo de aplicación de Vacuna Bacteriana debe estar entre 14-28 días");
                }

            }
        }
    }
}
