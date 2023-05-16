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
        internal Hacienda SelectHacienda { get => selectHacienda; set => selectHacienda = value; }

        public FormCon_Ven(Hacienda selectHacienda)
        {
            InitializeComponent();
            SelectHacienda = selectHacienda;
            lNombreHa.Text = SelectHacienda.Nombre;
            formMenu = new FormMenu(SelectHacienda);

            lreses_ven.DataSource = SelectHacienda.L_reces_vendidas;
        }


        internal void bContinuar_Click(object sender, EventArgs e)
        {
            
            
            formMenu.Show();
            this.Hide();
            
        }

        private void FormCon_Ven_Load(object sender, EventArgs e)
        {


        }

        private void cbPotreros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception error)
            {
                throw new Exception("Ocurrio un error en FormCon_Ven:\n",error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
