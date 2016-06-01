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
    public partial class FrmUsuarioAdministrador : Form
    {
        public FrmUsuarioAdministrador()
        {
            InitializeComponent();
        }

        public void nuevo()
        {
            txtnombre.Text = string.Empty;
            txtpassword.Text = string.Empty;
        }

        private void mostrar()
        {
            DataSet ds;

            string cmd = "EXEC spmostrar_usuario";
            ds = utilidades.ejecuta(cmd);
            this.dataListado.DataSource = ds.Tables[0];

            lblTotal.Text = "Total de Registros : " + Convert.ToString(dataListado.Rows.Count);
        }

        private void salvar()
        {
            if (utilidades.validar(this, errorProvider1) == true)
            {
                return;
            }


            string cmd = string.Format("EXEC SPACTUSUARIO '{0}','{1}'", txtnombre.Text.Trim(), utilidades.encriptar(txtpassword.Text.Trim()));


            DataSet ds = utilidades.ejecuta(cmd);

            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                utilidades.mensajeerror("Error Guardando los datos");


                return;
            }

            this.mostrar();
            this.nuevo();
            this.txtnombre.Focus();
        }

        private void eliminar()
        {
            DataSet ds = new DataSet();

            string cmd = string.Format("EXEC speliminar_usuario '{0}'", txtnombre.Text.Trim());

            ds = utilidades.ejecuta(cmd);

            this.nuevo();
            this.mostrar();
            this.txtnombre.Focus();
        }

        private void buscar_nombre()
        {
            DataSet ds;

            string cmd = string.Format("EXEC spbuscar_usuario_nombre '{0}'", txtbuscar.Text.Trim());
            ds = utilidades.ejecuta(cmd);
            this.dataListado.DataSource = ds.Tables[0];
            utilidades.ocultarcolumnas(dataListado);
            lblTotal.Text = "Total de Registros : " + Convert.ToString(dataListado.Rows.Count);
        }


        private void FrmUsuarioAdministrador_Load(object sender, EventArgs e)
        {
            this.mostrar();
            utilidades.ocultarcolumnas(dataListado);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            this.salvar();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }

        private void btneliminar2_Click(object sender, EventArgs e)
        {
            this.eliminar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.nuevo();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkeliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            // al dar doble click en la celda se llenara en la cajas de texto

            this.txtnombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre_usuario"].Value);
            this.txtpassword.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["password"].Value);
            
            // cambiar al otro tabpage

            this.tabControl1.SelectedIndex = 1;
            this.txtnombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (chkeliminar.Checked == true)
            {
                try
                {
                    DialogResult Opcion;

                    Opcion = MessageBox.Show("¿Realmente desea eliminar los registros?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {

                        string codigo;
                        string cmd;
                        DataSet ds = new DataSet();
                        int cont_eliminados = 0;
                        foreach (DataGridViewRow row in dataListado.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                codigo = Convert.ToString(row.Cells[1].Value);
                                cmd = string.Format("EXEC SPELIMINAR_usuario '{0}'", codigo);

                                ds = utilidades.ejecuta(cmd);

                            }

                        }

                        // show messages deletes
                        if (cont_eliminados > 0)
                        {
                            if (cont_eliminados == 1)
                            {
                                utilidades.mensajeok("Se elimino un registro");
                            }
                            else
                            {
                                utilidades.mensajeok("Se eliminaron " + cont_eliminados + " registros");
                            }
                        }

                        this.chkeliminar.Checked = false;

                        this.mostrar();

                    }
                }

                catch (Exception ex)
                {
                    utilidades.mensajeerror("No se Ha eliminado ningún dato");
                }

            }
            else
            {
                utilidades.mensajeerror("Debe Seleccionar los Registros a Eliminar");
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscar_nombre();
        }

        private void txtnombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombre.Text.Trim()))

                return;
            string cmd = string.Format("select * from usuario_administrador where nombre_usuario = '{0}'", txtnombre.Text.Trim());

            DataSet ds = utilidades.ejecuta(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtnombre.Text = ds.Tables[0].Rows[0]["nombre_usuario"].ToString();
                txtpassword.Text = ds.Tables[0].Rows[0]["password"].ToString();

            }
            else
            {

                txtpassword.Text = string.Empty;

            }
        }
    }
}
