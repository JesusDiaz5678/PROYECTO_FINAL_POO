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
    public partial class FormAgre_Res : Form
    {
        private Hacienda selectHacienda;
        private List<String> reses;
        private FormMenu formMenu;
        private int indicePot;
        private List<Hacienda> l_hacienda_aux;

        public Hacienda SelectHacienda { get => selectHacienda; set => selectHacienda = value; }

        public FormAgre_Res(Hacienda selectHacienda,int indicePot,List<Hacienda> haciendas)
        {
            InitializeComponent();
            l_hacienda_aux = new List<Hacienda>();

            l_hacienda_aux.AddRange(haciendas);
            SelectHacienda = selectHacienda;
            this.indicePot = indicePot;
            lNombreHa.Text = SelectHacienda.Nombre;
            reses = new List<string>();
            reses.Add("NOVILLO");
            reses.Add("TERNERO");
            reses.Add("CEBÓN");
            //agregamos las opciones
            cbTipo_Res.DataSource = reses;
            formMenu = new FormMenu(SelectHacienda,l_hacienda_aux);

        }

        private void bContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(tbEdad.Text, @"^\d+$") && tbEdad.Text.Length > 0)
                {
                    switch ((string)cbTipo_Res.SelectedItem)
                    {
                        case "NOVILLO":
                            formMenu.SelectHacienda.L_potreros[indicePot].Agregar_Res(new Novillo(byte.Parse(tbEdad.Text)));
                            //formMenu.selectPotrero.Agregar_Res(new Novillo(byte.Parse(tbEdad.Text)));
                            break;
                        case "TERNERO":
                            formMenu.SelectHacienda.L_potreros[indicePot].Agregar_Res(new Ternero(byte.Parse(tbEdad.Text)));
                            //formMenu.selectPotrero.Agregar_Res(new Ternero(byte.Parse(tbEdad.Text)));
                            break;
                        case "CEBÓN":
                            formMenu.SelectHacienda.L_potreros[indicePot].Agregar_Res(new Cebon(byte.Parse(tbEdad.Text)));
                            //formMenu.selectPotrero.Agregar_Res(new Cebon(byte.Parse(tbEdad.Text)));
                            break;
                    }
                    
                }
                else throw new Exception("Agregue una edad válida");
                tbEdad.Clear();
                MessageBox.Show("Se ha creado la res correctamente");

            }
            catch(Exception error)
            {
                MessageBox.Show("Ocurrió un error al crear una res en el potero \n:"+error);
            }


            /*
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
            */
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormAgre_Res_Load(object sender, EventArgs e)
        {

        }

        private void bContinuar_Click_1(object sender, EventArgs e)
        {
            try
            {
                formMenu.Show();
                this.Hide();
            }
            catch(Exception er)
            {
                MessageBox.Show("Ocurrió un error en el botón:\n" + er);
            }

            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
