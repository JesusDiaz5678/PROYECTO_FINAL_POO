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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        internal void bRegresar_Click(object sender, EventArgs e)
        {
            FormHaciendas formHaciendas = new FormHaciendas();
            formHaciendas.Show();
            this.Hide();
        }

        private void bConsultar_Ven_Click(object sender, EventArgs e)
        {
            FormCon_Ven formCon_Ven = new FormCon_Ven();
            formCon_Ven.Show();
            this.Hide();
        }

        private void bAgregar_pot_Click(object sender, EventArgs e)
        {
            FormAgre_Pot formAgre_Pot = new FormAgre_Pot();
            formAgre_Pot.Show();
            this.Hide();
        }

        private void bAgregar_Res_Click(object sender, EventArgs e)
        {
            FormAgre_Res formAgre_Res = new FormAgre_Res();
            formAgre_Res.Show();
            this.Hide();
        }

        private void bVender_Res_Click(object sender, EventArgs e)
        {
            FormVen_Res formVen_Res = new FormVen_Res();
            formVen_Res.Show();
            this.Hide();
        }
    }
}
