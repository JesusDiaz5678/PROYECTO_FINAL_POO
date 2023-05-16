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
            Random ale = new Random();
            Peso = ale.Next(150, 200);
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
                    throw new Exception("La edad ingresada no corresponde al rango de edad de Ternero");
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
                        L_vacunas.Add(vacuna);
                    }
                    else
                    {
                        throw new Exception("Solo se puede aplicar una dosis de vacuna Viva");
                    }
                }
                else if (vacuna is Bacteriana)
                {
                    if (Num_vacunas_bacterianas < vacuna_bacteriana)
                    {
                        Num_vacunas_bacterianas += 1;
                        L_vacunas.Add(vacuna);
                    }
                    else
                    {
                        throw new Exception("Solo se puede aplicar tres dosis de vacuna Bacteriana");
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

        public override string ToString()
        {
            return "TERNERO "+edad.ToString();
        }

    }
}
