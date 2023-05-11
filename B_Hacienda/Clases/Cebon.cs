using System;
using System.Collections.Generic;
using System.Text;

namespace B_Hacienda.Clases
{
    public class Cebon : Res
    {
        //ATRIBUTOS
        private static readonly byte edad_min = 49;
        private static readonly byte vacuna_viva = 4;
        private static readonly byte vacuna_bacteriana = 1;

        //CONSTRUCTOR 
        public Cebon(byte edad) : base(edad)
        {
            Edad = edad;
            Random random = new Random();
            Peso = random.Next(150, 200);
        }

        //ACCESORES
        public byte Edad
        {
            get => edad;

            set
            {
                if (value >= Edad_min)
                {
                    edad = value;
                }
                else
                {
                    throw new Exception("La edad ingresada no corresponde al rango de edad de Cebón");
                }
            }
        }

        public static byte Edad_min => edad_min;

        //METODOS
        public override void Vacunar(Vacuna vacuna)
        {
            try
            {

                if (vacuna is Viva)
                {
                    if (Num_vacunas_vivas < vacuna_viva)
                    {
                        Num_vacunas_vivas += 1;
                    }
                    else
                    {
                        throw new Exception("Solo se puede aplicar cuatro dosis de vacuna Viva");
                    }
                }
                else if (vacuna is Bacteriana)
                {
                    if (Num_vacunas_bacterianas < vacuna_bacteriana)
                    {
                        Num_vacunas_bacterianas += 1;
                    }
                    else
                    {
                        throw new Exception("Solo se puede aplicar una dosis de vacuna Bacteriana");
                    }
                }
                else
                {
                    throw new Exception("No ingreso ningun tipo de Vacuna");
                }
            }

            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en el metodo Vacunar: \n" + error);
            }


        }
    }
}
