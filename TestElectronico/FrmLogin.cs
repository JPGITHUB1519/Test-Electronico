using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilidades;

namespace TestElectronico
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Principal frmprincipal = new Principal();

             string cmd = string.Format("select * from usuario_administrador where nombre_usuario = '{0}' and password = '{1}'", txtusuario.Text.Trim(), utilidades.encriptar(txtcontraseña.Text.Trim()));
             ds = utilidades.ejecuta(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
               
                MessageBox.Show("Bienvenido " + txtusuario.Text.Trim(), "TEST ELECTRONICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmprincipal.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Error de Usuario o Contraseña", "TEST ELECTRONICO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtusuario.Text = string.Empty;
            this.txtcontraseña.Text = string.Empty;
            this.txtusuario.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptarstudent_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
           

            string cmd = string.Format("select * from estudiante where matricula = '{0}'", txtmatricula.Text.Trim());
            ds = utilidades.ejecuta(cmd);

            FrmInfoEstudiante doform = new FrmInfoEstudiante(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                // si no ha tomado examen
                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["tomo_examen"]) == false)
                {
                    doform.Show();
                    

                }
                else
                {
                    MessageBox.Show("Este estudiante ya ha tomado examen", "TEST ELECTRONICO", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
                }
                

            }
            else
            {
                MessageBox.Show("Error de Estudiante", "TEST ELECTRONICO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
