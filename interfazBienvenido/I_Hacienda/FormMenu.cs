using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_Hacienda.Clases;

namespace I_Hacienda
{
    public partial class FormMenu : Form
    {
        internal List<Hacienda> l_haciendas;
        private Hacienda selectHacienda;
        internal Potrero selectPotrero;
        internal int indicePot;
        internal List<Venta> l_ventas;
        internal List<Potrero> l_potreros;
        internal List<Res> l_reses_ven;

        internal Hacienda SelectHacienda { get => selectHacienda; set => selectHacienda = value; }
       

        public FormMenu(Hacienda selectHacienda)
        {
            InitializeComponent();

            SelectHacienda = selectHacienda;
            lbNombreHa.Text = selectHacienda.Nombre;
            //asignar las datos de la hacienda seleccionada
            l_ventas = selectHacienda.L_ventas;
            l_potreros = selectHacienda.L_potreros;
            l_reses_ven = selectHacienda.L_reces_vendidas;

            cbPotreros.DataSource = l_potreros;

        }

        

        private void bConsultar_Ven_Click(object sender, EventArgs e)
        {
            FormCon_Ven formCon_Ven = new FormCon_Ven(SelectHacienda);
            formCon_Ven.Show();
            this.Hide();
        }

        private void bAgregar_pot_Click(object sender, EventArgs e)
        {
            FormAgre_Pot formAgre_Pot = new FormAgre_Pot(SelectHacienda);
            formAgre_Pot.Show();
            this.Hide();
        }

        private void bAgregar_Res_Click(object sender, EventArgs e)
        {
            FormAgre_Res formAgre_Res = new FormAgre_Res(SelectHacienda,indicePot);
            formAgre_Res.Show();
            this.Hide();
            
            
        }

        private void bVender_Res_Click(object sender, EventArgs e)
        {
            FormVen_Res formVen_Res = new FormVen_Res(SelectHacienda);
            formVen_Res.Show();
            this.Hide();

        }

        private void lNombreHa_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbPotreros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectPotrero = (Potrero)cbPotreros.SelectedItem;
                indicePot = cbPotreros.SelectedIndex;
                lReses.DataSource = null;
                lReses.DataSource = selectPotrero.L_reses; 
                

            }
            catch(Exception error){
                throw new Exception("Ocurrió un error en el cbPotreros:\n",error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            try
            {
                // cbPotreros.DataSource = l_potreros;
            }
            catch(Exception error)
            {
                throw new Exception("Ocurrió un error cargando el FormMenu:\n",error);
            }
        }

        private void lReses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Potrero selectPotrero = (Potrero)cbPotreros.SelectedItem;
                lReses.DataSource = (Potrero)cbPotreros.SelectedItem;

            }
            catch (Exception error)
            {
                throw new Exception("Ocurrió un error en el bActualizar:\n", error);
            }
        }

        private void bVacunar_Res_Click(object sender, EventArgs e)
        {
            FormVac_Res formVac_Res = new FormVac_Res(SelectHacienda);
            formVac_Res.Show();
            this.Hide();
        }

        private void bConsultar_Vac_Click(object sender, EventArgs e)
        {
            FormCon_Van formCon_Vans = new FormCon_Van(SelectHacienda);
            formCon_Vans.Show();
            this.Hide();
        }
    }
}
