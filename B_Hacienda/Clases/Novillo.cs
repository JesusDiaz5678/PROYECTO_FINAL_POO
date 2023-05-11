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


        //ACCESORES
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
                        throw new Exception("Solo se puede aplicar dos dosis de vacuna Viva");
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
                        throw new Exception("Solo se puede aplicar dos dosis de vacuna Bacteriana");
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
