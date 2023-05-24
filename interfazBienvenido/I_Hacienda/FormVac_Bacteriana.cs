using B_Hacienda.Clases;
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

namespace I_Hacienda
{
    public partial class FormVac_Bacteriana : Form
    {
        private Hacienda selectHacienda;
        private Res selectRes;
        private List<String> lote;
        private String selectLote;

        private List<Hacienda> l_hacienda_aux;

        public Hacienda SelectHacienda { get => selectHacienda; set => selectHacienda = value; }
        public FormVac_Bacteriana(Hacienda selectHacienda, Res resVacuna, List<Hacienda> haciendas)
        {
            InitializeComponent();
            l_hacienda_aux = new List<Hacienda>();

            l_hacienda_aux.AddRange(haciendas);
            SelectHacienda = selectHacienda;
            selectRes = resVacuna;
            lbNombreHa.Text = SelectHacienda.Nombre;

            lote = new List<string>();
            foreach (Vacuna.l_lote item in Enum.GetValues(typeof(Vacuna.l_lote)))
            {
                lote.Add(item.ToString());
            }
            //le damos los valores al cbLotes
            cbLotes.DataSource = lote;

        }

        private void FormVac_Bacteriana_Load(object sender, EventArgs e)
        {

        }

        private void FormVac_Bacteriana_Load_1(object sender, EventArgs e)
        {

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            try
            {
                FormVac_Res formVac_Res = new FormVac_Res(SelectHacienda,l_hacienda_aux);
                formVac_Res.Show();
                this.Hide();


            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error al avanzar a la siguiente ventana:\n" + error);
            }
        }

        private void bVacunar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNombreV.Text.Length > 0 &&
                    !string.IsNullOrEmpty(tbNombreV.Text) &&
                    !string.IsNullOrWhiteSpace(tbNombreV.Text))
                {
                    if (Regex.IsMatch(tbPeriodo.Text, @"^\d+$") && tbPeriodo.Text.Length > 0)
                    {
                        switch (selectLote)
                        {
                            case "A10":
                                selectRes.Vacunar(new Bacteriana(tbNombreV.Text, Vacuna.l_lote.A10, byte.Parse(tbPeriodo.Text)));
                                break;
                            case "B10":
                                selectRes.Vacunar(new Bacteriana(tbNombreV.Text, Vacuna.l_lote.B10, byte.Parse(tbPeriodo.Text)));
                                break;
                            case "C10":
                                selectRes.Vacunar(new Bacteriana(tbNombreV.Text, Vacuna.l_lote.C10, byte.Parse(tbPeriodo.Text)));
                                break;
                            case "A11":
                                selectRes.Vacunar(new Bacteriana(tbNombreV.Text, Vacuna.l_lote.A11, byte.Parse(tbPeriodo.Text)));
                                break;
                            case "B11":
                                selectRes.Vacunar(new Bacteriana(tbNombreV.Text, Vacuna.l_lote.B11, byte.Parse(tbPeriodo.Text)));
                                break;
                            case "C11":
                                selectRes.Vacunar(new Bacteriana(tbNombreV.Text, Vacuna.l_lote.C11, byte.Parse(tbPeriodo.Text)));
                                break;
                            case "A12":
                                selectRes.Vacunar(new Bacteriana(tbNombreV.Text, Vacuna.l_lote.A12, byte.Parse(tbPeriodo.Text)));
                                break;
                            case "B12":
                                selectRes.Vacunar(new Bacteriana(tbNombreV.Text, Vacuna.l_lote.B12, byte.Parse(tbPeriodo.Text)));
                                break;
                            case "C12":
                                selectRes.Vacunar(new Bacteriana(tbNombreV.Text, Vacuna.l_lote.C12, byte.Parse(tbPeriodo.Text)));
                                break;
                        }
                        tbNombreV.Clear();
                        tbPeriodo.Clear();
                        MessageBox.Show("Se ha aplicado correctamente la vacuna tipo Bacteriana");
                    }
                    else throw new Exception("Escriba un periodo de aplicación válido");
                }
                else throw new Exception("Escriba un nombre válido para la vacuna BACTERIANA ");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error en FormVac_Bacteriana:\n" + error);
            }
        }

        private void cbLotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectLote = (string)cbLotes.SelectedItem;

            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error en FormVac_Bacteriana:\n" + error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
