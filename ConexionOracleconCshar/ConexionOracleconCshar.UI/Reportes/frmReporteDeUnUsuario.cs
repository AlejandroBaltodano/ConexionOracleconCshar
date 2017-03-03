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
        public int idUsuarioConsulta = 0;
        public frmReporteDeUnUsuario(int idUsuario)
        {
            idUsuarioConsulta = idUsuario;
            InitializeComponent();
        }

        private void frmReporteDeUnUsuario_Load(object sender, EventArgs e)
        {
            this.consultaUnUsuarioTableAdapter.Fill(this.dataSetEsquemaMigracion.ConsultaUnUsuario,idUsuarioConsulta);
            this.reportViewer1.RefreshReport();
        }
    }
}
