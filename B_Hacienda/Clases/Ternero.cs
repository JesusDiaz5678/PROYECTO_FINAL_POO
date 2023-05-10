using System;
using System.Collections.Generic;
using System.Text;

namespace B_Hacienda.Clases
{
    public class Ternero : Res
    {
        //ATRIBUTOS
        private static readonly byte edad_min = 1;
        private static readonly byte edad_max = 12;
        private static readonly byte vacuna_viva = 1;
        private static readonly byte vacuna_bacteriana = 3;

        //CONSTRUCTOR 
        public Ternero(byte edad) : base(edad)
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
                if(value >= edad_min && value <= edad_max)
                {
                    edad = value;
                }
                else
                {
                    throw new Exception("La edad ingresada no corresponde al rango de edad de Ternero");
                }
            }
        }


    }
}
