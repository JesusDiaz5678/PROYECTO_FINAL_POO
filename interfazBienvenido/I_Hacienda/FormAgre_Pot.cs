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
        private Hacienda selectHacienda;
        private FormMenu formMenu;
        private List<Hacienda> l_hacienda_aux;

        public Hacienda SelectHacienda { get => selectHacienda; set => selectHacienda = value; }

        public FormAgre_Pot(Hacienda selectHacienda,List<Hacienda> haciendas)
        {
            InitializeComponent();
            SelectHacienda = selectHacienda;
            lNombreHa.Text = SelectHacienda.Nombre;
            l_hacienda_aux = new List<Hacienda>();

            l_hacienda_aux.AddRange(haciendas);
        }

        private void bContinuar_Click(object sender, EventArgs e)
        {

            try
            {

                if (Regex.IsMatch(tbID.Text, @"^\d+$") && tbID.Text.Length > 0)
                {
                    if (Regex.IsMatch(tbEdadmin.Text, @"^\d+$") && tbEdadmin.Text.Length > 0)
                    {
                        bool encontrado = false;
                        foreach (Potrero item in SelectHacienda.L_potreros)
                        {
                            if (tbID.Text.Equals(item.Id.ToString()))
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado)
                        {
                            throw new Exception("Este ID de potrero ya está en uso");
                        }
                        else SelectHacienda.Agregar_potrero(new Potrero(ushort.Parse(tbID.Text), byte.Parse(tbEdadmin.Text)));
                    }
                    else throw new Exception("Edad mínima del potrero inválida {solo números}.");
                }
                else throw new Exception("Agregue un ID válido");
                tbID.Clear();
                tbEdadmin.Clear();
                MessageBox.Show("Se ha creado el potrero correctamente");

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
            try
            {
                formMenu = new FormMenu(SelectHacienda, l_hacienda_aux);
                formMenu.Show();
                this.Hide();
            }
            catch(Exception er)
            {
                MessageBox.Show("Ocurrió un error en el botón:\n"+ er);
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
