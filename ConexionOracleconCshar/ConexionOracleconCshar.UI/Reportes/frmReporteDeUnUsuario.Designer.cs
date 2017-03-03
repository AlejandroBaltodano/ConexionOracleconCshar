namespace ConexionOracleconCshar.UI.Reportes
{
    partial class frmReporteDeUnUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteDeUnUsuario));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetEsquemaMigracion = new ConexionOracleconCshar.UI.DataSetEsquemaMigracion();
            this.dataSetEsquemaMigracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaUnUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaUnUsuarioTableAdapter = new ConexionOracleconCshar.UI.DataSetEsquemaMigracionTableAdapters.ConsultaUnUsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaUnUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetUnUsuario";
            reportDataSource1.Value = this.consultaUnUsuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConexionOracleconCshar.UI.Reportes.ReporteDeUnUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(754, 420);
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
            // consultaUnUsuarioBindingSource
            // 
            this.consultaUnUsuarioBindingSource.DataMember = "ConsultaUnUsuario";
            this.consultaUnUsuarioBindingSource.DataSource = this.dataSetEsquemaMigracionBindingSource;
            // 
            // consultaUnUsuarioTableAdapter
            // 
            this.consultaUnUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteDeUnUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(754, 420);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReporteDeUnUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte De Un Usuario";
            this.Load += new System.EventHandler(this.frmReporteDeUnUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaUnUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource consultaUnUsuarioBindingSource;
        private System.Windows.Forms.BindingSource dataSetEsquemaMigracionBindingSource;
        private DataSetEsquemaMigracion dataSetEsquemaMigracion;
        private DataSetEsquemaMigracionTableAdapters.ConsultaUnUsuarioTableAdapter consultaUnUsuarioTableAdapter;
    }
}