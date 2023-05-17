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
    public partial class FormCon_Van : Form
    {
        private Hacienda selectHacienda;
        private FormMenu formMenu;
        private Potrero selectPotrero;
        private Res selectRes;

        public FormCon_Van(Hacienda selectHacienda)
        {
            InitializeComponent();
            SelectHacienda = selectHacienda;
            lbNombreHa.Text = SelectHacienda.Nombre;
            formMenu = new FormMenu(SelectHacienda);

            cbPotreros.DataSource = selectHacienda.L_potreros;
        }

        public Hacienda SelectHacienda { get => selectHacienda; set => selectHacienda = value; }

        private void FormCon_Van_Load(object sender, EventArgs e)
        {

        }

        private void cbPotreros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectPotrero = (Potrero)cbPotreros.SelectedItem;
                cbReses.DataSource = selectPotrero.L_reses;
            }
            catch(Exception error)
            {
                MessageBox.Show("Hubo un error en FormCon_Van:\n"+error);
            }
        }

        private void cbReses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectRes = (Res)cbReses.SelectedItem;
                if (selectRes != null)
                {
                    lVacunas.DataSource = selectRes.L_vacunas;
                }
                else throw new Exception("No hay reses en el potrero");

            }
            catch (Exception error)
            {
                MessageBox.Show("Hubo un error en FormCon_Van:\n" + error);
            }
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            formMenu = new FormMenu(SelectHacienda);
            formMenu.Show();
            this.Hide();
        }
    }
}
