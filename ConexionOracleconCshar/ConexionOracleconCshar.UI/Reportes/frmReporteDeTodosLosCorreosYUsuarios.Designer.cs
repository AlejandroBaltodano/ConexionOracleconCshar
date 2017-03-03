namespace ConexionOracleconCshar.UI.Reportes
{
    partial class frmReporteDeTodosLosCorreosYUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteDeTodosLosCorreosYUsuarios));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetEsquemaMigracion = new ConexionOracleconCshar.UI.DataSetEsquemaMigracion();
            this.dataSetEsquemaMigracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tABLACORREOUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tABLA_CORREO_USUARIOTableAdapter = new ConexionOracleconCshar.UI.DataSetEsquemaMigracionTableAdapters.TABLA_CORREO_USUARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLACORREOUSUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetTodoslosCorreosUsuarios";
            reportDataSource1.Value = this.tABLACORREOUSUARIOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConexionOracleconCshar.UI.Reportes.ReporteTodosUsuariosYCorreos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(703, 460);
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
            // tABLACORREOUSUARIOBindingSource
            // 
            this.tABLACORREOUSUARIOBindingSource.DataMember = "TABLA_CORREO_USUARIO";
            this.tABLACORREOUSUARIOBindingSource.DataSource = this.dataSetEsquemaMigracionBindingSource;
            // 
            // tABLA_CORREO_USUARIOTableAdapter
            // 
            this.tABLA_CORREO_USUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteDeTodosLosCorreosYUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(703, 460);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReporteDeTodosLosCorreosYUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios y Sus Correos";
            this.Load += new System.EventHandler(this.frmReporteDeTodosLosCorreosYUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLACORREOUSUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetEsquemaMigracionBindingSource;
        private DataSetEsquemaMigracion dataSetEsquemaMigracion;
        private System.Windows.Forms.BindingSource tABLACORREOUSUARIOBindingSource;
        private DataSetEsquemaMigracionTableAdapters.TABLA_CORREO_USUARIOTableAdapter tABLA_CORREO_USUARIOTableAdapter;
    }
}