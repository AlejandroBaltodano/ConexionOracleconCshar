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
    public partial class frmReporteDeUnUsuario : Form
    {
        public frmReporteDeUnUsuario()
        {
            InitializeComponent();
        }

        private void frmReporteDeUnUsuario_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
