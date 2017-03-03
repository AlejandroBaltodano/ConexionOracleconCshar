namespace ConexionOracleconCshar.UI.Reportes
{
    partial class frmConsultaCorreosDeUnUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCorreosDeUnUsuario));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetEsquemaMigracion = new ConexionOracleconCshar.UI.DataSetEsquemaMigracion();
            this.dataSetEsquemaMigracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaCorreosDeUnUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaCorreosDeUnUsuarioTableAdapter = new ConexionOracleconCshar.UI.DataSetEsquemaMigracionTableAdapters.ConsultaCorreosDeUnUsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaCorreosDeUnUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCorreosDeUnUsuario";
            reportDataSource1.Value = this.consultaCorreosDeUnUsuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConexionOracleconCshar.UI.Reportes.ReporteCorreosDeUnUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(639, 429);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetEsquemaMigracion
            // 
            this.dataSetEsquemaMigracion.DataSetName = "DataSetEsquemaMigracion";
            this.dataSetEsquemaMigracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetEsquemaMigracionBindingSource
            // 
            this.dataSetEsquemaMigracionBindingSource.DataSource = this.dataSetEsquemaMigracion;
            this.dataSetEsquemaMigracionBindingSource.Position = 0;
            // 
            // consultaCorreosDeUnUsuarioBindingSource
            // 
            this.consultaCorreosDeUnUsuarioBindingSource.DataMember = "ConsultaCorreosDeUnUsuario";
            this.consultaCorreosDeUnUsuarioBindingSource.DataSource = this.dataSetEsquemaMigracionBindingSource;
            // 
            // consultaCorreosDeUnUsuarioTableAdapter
            // 
            this.consultaCorreosDeUnUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultaCorreosDeUnUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(639, 429);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultaCorreosDeUnUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Correos De Un Usuario";
            this.Load += new System.EventHandler(this.frmConsultaCorreosDeUnUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaCorreosDeUnUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource consultaCorreosDeUnUsuarioBindingSource;
        private System.Windows.Forms.BindingSource dataSetEsquemaMigracionBindingSource;
        private DataSetEsquemaMigracion dataSetEsquemaMigracion;
        private DataSetEsquemaMigracionTableAdapters.ConsultaCorreosDeUnUsuarioTableAdapter consultaCorreosDeUnUsuarioTableAdapter;
    }
}