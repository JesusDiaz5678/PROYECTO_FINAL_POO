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
    public partial class FormHaciendas : Form
    {
        private List<Hacienda> l_haciendas;
        private Hacienda selectHacienda;

        internal Hacienda SelectHacienda { get => selectHacienda; set => selectHacienda = value; }
        public List<Hacienda> L_haciendas { get => l_haciendas; set => l_haciendas = value; }

        public FormHaciendas(List<Hacienda> hacienda)
        {
            InitializeComponent();
            L_haciendas = new List<Hacienda>();
            L_haciendas.AddRange(hacienda);
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
          
        }

        internal void bSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbHaciendas != null)
                {
                    SelectHacienda = (Hacienda)cbHaciendas.SelectedItem;

                    FormMenu formMenu = new FormMenu(SelectHacienda,L_haciendas);
                    formMenu.Show();
                    this.Hide();

                }
                else throw new Exception("No hay una hacienda seleccioanda.");
            }
            catch(Exception error)
            {
                MessageBox.Show("Ocurrió un error en FormHaciendas:\n"+error);
            }


            
        }

        private void FormHaciendas_Load(object sender, EventArgs e)
        {
            try
            {
                cbHaciendas.DataSource = L_haciendas;

            }
            catch(Exception error)
            {
                throw new Exception("Ocurrió un error en FormHaciendas:\n",error);
            }
        }

        private void bRegresar_Click_1(object sender, EventArgs e)
        {
            try
            {
                FormBienvenido formBienvenido = new FormBienvenido();
                formBienvenido.L_haciendas.AddRange(L_haciendas);
                formBienvenido.Show();
                this.Hide();
            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrió un error en el botón:\n" + er);
            }

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
