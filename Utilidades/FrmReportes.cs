using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Utilidades
{
    public partial class FrmReportes : Form
    {
        public DataSet ds;
        public string nombre_reporte;

        public FrmReportes()
        {
            InitializeComponent();
        }

        public FrmReportes(DataSet ds_t, string nombre_reporte_t)
        {
            ds = ds_t;
            nombre_reporte = nombre_reporte_t;
            // ojo poner para inicializar componentes
            InitializeComponent();
            
        }
        

        private void FrmReporteExamen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetExamen.sptodos_datos_examen' Puede moverla o quitarla según sea necesario.
            //this.sptodos_datos_examenTableAdapter.Fill(this.DataSetE);
            ReportDataSource rds = new ReportDataSource("DataSet1", ds.Tables[0]);
            // asignando reporte al reportviewer
            this.reportViewer1.LocalReport.ReportEmbeddedResource = nombre_reporte;
            this.reportViewer1.LocalReport.DataSources.Clear();
            // añadir datasources para reporte
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
