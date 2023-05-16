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
    public partial class FormBienvenido : Form
    {
        internal List<Hacienda> l_haciendas;
        



        public FormBienvenido()
        {
            InitializeComponent();
            l_haciendas = new List<Hacienda>();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        internal void bCrear_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbNombre.Text.Length > 0 &&
                    !string.IsNullOrEmpty(tbNombre.Text) &&
                    !string.IsNullOrWhiteSpace(tbNombre.Text))
                {
                    if (Regex.IsMatch(tbID.Text, @"^\d+$") && tbID.Text.Length >0)
                    {
                        if(Regex.IsMatch(tbEdadmin.Text, @"^\d+$") && tbEdadmin.Text.Length > 0)
                        {
                            l_haciendas.Add(new Hacienda(tbNombre.Text, new Potrero(ushort.Parse(tbID.Text), byte.Parse(tbEdadmin.Text))));
                        }
                        else throw new Exception("Edad mínima inválida {solo números}.");
                    }
                    else throw new Exception("ID del potrero invalido {solo números}.");
                }
                else throw new Exception("El nombre de la hacienda inválido.");
                tbNombre.Clear();
                tbID.Clear();
                tbEdadmin.Clear();
            }
            catch(Exception error)
            {
                MessageBox.Show("Ocurrió un error en crear hacienda: \n"+error);
            }
            


        }

        private void bSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (l_haciendas.Count == 0)
                {
                    throw new Exception("Cree al menos una hacienda");
                }
                else
                {
                    FormHaciendas formHaciendas = new FormHaciendas(l_haciendas);
                    formHaciendas.Show();

                    this.Hide();
                }
                
            }
            catch(Exception error)
            {
                MessageBox.Show("Ocurrió un error al avanzar a la siguiente ventana:\n"+error);
            }
        }
    }
}
