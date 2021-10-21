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
    }
}
