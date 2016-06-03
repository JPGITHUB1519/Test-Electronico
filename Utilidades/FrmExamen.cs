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
    public partial class FrmExamen : Form
    {
        public string matricula;
        public List<int> preguntas = new List<int> ();
        public List<int> respuestas = new List<int>();
        public List<string> respuestas_correcta = new List<string>();
        public int pregunta_actual;
        public DataSet ds;
        public int last_element_list;
        public DataSet ds_respuestas;
        public DataSet ds_respuestas_correctas;
        public int calificacion;
        public char calificacion_letra;



        public void make_respuestas()
        {
            string cmd = string.Format("select * from respuestas where idpregunta = '{0}'", this.last_element_list);
            this.ds_respuestas = utilidades.ejecuta(cmd);
            int max = ds_respuestas.Tables[0].Rows.Count;
            this.respuestas = utilidades.generar_respuestas(max);

            this.rbresp1.Text = this.ds_respuestas.Tables[0].Rows[this.respuestas[0]]["respuesta"].ToString();
            this.rbresp2.Text = this.ds_respuestas.Tables[0].Rows[this.respuestas[1]]["respuesta"].ToString();
            this.rbresp3.Text = this.ds_respuestas.Tables[0].Rows[this.respuestas[2]]["respuesta"].ToString();
            this.rbresp4.Text = this.ds_respuestas.Tables[0].Rows[this.respuestas[3]]["respuesta"].ToString();

            cmd = string.Format("select * from respuestas where idpregunta = '{0}' and iscorrect = 1", this.last_element_list);
            this.ds_respuestas_correctas = new DataSet();
            this.ds_respuestas_correctas = utilidades.ejecuta(cmd);
            string texto;

            for (int i = 0; i < ds_respuestas_correctas.Tables[0].Rows.Count; i++)
            {
                texto = this.ds_respuestas_correctas.Tables[0].Rows[i]["respuesta"].ToString();
                lblresp.Text+= "\n" + texto;
                respuestas_correcta.Add(texto);

            }


        }

        public void make_preguntas()
        {
            this.last_element_list = utilidades.pop(preguntas);
            string cmd = string.Format("select * from preguntas where idpregunta = '{0}'", this.last_element_list);
            this.ds = utilidades.ejecuta(cmd);
            this.lblpregunta.Text = ds.Tables[0].Rows[0]["pregunta"].ToString();

        }
        public FrmExamen(string ch_matricula)
        {
            InitializeComponent();
            this.matricula = ch_matricula;
            this.calificacion = 0;
            this.preguntas = utilidades.generar_preguntas();
            lblprueba.Text = "";
            
            //prueba
            foreach (int i in preguntas)
            {
                lblprueba.Text += i.ToString();

            }

            make_preguntas();

            make_respuestas();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // mientras las preguntas no se acabem seguir preguntando
            if (this.preguntas.Count != 0)
            {
                string aux = "Calificiacion : ";
                if (rbresp1.Checked == true)
                {
                    if(respuestas_correcta.Contains(rbresp1.Text))
                    {
                       
                        this.calificacion = this.calificacion + 5;
                        lblcalificacion.Text = aux +  Convert.ToString(this.calificacion);
                    }

                }

                if (rbresp2.Checked == true)
                {

                    if (respuestas_correcta.Contains(rbresp2.Text))
                    {

                        this.calificacion = this.calificacion + 5;
                        lblcalificacion.Text = aux + Convert.ToString(this.calificacion);
                    }

                }

                if (rbresp3.Checked == true)
                {

                    if (respuestas_correcta.Contains(rbresp3.Text))
                    {

                        this.calificacion = this.calificacion + 5;
                        lblcalificacion.Text = aux + Convert.ToString(this.calificacion);
                    }

                }

                if (rbresp4.Checked == true)
                {

                    if (respuestas_correcta.Contains(rbresp4.Text))
                    {

                        this.calificacion = this.calificacion + 5;
                        lblcalificacion.Text = aux + Convert.ToString(this.calificacion);
                    }

                }


                make_preguntas();
                make_respuestas();
                
            }
            else
            {
   
                // guardar examen en la base de datos

                
                DataSet ds = new DataSet();
                this.calificacion_letra = utilidades.calificacion_letra(this.calificacion);
                string cmd = string.Format("exec SPACTEXAMEN '{0}', '{1}', '{2}'", this.matricula, this.calificacion, this.calificacion_letra);
                ds = utilidades.ejecuta(cmd);
                
                MessageBox.Show("El examen ha Termininado");
                // generar reporte


                cmd = string.Format("EXEC sptodos_datos_examen {0}", this.matricula);
                ds = utilidades.ejecuta(cmd);

                FrmReportes frmreporte = new FrmReportes(ds, "Utilidades.ReporteExamen.rdlc");
                frmreporte.Show();
 


                this.Hide();
                frmreporte.Show();



            }
        }

        private void FrmExamen_Load(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
