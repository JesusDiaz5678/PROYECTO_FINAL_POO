using B_Hacienda.Clases;

namespace prueba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ternero t1 = new Ternero(12);
            Ternero t2 = new Ternero(11);
            Novillo n1 = new Novillo(16);
            Cebon c1 = new Cebon(49);
            Viva v1 = new Viva("VIVA1", Vacuna.l_lote.A11, Viva.l_gdo_atenuacion.g30);
            

            Potrero mis_potrillos = new Potrero(24, 15);
            mis_potrillos.Agregar_Res(c1);

            Venta VE = new Venta(mis_potrillos, c1);

            Console.WriteLine(c1.Peso);
            Console.WriteLine(t1.Peso);
            Console.WriteLine(VE.Precio);


            Console.WriteLine(mis_potrillos.Consultar_tipo_res());
            //mis_potrillos.Agregar_Res(t1);
            //Console.WriteLine(mis_potrillos.Consultar_tipo_res());


            t1.Vacunar(v1);
            */

            //Reses
            Ternero t1 = new Ternero(11);
            Ternero t2 = new Ternero(12);
            Ternero t3 = new Ternero(9);
            Ternero t4 = new Ternero(1);
            Cebon c1 = new Cebon(49);
            Cebon c2 = new Cebon(49);


            //Vacunas
            Viva V1 = new Viva("ACETAMINOFEN", Vacuna.l_lote.B10, Viva.l_gdo_atenuacion.g20);
            Bacteriana B1 = new Bacteriana("holapedro", Vacuna.l_lote.A11, 15);

            c1.Vacunar(V1);


            foreach (Vacuna item in c1.L_vacunas)
            {
                Console.WriteLine(item.Nombre);
            }

            /*
            //Potreo
            Potrero P1 = new Potrero(2, 10);
            P1.Agregar_Res(c1);
            P1.Agregar_Res(c2);
            Console.WriteLine(P1.Consultar_tipo_res());

            //Hacienda y Venta
            Hacienda H1 = new Hacienda("donRamonn", P1);
            Venta v1 = new Venta(P1, c1);
            Console.WriteLine(v1.Precio);
            Console.WriteLine(v1.ToString());
            Console.WriteLine(H1.Vender(v1));
            H1.Agregar_potrero(P1);

            */

        }
    }
}