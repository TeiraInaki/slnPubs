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
using Datos.Models;

namespace WindowsPubs
{
    public partial class frmPublisher2 : Form
    {
        public frmPublisher2()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Publisher> dataSource = new List<Publisher>();

            if (txtCiudad.Text.Length > 0)
            {
                if (txtEstado.Text.Length > 0)
                {
                    if (txtPais.Text.Length > 0)
                    {
                        dataSource = AdmPublisher.Listar(txtCiudad.Text, txtEstado.Text, txtPais.Text);
                    }
                    else
                    {
                        dataSource = AdmPublisher.Listar(txtCiudad.Text, txtEstado.Text);
                    }
                }
                else
                {
                    dataSource = AdmPublisher.Listar(txtCiudad.Text);
                }
            }

            GridAuthor.DataSource = dataSource;
        }
    }
}
