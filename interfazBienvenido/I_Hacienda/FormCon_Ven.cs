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
    public partial class FormCon_Ven : Form
    {
        private Hacienda selectHacienda;
        private FormMenu formMenu;
        private List<Hacienda> l_hacienda_aux;
        internal Hacienda SelectHacienda { get => selectHacienda; set => selectHacienda = value; }

        public FormCon_Ven(Hacienda selectHacienda,List<Hacienda> haciendas)
        {
            InitializeComponent();
            l_hacienda_aux = new List<Hacienda>();

            l_hacienda_aux.AddRange(haciendas);
            SelectHacienda = selectHacienda;
            lNombreHa.Text = SelectHacienda.Nombre;
            formMenu = new FormMenu(SelectHacienda,l_hacienda_aux);

            lreses_ven.DataSource = SelectHacienda.L_reces_vendidas;
            lbVentas.DataSource = selectHacienda.L_ventas;
        }


        internal void bContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                formMenu.Show();
                this.Hide();
            }
            catch (Exception error)
            {
                throw new Exception("Ocurrio un error en FormCon_Ven:\n", error);
            }

            
            
        }

        private void FormCon_Ven_Load(object sender, EventArgs e)
        {


        }

        private void cbPotreros_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
