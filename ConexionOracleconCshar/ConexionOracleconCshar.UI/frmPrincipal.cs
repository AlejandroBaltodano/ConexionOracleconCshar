using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionOracleconCshar.UI
{
    public partial class frmPrincipal : Form
    {
        ConexionOracleconCshar.Model.Usuario usuario;
        public frmPrincipal(ConexionOracleconCshar.Model.Usuario usuarioRegistrado)
        {
            usuario = usuarioRegistrado;
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuario.NombreCompleto;
            lblFecha.Text =""+ DateTime.Now;
  // label1.Text = "id "+usuario.idUsuario +"\ncedula "+ usuario.Cedula + 
  //"\nnombre "+usuario.NombreCompleto +"\nusuaio "+ usuario.NombreUsuario +
  //"\nrol "+usuario.idROL;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del Sistema?", "Informacion Requerida",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       
    }
}
