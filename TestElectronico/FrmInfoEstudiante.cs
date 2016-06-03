using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestElectronico
{
    public partial class FrmInfoEstudiante : Form
    {
        public DataSet ds_estudiante;

        public FrmInfoEstudiante()
        {
            InitializeComponent();
        }

        public FrmInfoEstudiante(DataSet ds)
        {
            this.ds_estudiante = ds;
            InitializeComponent();
        }

        private void FrmInfoEstudiante_Load(object sender, EventArgs e)
        {
            txtmatricula.Text = ds_estudiante.Tables[0].Rows[0]["matricula"].ToString();
            txtnombre.Text = ds_estudiante.Tables[0].Rows[0]["nombre"].ToString();
            txtidcarrera.Text = ds_estudiante.Tables[0].Rows[0]["idcarrera"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilidades.FrmExamen frmex = new Utilidades.FrmExamen(txtmatricula.Text.Trim());
            
            this.Hide();
            frmex.Show();

        }
    }
}
