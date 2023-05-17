using B_Hacienda.Clases;
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
    public partial class FormVac_Viva : Form
    {
        private Hacienda selectHacienda;
        private FormMenu formMenu;
        private Potrero selectPotrero;
        private Res selectRes;
        private List<String> lote;
        private String selectLote;
        private List<String> gdo_atenuacion;
        private String selectGdo;

        public Hacienda SelectHacienda { get => selectHacienda; set => selectHacienda = value; }

        public FormVac_Viva(Hacienda selectHacienda, Res resVacuna)
        {
            InitializeComponent();
            SelectHacienda = selectHacienda;
            selectRes = resVacuna;
            lbNombreHa.Text = SelectHacienda.Nombre;
            formMenu = new FormMenu(SelectHacienda);

            //cuales son los lotes de la vacuna
            lote = new List<string>();
            foreach (Vacuna.l_lote item in Enum.GetValues(typeof(Vacuna.l_lote)))
            {
                lote.Add(item.ToString());
            }

            //le damos los valores al cbLotes
            cbLotes.DataSource = lote;

            //cuales son los grados de atenuacion
            gdo_atenuacion = new List<string>();
            foreach (Viva.l_gdo_atenuacion item in Enum.GetValues(typeof(Viva.l_gdo_atenuacion)))
            {
                gdo_atenuacion.Add(item.ToString());
            }
            //le damos los valores al cgrado
            cgrado.DataSource = gdo_atenuacion;
        }

        private void FormVac_Viva_Load(object sender, EventArgs e)
        {

        }

        private void cbLotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectLote = (string)cbLotes.SelectedItem;

            }
            catch(Exception error)
            {
                MessageBox.Show("Ocurrió un error en FormVac_Viva:\n"+error);
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
                    switch (selectLote)
                    {
                        case "A10":
                            switch (selectGdo)
                            {
                                case "g10":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.A10,Viva.l_gdo_atenuacion.g10));
                                    break;
                                case "g20":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.A10, Viva.l_gdo_atenuacion.g20));
                                    break;
                                case "g30":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.A10, Viva.l_gdo_atenuacion.g30));
                                    break;
                            }
                            break;
                        case "B10":
                            switch (selectGdo)
                            {
                                case "g10":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.B10, Viva.l_gdo_atenuacion.g10));
                                    break;
                                case "g20":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.B10, Viva.l_gdo_atenuacion.g20));
                                    break;
                                case "g30":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.B10, Viva.l_gdo_atenuacion.g30));
                                    break;
                            }
                            break;
                        case "C10":
                            switch (selectGdo)
                            {
                                case "g10":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.C10, Viva.l_gdo_atenuacion.g10));
                                    break;
                                case "g20":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.C10, Viva.l_gdo_atenuacion.g20));
                                    break;
                                case "g30":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.C10, Viva.l_gdo_atenuacion.g30));
                                    break;
                            }
                            break;
                        case "A11":
                            switch (selectGdo)
                            {
                                case "g10":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.A11, Viva.l_gdo_atenuacion.g10));
                                    break;
                                case "g20":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.A11, Viva.l_gdo_atenuacion.g20));
                                    break;
                                case "g30":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.A11, Viva.l_gdo_atenuacion.g30));
                                    break;
                            }
                            break;
                        case "B11":
                            switch (selectGdo)
                            {
                                case "g10":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.B11, Viva.l_gdo_atenuacion.g10));
                                    break;
                                case "g20":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.B11, Viva.l_gdo_atenuacion.g20));
                                    break;
                                case "g30":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.B11, Viva.l_gdo_atenuacion.g30));
                                    break;
                            }
                            break;
                        case "C11":
                            switch (selectGdo)
                            {
                                case "g10":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.C11, Viva.l_gdo_atenuacion.g10));
                                    break;
                                case "g20":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.C11, Viva.l_gdo_atenuacion.g20));
                                    break;
                                case "g30":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.C11, Viva.l_gdo_atenuacion.g30));
                                    break;
                            }
                            break;
                        case "A12":
                            switch (selectGdo)
                            {
                                case "g10":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.A12, Viva.l_gdo_atenuacion.g10));
                                    break;
                                case "g20":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.A12, Viva.l_gdo_atenuacion.g20));
                                    break;
                                case "g30":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.A12, Viva.l_gdo_atenuacion.g30));
                                    break;
                            }
                            break;
                        case "B12":
                            switch (selectGdo)
                            {
                                case "g10":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.B12, Viva.l_gdo_atenuacion.g10));
                                    break;
                                case "g20":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.B12, Viva.l_gdo_atenuacion.g20));
                                    break;
                                case "g30":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.B12, Viva.l_gdo_atenuacion.g30));
                                    break;
                            }
                            break;
                        case "C12":
                            switch (selectGdo)
                            {
                                case "g10":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.C12, Viva.l_gdo_atenuacion.g10));
                                    break;
                                case "g20":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.C12, Viva.l_gdo_atenuacion.g20));
                                    break;
                                case "g30":
                                    selectRes.Vacunar(new Viva(tbNombreV.Text, Vacuna.l_lote.C12, Viva.l_gdo_atenuacion.g30));
                                    break;
                            }
                            break;
                    }
                    tbNombreV.Clear();
                }
                else throw new Exception("Escriba un nombre válido para la vacuna VIVA");


            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error en FormVac_Viva:\n" + error);
            }
        }

        private void cgrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectGdo = (string)cgrado.SelectedItem;

            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error en FormVac_Viva:\n" + error);
            }

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            try
            {
                FormVac_Res formVac_Res = new FormVac_Res(SelectHacienda);
                formVac_Res.Show();
                this.Hide();


            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error al avanzar a la siguiente ventana:\n" + error);
            }
        }
    }
}
