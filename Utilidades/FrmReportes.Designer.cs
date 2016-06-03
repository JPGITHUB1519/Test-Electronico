namespace Utilidades
{
    partial class FrmReportes
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
            this.sptodos_datos_examenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetExamen = new Utilidades.DataSetExamen();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sptodos_datos_examenTableAdapter = new Utilidades.DataSetExamenTableAdapters.sptodos_datos_examenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sptodos_datos_examenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetExamen)).BeginInit();
            this.SuspendLayout();
            // 
            // sptodos_datos_examenBindingSource
            // 
            this.sptodos_datos_examenBindingSource.DataMember = "sptodos_datos_examen";
            this.sptodos_datos_examenBindingSource.DataSource = this.DataSetExamen;
            // 
            // DataSetExamen
            // 
            this.DataSetExamen.DataSetName = "DataSetExamen";
            this.DataSetExamen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sptodos_datos_examenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Utilidades.ReporteExamen.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(604, 473);
            this.reportViewer1.TabIndex = 0;
            // 
            // sptodos_datos_examenTableAdapter
            // 
            this.sptodos_datos_examenTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 473);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteExamen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteExamen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sptodos_datos_examenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetExamen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sptodos_datos_examenBindingSource;
        private DataSetExamen DataSetExamen;
        private DataSetExamenTableAdapters.sptodos_datos_examenTableAdapter sptodos_datos_examenTableAdapter;
    }
}