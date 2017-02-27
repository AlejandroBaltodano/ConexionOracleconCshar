﻿using System;
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
    public partial class frmMantenimientoUsuarios : Form
    {
        ConexionOracleconCshar.Model.Usuario usuario;
        public frmMantenimientoUsuarios(ConexionOracleconCshar.Model.Usuario usuarioRegistrado)
        {
            InitializeComponent();
        }

        private void frmMantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            LlenarGridUsuarios();
            SeleccionarPrimero();

        }
        public void SeleccionarPrimero() {
            txtBuscarUsuario.Select();
            txtBuscarUsuario.Focus();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LlenarGridUsuarios()
        {
            ConexionOracleconCshar.AccesoADatos.ConexionOracle conexion = new ConexionOracleconCshar.AccesoADatos.ConexionOracle();
            string query = "select u.IDUSUARIO,u.CEDULA,u.NOMBRECOMPLETO,u.USUARIOLOGIN,"+
                  "u.PASSWORDLOGIN,r.NOMBREROL from TABLA_USUARIO u inner join TABLA_ROLES_USUARIOS r "+
                  "on u.IDROLUSUARIO = r.IDROLUSUARIO";//procedimiento que realiza la consulta
            conexion.LlenarGrid(query, dgvUsuarios);// se invoca el metodo y se envia la consulta y el grid a llenar
            PropiedadesGrip();
        }
        public void PropiedadesGrip()
        {
            this.dgvUsuarios.Columns[0].Visible = false;
            this.dgvUsuarios.Columns[3].Visible = false;
            this.dgvUsuarios.Columns[4].Visible = false;
            //this.dgvUsuarios.Columns[0].HeaderText = "# Usuario";
            this.dgvUsuarios.Columns[2].HeaderText = "NOMBRE COMPLETO";
            this.dgvUsuarios.Columns[5].HeaderText = "ROL";

        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            new Usuarios.frmNuevoUsuario().ShowDialog();
            LlenarGridUsuarios();
        }
    }
}