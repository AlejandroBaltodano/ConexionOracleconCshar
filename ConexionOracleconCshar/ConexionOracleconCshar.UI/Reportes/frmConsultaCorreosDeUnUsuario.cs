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
    public partial class frmConsultaCorreosDeUnUsuario : Form
    {
        public int IdUsuarioConsulta = 0;
        public frmConsultaCorreosDeUnUsuario(int idUsuario)
        {
            IdUsuarioConsulta = idUsuario;
            InitializeComponent();
        }

        private void frmConsultaCorreosDeUnUsuario_Load(object sender, EventArgs e)
        {
            this.consultaCorreosDeUnUsuarioTableAdapter.Fill(this.dataSetEsquemaMigracion.ConsultaCorreosDeUnUsuario,IdUsuarioConsulta);
            this.reportViewer1.RefreshReport();
        }
    }
}
