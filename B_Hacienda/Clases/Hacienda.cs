using System;
using System.Collections.Generic;
using System.Text;

namespace B_Hacienda.Clases
{
    public class Hacienda
    {
        //ATRIBUTOS
        private string nombre;

        private List<Potrero> l_potreros;
        private List<Res> l_reces_vendidas;
        private List<Venta> l_ventas;

        //CONSTRUCTOR
        public Hacienda(string nombre, Potrero potrero)
        {
            Nombre = nombre;
            l_potreros = new List<Potrero>();
            l_reces_vendidas = new List<Res>();
            l_ventas = new List<Venta>();
            l_potreros.Add(potrero);
        }

        public string Nombre
        { 
            get => nombre;

            set
            {
                if (value.Length > 5 && !String.IsNullOrWhiteSpace(value)
                    && !String.IsNullOrEmpty(value))
                {
                    nombre = value.ToUpper();
                }
                else
                {
                    //¿Se permite esto?
                    throw new Exception("El nombre de la Hacienda no puede tener espacios nulos, ni estar en blanco"
                        + "\nEl nombre debe ser mayor a 5 caracteres");
                }
            }
        
        }

        public List<Potrero> L_potreros { get => l_potreros;}
        public List<Res> L_reces_vendidas { get => l_reces_vendidas;}
        public List<Venta> L_ventas { get => l_ventas;}



        //METODOS
        public string Vender(Venta venta)
        {
            try
            {
                string text = "pueba";
                bool sihay = false;
                


                for (int i = 0; i < l_potreros.Count; i++)
                {
                    if (l_potreros[i].Equals(venta.Potrero))
                    {
                        l_reces_vendidas.Add(venta.Res);
                        l_ventas.Add(venta);
                        l_potreros[i].L_reses.Remove(venta.Res);

                        sihay = true;
                        text = "Se ha vendido correctamente la res";
                    }
                }

                if (sihay)
                {
                    return text;
                    
                }
                else
                {
                    throw new Exception("No se ha podido realizar la venta");
                }
                


            }
            catch (Exception error)
            {

                throw new Exception ("Ocurrio un error en el metodo Vender: \n"+error);
            }
        }
    }
}
