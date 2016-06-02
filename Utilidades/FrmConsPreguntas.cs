using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilidades
{
    public partial class FrmConsPreguntas : Form
    {
        public FrmConsPreguntas()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count == 0 || dgv1.Rows[0].Cells[0].Value == null)
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtbuscar_Validating(object sender, CancelEventArgs e)
        {
            DataSet ds;
            ds = new DataSet();
            string cmd = "SELECT * FROM PREGUNTAS ";

            if (string.IsNullOrEmpty(txtbuscar.Text.Trim()) == false)
            {
                cmd += " WHERE pregunta LIKE ('%" + txtbuscar.Text.Trim() + "%')";
            }


            ds = utilidades.ejecuta(cmd);
            dgv1.DataSource = ds.Tables[0];
        }
    }
}
