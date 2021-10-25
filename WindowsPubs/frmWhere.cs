using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Datos.Admin;

namespace WindowsPubs
{
    public partial class frmWhere : Form
    {
        public frmWhere()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCiudad.Text.Length > 0)
            {
                if (txtEstado.Text.Length > 0)
                {
                    GridAuthor.DataSource = AdmAuthor.Listar(txtCiudad.Text, txtEstado.Text);
                }
                else if (txtEstado.Text.Length == 0)
                {
                    GridAuthor.DataSource = AdmAuthor.Listar(txtCiudad.Text);
                }
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedValue.ToString();

            if (selected == "[TODAS]")
            {
                GridAuthor.DataSource = AdmAuthor.Listar();
            }
            else GridAuthor.DataSource = AdmAuthor.ListarDataTable(comboBox1.SelectedValue.ToString());
        }

        private void frmWhere_Load(object sender, EventArgs e)
        {
            GridAuthor.DataSource = AdmAuthor.Listar();
            llenarCombo();
        }

        private void llenarCombo()
        {
            DataTable Ciudad = AdmAuthor.ListarSoloCiudades();

            comboBox1.DataSource = Ciudad;
            comboBox1.DisplayMember = Ciudad.Columns["city"].ToString();
            comboBox1.ValueMember = Ciudad.Columns["city"].ToString();

            DataRow filaTotal = Ciudad.NewRow();
            filaTotal["city"] = "[TODAS]";

            Ciudad.Rows.InsertAt(filaTotal, 0);
        }
    }
}
