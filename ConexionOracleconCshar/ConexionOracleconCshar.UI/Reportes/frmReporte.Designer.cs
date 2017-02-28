namespace ConexionOracleconCshar.UI.Reportes
{
    partial class frmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetEsquemaMigracion1 = new ConexionOracleconCshar.UI.DataSetEsquemaMigracion();
            this.tablA_USUARIOTableAdapter2 = new ConexionOracleconCshar.UI.DataSetEsquemaMigracionTableAdapters.TABLA_USUARIOTableAdapter();
            this.dataSetEsquemaMigracion1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracion1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Usuarios";
            reportDataSource1.Value = this.dataSetEsquemaMigracion1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConexionOracleconCshar.UI.Reportes.ReportedeTodoslosUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(714, 454);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetEsquemaMigracion1
            // 
            this.dataSetEsquemaMigracion1.DataSetName = "DataSetEsquemaMigracion";
            this.dataSetEsquemaMigracion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablA_USUARIOTableAdapter2
            // 
            this.tablA_USUARIOTableAdapter2.ClearBeforeFill = true;
            // 
            // dataSetEsquemaMigracion1BindingSource
            // 
            this.dataSetEsquemaMigracion1BindingSource.DataSource = this.dataSetEsquemaMigracion1;
            this.dataSetEsquemaMigracion1BindingSource.Position = 0;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(714, 454);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Reporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEsquemaMigracion1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetEsquemaMigracion dataSetEsquemaMigracion1;
        private DataSetEsquemaMigracionTableAdapters.TABLA_USUARIOTableAdapter tablA_USUARIOTableAdapter2;
        private System.Windows.Forms.BindingSource dataSetEsquemaMigracion1BindingSource;
    }
}