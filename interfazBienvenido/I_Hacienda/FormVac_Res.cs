using B_Hacienda.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Hacienda
{
    public partial class FormVac_Res : Form
    {
        private Hacienda selectHacienda;
        private FormMenu formMenu;
        private Potrero selectPotrero;
        private Res selectRes;

        private List<Hacienda> l_hacienda_aux;
        public FormVac_Res(Hacienda selectHacienda, List<Hacienda> haciendas)
        {
            InitializeComponent();
            l_hacienda_aux = new List<Hacienda>();

            l_hacienda_aux.AddRange(haciendas);
            SelectHacienda = selectHacienda;
            lbNombreHa.Text = SelectHacienda.Nombre;
            formMenu = new FormMenu(SelectHacienda,l_hacienda_aux);

            cbPotreros.DataSource = selectHacienda.L_potreros;
        }

        public Hacienda SelectHacienda { get => selectHacienda; set => selectHacienda = value; }

        private void FormVac_Res_Load(object sender, EventArgs e)
        {

        }

        private void cbPotreros_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                selectPotrero = (Potrero)cbPotreros.SelectedItem;
                cbReses.DataSource = null;
                cbReses.DataSource = selectPotrero.L_reses;
            }
            catch (Exception error)
            {
                MessageBox.Show("Hubo un error en FormVan_Res:\n" + error);
            }
        }

        private void cbReses_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                selectRes = (Res)cbReses.SelectedItem;
                
            }
            catch (Exception error)
            {
                MessageBox.Show("Hubo un error en FormVan_Res:\n" + error);
            }
        }

        private void bVacunar_Click(object sender, EventArgs e)
        {
            try
            {
                FormVac_Viva formVac_Viva = new FormVac_Viva(SelectHacienda,selectRes,l_hacienda_aux);
                formVac_Viva.Show();
                this.Hide();
            }
            catch (Exception error)
            {
                MessageBox.Show("Hubo un error en FormVan_Res:\n" + error);
            }
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            try
            {
                formMenu.Show();
                this.Hide();
            }
            catch (Exception error)
            {
                MessageBox.Show("Hubo un error en FormVan_Res:\n" + error);
            }
        }

        private void bBacteriana_Click(object sender, EventArgs e)
        {
            try
            {
                FormVac_Bacteriana formVac_Bacteriana = new FormVac_Bacteriana(SelectHacienda, selectRes,l_hacienda_aux);
                formVac_Bacteriana.Show();
                this.Hide();
            }
            catch (Exception error)
            {
                MessageBox.Show("Hubo un error en FormVan_Res:\n" + error);
            }

        }
    }
}
