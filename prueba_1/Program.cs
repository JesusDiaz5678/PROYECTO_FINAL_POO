using B_Hacienda.Clases;

namespace prueba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            
            
        }
    }
}