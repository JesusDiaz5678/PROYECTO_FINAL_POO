using B_Hacienda.Clases;

namespace prueba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ternero t1 = new Ternero(12);
            Ternero t2 = new Ternero(11);
            Novillo n1 = new Novillo(14);
            Cebon c1 = new Cebon(49);
            Viva v1 = new Viva("VIVA1", Vacuna.l_lote.A11, Viva.l_gdo_atenuacion.g30);

            Potrero mis_potrillos = new Potrero(24, 15);

            mis_potrillos.Agregar_Res(n1);
            Console.WriteLine(mis_potrillos.Consultar_Tipo_res());
            mis_potrillos.Agregar_Res(t1);
            Console.WriteLine(mis_potrillos.Consultar_Tipo_res());

            t1.Vacunar(v1);
            
            
        }
    }
}