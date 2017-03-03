using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionOracleconCshar.UI.Reportes
{
    public partial class frmReporteDeTodosLosCorreosYUsuarios : Form
    {
        public frmReporteDeTodosLosCorreosYUsuarios()
        {
            InitializeComponent();
        }

        private void frmReporteDeTodosLosCorreosYUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEsquemaMigracion.TABLA_CORREO_USUARIO' table. You can move, or remove it, as needed.
            this.tABLA_CORREO_USUARIOTableAdapter.Fill(this.dataSetEsquemaMigracion.TABLA_CORREO_USUARIO);

            this.reportViewer1.RefreshReport();
        }
    }
}
