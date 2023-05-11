using System;
using System.Collections.Generic;
using System.Text;

namespace B_Hacienda.Clases
{
    public class Potrero
    {

        //ATRIBUTOS
        private ushort id;
        private List<Res> l_reses;
        private byte edad_min;
        

        public Potrero(ushort id, byte edad_min)
        {
            Id = id;
            l_reses = new List<Res>();
            Edad_min = edad_min;
        }


        //ACCESORES
        public ushort Id
        { 
            get => id;

            set
            {
                if(value >= 0)
                {
                    id = value;
                }
                else
                {
                    throw new Exception("El Id debe ser mayor o igual a 0");
                }
            }
        }
        public byte Edad_min
        { 
            get => edad_min;

            set
            {
                if (value > 0 && value <=120)
                {
                    edad_min = value;
                }
                else
                {
                    throw new Exception("La edad debe ser mayor a 0 y menor o igual 120 meses");
                }
            }
        }

        public List<Res> L_reses { get => l_reses; set => l_reses = value; }


        //METODOS
        public void Agregar_Res(Res res)
        {
            try
            {
                if (l_reses.Count == 0)
                {
                    if (res is Ternero)
                    {
                        if (Ternero.Edad_min <= edad_min && edad_min <= Ternero.Edad_max)
                        {
                            l_reses.Add(res);
                        }
                        else
                        {
                            throw new Exception("La edad del Ternero no corresponde a este potrero");
                        }
                    }
                    else if (res is Novillo)
                    {
                        if (Novillo.Edad_min <= edad_min && edad_min <= Novillo.Edad_max)
                        {
                            l_reses.Add(res);
                        }
                        else
                        {
                            throw new Exception("La edad del Novillo no corresponde a este potrero");
                        }
                    }
                    else if (res is Cebon)
                    {
                        if (Cebon.Edad_min <= edad_min)
                        {
                            l_reses.Add(res);
                        }
                        else
                        {
                            throw new Exception("La edad del Cebon no corresponde a este potrero");
                        }
                    }
                    else
                    {
                        throw new Exception("No agrego una res al potrero :" + id);
                    }
                }
                else
                {

                    if (l_reses[0] is Ternero)
                    {
                        if (res is Ternero)
                        {
                            if (Ternero.Edad_min <= edad_min && edad_min <= Ternero.Edad_max)
                            {
                                l_reses.Add(res);
                            }

                        }
                        else throw new Exception("No se puede agregar otro tipo de res a este potrero, solo TERNEROS");

                    }
                    else if (l_reses[0] is Novillo)
                    {
                        if (res is Novillo)
                        {
                            if (Novillo.Edad_min <= edad_min && edad_min <= Novillo.Edad_max)
                            {
                                l_reses.Add(res);
                            }
                        }
                        else throw new Exception("No se puede agregar otro tipo de res a este potrero, solo NOVILLOS");

                    }
                    else if (l_reses[0] is Cebon)
                    {
                        if (res is Cebon)
                        {
                            if (Cebon.Edad_min <= edad_min)
                            {
                                l_reses.Add(res);
                            }
                        }
                        else throw new Exception("No se puede agregar otro tipo de res a este potrero, solo CEBONES");
                    }
                }
                /*
                if(res is Ternero)
                {
                    if (Ternero.Edad_min <= edad_min && edad_min <= Ternero.Edad_max)
                    {
                        l_reses.Add(res);
                    }
                    else
                    {
                        throw new Exception("La edad del Ternero no corresponde a este potrero");
                    }
                }
                else if (res is Novillo)
                {
                    if (Novillo.Edad_min <= edad_min && edad_min <= Novillo.Edad_max)
                    {
                        l_reses.Add(res);
                    }
                    else
                    {
                        throw new Exception("La edad del Novillo no corresponde a este potrero");
                    }
                }
                else if (res is Cebon)
                {
                    if (Cebon.Edad_min <= edad_min)
                    {
                        l_reses.Add(res);
                    }
                    else
                    {
                        throw new Exception("La edad del Cebon no corresponde a este potrero");
                    }
                }
                else
                {
                    throw new Exception("No agrego una res al potrero :"+id);
                }
                */
            }
            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en el Agregar_Res: \n" + error);
            }
            
        }

        public string Consultar_tipo_res()
        {
            try
            {
                string texto = "";

                if (l_reses.Count == 0)
                {
                    texto = "No hay reses en el potrero";
                }
                else if (l_reses[0] is Ternero)
                {
                    texto = "Este potrero es de TERNEROS";
                }

                else if (l_reses[0] is Novillo)
                {
                    texto = "Este potrero es de NOVILLOS";
                }
                else if (l_reses[0] is Cebon)
                {
                    texto = "Este potrero es de CEBONES";
                }
                return texto;
            }
            catch (Exception error)
            {

                throw new Exception("Ocurrio un error en el metodo Consultar_tipo_Res: \n" + error);
            }
            
        }
    }
}
