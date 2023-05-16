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
    public partial class FormHaciendas : Form
    {
        public FormHaciendas()
        {
            InitializeComponent();
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            FormBienvenido form1 = new FormBienvenido();
            form1.Show();
            this.Hide();
        }

        private void bSiguiente_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }
    }
}
