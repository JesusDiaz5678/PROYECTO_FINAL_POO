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

        private Hacienda selectHacienda;
        private Potrero selectPotrero;
        private int indicePot;
        private List<Potrero> l_potreros;
        private List<Hacienda> l_hacienda_aux;


        internal Hacienda SelectHacienda { get => selectHacienda; set => selectHacienda = value; }
       

        public FormMenu(Hacienda selectHacienda, List<Hacienda> haciendas)
        {
            InitializeComponent();
            l_hacienda_aux = new List<Hacienda>();
            SelectHacienda = selectHacienda;
            lbNombreHa.Text = selectHacienda.Nombre;
            //asignar las datos de la hacienda seleccionada
            l_potreros = selectHacienda.L_potreros;

            l_hacienda_aux.AddRange(haciendas);

            cbPotreros.DataSource = l_potreros;

        }

        

        private void bConsultar_Ven_Click(object sender, EventArgs e)
        {
            try
            {
                FormCon_Ven formCon_Ven = new FormCon_Ven(SelectHacienda,l_hacienda_aux);
                formCon_Ven.Show();
                this.Hide();
            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrió un error en el botón:\n" + er);
            }
            
        }

        private void bAgregar_pot_Click(object sender, EventArgs e)
        {
            try
            {
            FormAgre_Pot formAgre_Pot = new FormAgre_Pot(SelectHacienda,l_hacienda_aux);
            formAgre_Pot.Show();
            this.Hide();
            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrió un error en el botón:\n" + er);
            }
        }

        private void bAgregar_Res_Click(object sender, EventArgs e)
        {
            try
            {
            FormAgre_Res formAgre_Res = new FormAgre_Res(SelectHacienda,indicePot,l_hacienda_aux);
            formAgre_Res.Show();
            this.Hide();
            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrió un error en el botón:\n" + er);
            }
        }

        private void bVender_Res_Click(object sender, EventArgs e)
        {
            try
            {
            FormVen_Res formVen_Res = new FormVen_Res(SelectHacienda,l_hacienda_aux);
            formVen_Res.Show();
            this.Hide();
            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrió un error en el botón:\n" + er);
            }
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
                MessageBox.Show("Ocurrió un error en el cbPotreros:\n" + error);
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
                MessageBox.Show("Ocurrió un error en el botón:\n" + error);
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
            try
            {
            FormVac_Res formVac_Res = new FormVac_Res(SelectHacienda,l_hacienda_aux);
            formVac_Res.Show();
            this.Hide();
            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrió un error en el botón:\n" + er);
            }
        }

        private void bConsultar_Vac_Click(object sender, EventArgs e)
        {
            try
            {
            FormCon_Van formCon_Vans = new FormCon_Van(SelectHacienda,l_hacienda_aux);
            formCon_Vans.Show();
            this.Hide();
            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrió un error en el botón:\n" + er);
            }
        }

        private void bRegresarHacienda_Click(object sender, EventArgs e)
        {
            try
            {
            //el fomhaciendas me recibe una lista de haciendas, por ende una lista auxiliar con la hacienda actual añadida
            FormHaciendas formHaciendas = new FormHaciendas(l_hacienda_aux);
            formHaciendas.Show();
            this.Hide();
            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrió un error en el botón:\n" + er);
            }
        }
    }
}
