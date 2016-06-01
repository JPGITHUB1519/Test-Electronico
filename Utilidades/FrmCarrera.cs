using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilidades;

namespace Utilidades
{
    public partial class FrmCarrera : Form
    {
        public FrmCarrera()
        {
            InitializeComponent();
        }

        public void nuevo()
        {
            txtidcarrera.Text = string.Empty;
            txtnombre.Text = string.Empty;
        }

        private void mostrar()
        {
            DataSet ds;

            string cmd = "EXEC spmostrar_carrera";
            ds = utilidades.ejecuta(cmd);
            this.dataListado.DataSource = ds.Tables[0];

            lblTotal.Text = "Total de Registros : " + Convert.ToString(dataListado.Rows.Count);
        }

        private void eliminar()
        {
            DataSet ds = new DataSet();

            string cmd = string.Format("EXEC speliminar_carrera '{0}'", txtidcarrera.Text.Trim());

            ds = utilidades.ejecuta(cmd);

            this.nuevo();
            this.mostrar();
            this.txtidcarrera.Focus();
        }

        private void salvar()
        {
            if (utilidades.validar(this, errorProvider1) == true)
            {
                return;
            }


            string cmd = string.Format("EXEC SPACTCARRERA '{0}','{1}'", txtidcarrera.Text.Trim(), txtnombre.Text.Trim());


            DataSet ds = utilidades.ejecuta(cmd);

            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                utilidades.mensajeerror("Error Guardando los datos");


                return;
            }

            this.mostrar();
            this.nuevo();
            this.txtidcarrera.Focus();
        }

        private void buscar_nombre()
        {
            DataSet ds;

            string cmd = string.Format("EXEC spbuscar_carrera_nombre '{0}'", txtbuscar.Text.Trim());
            ds = utilidades.ejecuta(cmd);
            this.dataListado.DataSource = ds.Tables[0];
            utilidades.ocultarcolumnas(dataListado);
            lblTotal.Text = "Total de Registros : " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.salvar();
           
        }

        private void btneliminar2_Click(object sender, EventArgs e)
        {
            this.eliminar();
            
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            nuevo();
            this.txtidcarrera.Focus();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCarrera_Load(object sender, EventArgs e)
        {
            utilidades.ocultarcolumnas(dataListado);
            this.mostrar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscar_nombre();
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

            this.txtidcarrera.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idcarrera"].Value);
            this.txtnombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre_carrera"].Value);
            // cambiar al otro tabpage

            this.tabControl1.SelectedIndex = 1;
            this.txtidcarrera.Focus();
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
                                cmd = string.Format("EXEC SPELIMINAR_CARRERA '{0}'", codigo);

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

        private void txtidcarrera_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtidcarrera.Text.Trim()))

                return;
            string cmd = string.Format("select * from carrera where idcarrera = '{0}'", txtidcarrera.Text.Trim());

            DataSet ds = utilidades.ejecuta(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtidcarrera.Text = ds.Tables[0].Rows[0]["idcarrera"].ToString();
                txtnombre.Text = ds.Tables[0].Rows[0]["nombre_carrera"].ToString();

            }
            else
            {
               
                txtnombre.Text = string.Empty;
 
            }
        }
    }
}
