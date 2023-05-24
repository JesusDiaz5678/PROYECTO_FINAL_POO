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
    public partial class FormVen_Res : Form
    {
        private Hacienda selectHacienda;
        private Res selectRes;
        private FormMenu formMenu;
        private Potrero selectPotrero;
        private List<Hacienda> l_hacienda_aux;


        public Hacienda SelectHacienda { get => selectHacienda; set => selectHacienda = value; }

        public FormVen_Res(Hacienda selectHacienda,List<Hacienda> haciendas)
        {
            InitializeComponent();
            l_hacienda_aux = new List<Hacienda>();

            l_hacienda_aux.AddRange(haciendas);
            SelectHacienda = selectHacienda;
            lNombreHa.Text = SelectHacienda.Nombre;
            
            formMenu = new FormMenu(SelectHacienda, l_hacienda_aux);

            cbPotreros.DataSource = formMenu.SelectHacienda.L_potreros;

        }

       
        private void bContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(selectHacienda.Vender(new Venta(selectPotrero, selectRes)));
                //pa que se vean los cambios
                cbReses.DataSource = null;
                cbReses.DataSource = selectPotrero.L_reses;

            }
            catch (Exception error)
            {
                MessageBox.Show("Hubo un error en botón vender:\n"+error);
            }
        }

        private void FormVen_Res_Load(object sender, EventArgs e)
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
                MessageBox.Show("Hubo un error en el cbPotreros:\n" + error);
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
                MessageBox.Show("Hubo un error en el cbReses:\n"+error);
            }
        }

        private void bContinuar_Click_1(object sender, EventArgs e)
        {
            try
            {
                formMenu.Show();
                this.Hide();

            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error en el botón:\n" + error);
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
