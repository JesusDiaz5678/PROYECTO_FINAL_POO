using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_Hacienda.Clases;

namespace I_Hacienda
{
    public partial class FormAgre_Pot : Form
    {
        internal Potrero selectPotrero;
        private Hacienda selectHacienda;
        private List<String> reses;
        private FormMenu formMenu;

        public Hacienda SelectHacienda { get => selectHacienda; set => selectHacienda = value; }

        public FormAgre_Pot(Hacienda selectHacienda)
        {
            InitializeComponent();
            SelectHacienda = selectHacienda;
            lNombreHa.Text = SelectHacienda.Nombre;
        }

        private void bContinuar_Click(object sender, EventArgs e)
        {

            try
            {

                if (Regex.IsMatch(tbID.Text, @"^\d+$") && tbID.Text.Length > 0)
                {
                    if (Regex.IsMatch(tbEdadmin.Text, @"^\d+$") && tbEdadmin.Text.Length > 0)
                    {
                        SelectHacienda.Agregar_potrero(new Potrero(ushort.Parse(tbID.Text), byte.Parse(tbEdadmin.Text)));
                    }
                    else throw new Exception("Edad mínima del potrero inválida {solo números}.");
                }
                else throw new Exception("Agregue un ID válido");
                tbID.Clear();
                tbEdadmin.Clear();

            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error al crear agregar un potrero a la Hacienda:\n"+ error);
            }

            /*
            FormMenu formMenu = new FormMenu(selectHacienda);
            formMenu.Show();
            this.Hide();
            */
        }

        private void FormAgre_Pot_Load(object sender, EventArgs e)
        {

        }

        private void bContinuar_Click_1(object sender, EventArgs e)
        {
            formMenu = new FormMenu(SelectHacienda);
            formMenu.Show();
            this.Hide();
        }
    }
}
