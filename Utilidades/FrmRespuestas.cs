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
    public partial class FrmRespuestas : Form
    {
        public FrmRespuestas()
        {
            InitializeComponent();
        }

        public void nuevo()
        {
            this.txtidrespuesta.Text = string.Empty;
            this.txtidpregunta.Text = string.Empty;
            this.chkeliminar.Checked = false;
            this.txtrespuesta.Text = string.Empty;
            this.txtidrespuesta.Focus();
            this.chkiscorrect.Checked = false;
        }

        private void mostrar()
        {
            DataSet ds;

            string cmd = "EXEC spmostrar_respuestas";
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

            string e = chkiscorrect.Checked ? "1" : "0";
            string cmd = string.Format("EXEC SPACTRESPUESTAS '{0}','{1}','{2}','{3}'", Convert.ToInt32(txtidrespuesta.Text.Trim()), Convert.ToInt32(this.txtidpregunta.Text.Trim()), txtrespuesta.Text.Trim().ToUpper(), e);


            DataSet ds = utilidades.ejecuta(cmd);

            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                utilidades.mensajeerror("Error Guardando los datos");


                return;
            }

            this.mostrar();
            this.nuevo();
            this.txtidrespuesta.Focus();
        }

        private void eliminar()
        {
            DataSet ds = new DataSet();

            string cmd = string.Format("EXEC SPELIMINAR_RESPUESTA '{0}'", txtidrespuesta.Text.Trim());

            ds = utilidades.ejecuta(cmd);

            this.nuevo();
            this.mostrar();
            this.txtidrespuesta.Focus();
        }

        private void buscar_nombre()
        {
            DataSet ds;

            string cmd = string.Format("EXEC spbuscar_respuestas_nombre '{0}'", txtbuscar.Text.Trim());
            ds = utilidades.ejecuta(cmd);
            this.dataListado.DataSource = ds.Tables[0];
            utilidades.ocultarcolumnas(dataListado);
            lblTotal.Text = "Total de Registros : " + Convert.ToString(dataListado.Rows.Count);
        }

        private void buscar_preguntas_respuestas()
        {
            DataSet ds;

            string cmd = string.Format("EXEC SPMOSTRAR_PREGUNTAS_RESPUESTAS '{0}'", txtbuscar2.Text.Trim());
            ds = utilidades.ejecuta(cmd);
            this.dgvpreguntas_respuestas.DataSource = ds.Tables[0];
            utilidades.ocultarcolumnas(dataListado);
            lblTotal.Text = "Total de Registros : " + Convert.ToString(dataListado.Rows.Count);

        }

        private void FrmRespuestas_Load(object sender, EventArgs e)
        {
            utilidades.ocultarcolumnas(dataListado);
            buscar_preguntas_respuestas();
            this.mostrar();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
            this.txtbuscar.Focus();
        }

        private void btneliminar2_Click(object sender, EventArgs e)
        {
            this.eliminar();
            this.txtidpregunta.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.nuevo();
            this.txtidpregunta.Focus();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            this.txtidrespuesta.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idrespuesta"].Value);
            this.txtidpregunta.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpregunta"].Value);
            this.txtrespuesta.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["respuesta"].Value);
            this.chkiscorrect.Checked = Convert.ToBoolean(this.dataListado.CurrentRow.Cells["iscorrect"].Value);
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
                                cmd = string.Format("EXEC SPELIMINAR_respuesta '{0}'", codigo);

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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConsPreguntas doform = new FrmConsPreguntas();

            if (doform.ShowDialog() == DialogResult.OK)
            {
                int pos = doform.dgv1.CurrentCell.RowIndex;

                txtidpregunta.Text = doform.dgv1.Rows[pos].Cells[0].Value.ToString();
            }

            txtidpregunta.Focus();
        }

        private void txtbuscar2_TextChanged(object sender, EventArgs e)
        {

            this.buscar_preguntas_respuestas();
        }

        private void txtidrespuesta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtidrespuesta.Text.Trim()))

                return;
            string cmd = string.Format("select * from respuestas where idrespuesta = '{0}'", txtidrespuesta.Text.Trim());

            DataSet ds = utilidades.ejecuta(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtidrespuesta.Text = ds.Tables[0].Rows[0]["idrespuesta"].ToString();
                txtidpregunta.Text = ds.Tables[0].Rows[0]["idpregunta"].ToString();
                txtrespuesta.Text = ds.Tables[0].Rows[0]["respuesta"].ToString();
                chkiscorrect.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["iscorrect"]);

            }
            else
            {

                txtrespuesta.Text = string.Empty;
                txtidpregunta.Text = string.Empty;
                this.chkiscorrect.Checked = false;

            }
        }
    }
}
