using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ConexionOracleconCshar.UI.Usuarios
{
    public partial class frmEditarUsuario : Form
    {
        ConexionOracleconCshar.Model.Usuario usuario;
        int IdUsuarioEditar=0;
        public frmEditarUsuario(ConexionOracleconCshar.Model.Usuario usuarioRegistrado, int IdUsuario)
        {
            usuario = usuarioRegistrado;
            IdUsuarioEditar = IdUsuario;
            InitializeComponent();
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            SeleccionarPrimero();
            ObtenerUsuarioPorId(IdUsuarioEditar);
          

        }
        public void SeleccionarPrimero() {

            txtNombreUsuario.Select();
            txtNombreUsuario.Focus();

        }
        public bool ValidarCampos()
        {
            bool bandera = false;

            if (!string.IsNullOrEmpty(txtNombreUsuario.Text) && !string.IsNullOrEmpty(txtContraseña.Text) &&
            !string.IsNullOrEmpty(txtCedula.Text) && !string.IsNullOrEmpty(txtNombre.Text))
            {
                bandera = true;
            }

            return bandera;

        }

        public bool ValidarUsuario()
        {
            String cedula = String.Empty;
            String login = String.Empty;
            ConexionOracleconCshar.AccesoADatos.ConexionOracle conexion = new AccesoADatos.ConexionOracle();
            String query = "SELECT CEDULA,USUARIOLOGIN FROM TABLA_USUARIO WHERE " +
 " USUARIOLOGIN = upper('" + txtNombreUsuario.Text + "')";//consulta que manda a traer lo que hay en base de datos

            OracleDataReader reader = conexion.Query(query);//objeto reader para extraer los datos de la consulta
            if (reader.HasRows)//verifica si hay filas seleccionadas
            {
                while (reader.Read())//recorre el objeto y mete los datos a la variables
                {
                    cedula = reader.GetString(0);
                    login = reader.GetString(1);

                }

            }
            if (txtCedula.Text == cedula || txtNombreUsuario.Text.ToUpper() == login)//se evaluan si algunos de los dos es verdadero, ahi se utiliza el .toUpper()
            {
                return false;//retorna falso para que no proceda

            }
            else
            {
                return true;//retorna true para que proceda.
            }


        }


        public void ObtenerUsuarioPorId(int id) {
            AccesoADatos.ConexionOracle conexion = new AccesoADatos.ConexionOracle();
            String query = String.Empty;
            String rol = String.Empty;
            query = "SELECT u.IDUSUARIO,u.CEDULA,u.NOMBRECOMPLETO,u.USUARIOLOGIN,u.PASSWORDLOGIN"+
",r.NOMBREROL FROM TABLA_USUARIO u inner join TABLA_ROLES_USUARIOS r "+
" on u.IDROLUSUARIO = r.IDROLUSUARIO"+
" where u.IDUSUARIO ="+ id+" ";
            OracleDataReader reader = conexion.Query(query);
            if (reader.HasRows)
            {
                while (reader.Read()) {
                    txtNombreUsuario.Text = reader.GetString(3);
                    txtContraseña.Text = reader.GetString(4);
                    txtCedula.Text = reader.GetString(1);
                    txtNombre.Text = reader.GetString(2);
                    llenarComboBoxRoles();
                    rol= reader.GetString(5);
                   

                } 

            }
            cbROL.Text = rol;

        }
        public void llenarComboBoxRoles()
        {
            ConexionOracleconCshar.AccesoADatos.ConexionOracle conexion = new ConexionOracleconCshar.AccesoADatos.ConexionOracle();
            string Query = "select * from TABLA_ROLES_USUARIOS";//procedimiento almacenado que me realiza la consulta
            string id = "IDROLUSUARIO"; //id de la tabla
            string descripcion = "NOMBREROL";
            string nombreTabla = "TABLA_ROLES_USUARIOS";//nombre de la tabla
            conexion.LlenarCombo(Query, cbROL, id, descripcion, nombreTabla);// se invoca el metodo

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                   
                        AccesoADatos.ConexionOracle conexion = new AccesoADatos.ConexionOracle();
                        String query = String.Empty;
                        query = "begin " +
    " ACTUALIZARUSUARIO(" + IdUsuarioEditar + ",'" + txtCedula.Text + "','" + txtNombre.Text + "','" + txtNombreUsuario.Text + "','" + txtContraseña.Text + "'," + cbROL.SelectedValue + "); " +
                        " end; ";
                        conexion.OperacionDML(query);
                        MessageBox.Show("Transaccion Realizada exitosamente", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                 

                    
                }
                else
                {
 MessageBox.Show("Debe ingresar datos en los campos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

            MessageBox.Show("Problemas al Realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditarLoginActivo() {
            if (chbxEditarLogin.Checked == true)
            {

                txtNombreUsuario.Enabled = true;
                txtContraseña.Enabled = true;
                MessageBox.Show("Si actualiza el nombre de Usuario debe de cambiar la contraseña\n" +
                "Pero si solo NECESITA CAMBIAR LA CONTRASEÑA NO HAY PROBLEMA SI NO CAMBIA EL NOMBRE DE USUARIO", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                txtNombreUsuario.Enabled = false;
                txtContraseña.Enabled = false;
            }

        }

        private void chbxEditarLogin_CheckedChanged(object sender, EventArgs e)
        {
            EditarLoginActivo();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            AccesoADatos.ConexionOracle conexion = new AccesoADatos.ConexionOracle();
            if (usuario.idUsuario == IdUsuarioEditar)
            {
 MessageBox.Show("No se puede eliminar el usuario actualmente registrado", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Desea Eliminar el Registro?", "Informacion Requerida",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
      == DialogResult.Yes)
                {
       String query = " begin" +
" ELIMINARUNUSUARIO('" + IdUsuarioEditar + "');" +
               " end; ";
                    conexion.OperacionDML(query);

                    MessageBox.Show("Transaccion realizada con exito", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                 
                }
               
            }
        }
    }
}
