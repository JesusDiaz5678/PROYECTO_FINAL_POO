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
    }
}
