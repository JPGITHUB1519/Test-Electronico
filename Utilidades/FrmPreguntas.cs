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
    public partial class FrmPreguntas : Form
    {
        public FrmPreguntas()
        {
            InitializeComponent();
        }

        public void nuevo()
        {
            txtidpregunta.Text = string.Empty;
            txtvalor.Text = string.Empty;
            txtpregunta.Text = string.Empty;
        }

        private void mostrar()
        {
            DataSet ds;

            string cmd = "EXEC spmostrar_preguntas";
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


            string cmd = string.Format("EXEC SPACTPREGUNTAS '{0}','{1}','{2}'", Convert.ToInt32(txtidpregunta.Text.Trim()), txtpregunta.Text.Trim().ToUpper(), Convert.ToInt32(txtvalor.Text.Trim()));


            DataSet ds = utilidades.ejecuta(cmd);

            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                utilidades.mensajeerror("Error Guardando los datos");


                return;
            }

            this.mostrar();
            this.nuevo();
            this.txtidpregunta.Focus();
        }

        private void eliminar()
        {
            DataSet ds = new DataSet();

            string cmd = string.Format("EXEC speliminar_preguntas '{0}'", txtidpregunta.Text.Trim());

            ds = utilidades.ejecuta(cmd);

            this.nuevo();
            this.mostrar();
            this.txtidpregunta.Focus();
        }

        private void buscar_nombre()
        {
            DataSet ds;

            string cmd = string.Format("EXEC spbuscar_preguntas_nombre '{0}'", txtbuscar.Text.Trim());
            ds = utilidades.ejecuta(cmd);
            this.dataListado.DataSource = ds.Tables[0];
            utilidades.ocultarcolumnas(dataListado);
            lblTotal.Text = "Total de Registros : " + Convert.ToString(dataListado.Rows.Count);
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btneliminar2_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.txtidpregunta.Focus();
            nuevo();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }

        private void FrmPreguntas_Load(object sender, EventArgs e)
        {
            utilidades.ocultarcolumnas(dataListado);


            this.mostrar();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscar_nombre();
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
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

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            // al dar doble click en la celda se llenara en la cajas de texto

            this.txtidpregunta.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpregunta"].Value);
            this.txtpregunta.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["pregunta"].Value);
            this.txtvalor.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["valor"].Value);

            // cambiar al otro tabpage

            this.tabControl1.SelectedIndex = 1;
            this.txtidpregunta.Focus();
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
                                cmd = string.Format("EXEC SPELIMINAR_preguntas '{0}'", codigo);

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

        private void txtidpregunta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtidpregunta.Text.Trim()))

                return;
            string cmd = string.Format("select * from preguntas where idpregunta = '{0}'", txtidpregunta.Text.Trim());

            DataSet ds = utilidades.ejecuta(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtidpregunta.Text = ds.Tables[0].Rows[0]["idpregunta"].ToString();
                txtpregunta.Text = ds.Tables[0].Rows[0]["pregunta"].ToString();
                txtvalor.Text = ds.Tables[0].Rows[0]["valor"].ToString();
            }
            else
            {

                txtpregunta.Text = string.Empty;
                txtvalor.Text = string.Empty;

            }
        }
    }


}
