using System;
using System.Collections.Generic;
using System.Text;

namespace B_Hacienda.Clases
{
    public class Novillo : Res
    {
        //ATRIBUTOS
        private static readonly byte edad_min = 13;
        private static readonly byte edad_max = 48;
        private static readonly byte vacuna_viva = 2;
        private static readonly byte vacuna_bacteriana = 2;

        //CONSTRUCTOR 
        public Novillo(byte edad) : base(edad)
        {
            Edad = edad;
            Random random = new Random();
            Peso = random.Next(500, 600);
        }

        public byte Edad
        {
            get => edad;

            set
            {
                if (value >= edad_min && value <= edad_max)
                {
                    edad = value;
                }
                else
                {
                    throw new Exception("La edad ingresada no corresponde al rango de edad de Novillo");
                }
            }
        }
    }
}
