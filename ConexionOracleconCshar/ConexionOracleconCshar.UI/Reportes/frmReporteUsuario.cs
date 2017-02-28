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
    public partial class frmReporteUsuario : Form
    {
        public frmReporteUsuario()
        {
            InitializeComponent();
        }

        private void frmReporteUsuario_Load(object sender, EventArgs e)
        {
         
            this.reportViewer1.RefreshReport();
        }
    }
}
