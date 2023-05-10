using System;
using System.Collections.Generic;
using System.Text;

namespace B_Hacienda.Clases
{
    public class Cebon : Res
    {
        //ATRIBUTOS
        private static readonly byte edad_min = 48;
        private static readonly byte vacuna_viva = 4;
        private static readonly byte vacuna_bacteriana = 1;

        //CONSTRUCTOR 
        public Cebon(byte edad) : base(edad)
        {
            Edad = edad;
            Random random = new Random();
            Peso = random.Next(150, 200);
        }

        public byte Edad
        {
            get => edad;

            set
            {
                if (value >= edad_min)
                {
                    edad = value;
                }
                else
                {
                    throw new Exception("La edad ingresada no corresponde al rango de edad de Cebón");
                }
            }
        }
    }
}
