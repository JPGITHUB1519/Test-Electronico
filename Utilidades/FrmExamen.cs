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
        public List<int> preguntas = new List<int> ();
        public List<int> respuestas = new List<int>();
        public int pregunta_actual;
        public DataSet ds;
        public int last_element_list;
        public DataSet ds_respuestas;

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
 
        }
        public FrmExamen()
        {
            InitializeComponent();
            
            this.preguntas = utilidades.generar_preguntas();
            lblprueba.Text = "";

            
            //prueba
            foreach (int i in preguntas)
            {
                lblprueba.Text += i.ToString();

            }

            if (this.preguntas.Count > 0)
                this.last_element_list = utilidades.pop(preguntas);

            string cmd = string.Format("select * from preguntas where idpregunta = '{0}'", this.last_element_list);
            this.ds = utilidades.ejecuta(cmd);

            // buscar respuesta a pregunta
            /*
            cmd = string.Format("select * from respuestas where idpregunta = '{0}'", this.last_element_list);
            this.ds_respuestas = utilidades.ejecuta(cmd);
            int max = ds_respuestas.Tables[0].Rows.Count;
            this.respuestas = utilidades.generar_respuestas(max);
           */
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
                // generar siguiente pregunta
                this.last_element_list = utilidades.pop(preguntas);
                string cmd = string.Format("select * from preguntas where idpregunta = '{0}'", this.last_element_list);
                this.ds = utilidades.ejecuta(cmd);
                this.lblpregunta.Text = ds.Tables[0].Rows[0]["pregunta"].ToString();
               
              
                // generar siguiente respuesta

                make_respuestas();
                /*
                 
                cmd = string.Format("select * from respuestas where idpregunta = '{0}'", this.last_element_list);
                this.ds_respuestas = utilidades.ejecuta(cmd);
                int max = ds_respuestas.Tables[0].Rows.Count;
                this.respuestas = utilidades.generar_respuestas(max);
                
                this.rbresp1.Text = this.ds_respuestas.Tables[0].Rows[this.respuestas[0]]["respuesta"].ToString();
                this.rbresp2.Text = this.ds_respuestas.Tables[0].Rows[this.respuestas[1]]["respuesta"].ToString();
                this.rbresp3.Text = this.ds_respuestas.Tables[0].Rows[this.respuestas[2]]["respuesta"].ToString();
                this.rbresp4.Text = this.ds_respuestas.Tables[0].Rows[this.respuestas[3]]["respuesta"].ToString();
                
                */
            }
            else
            {
                MessageBox.Show("Termino");
            }
        }

        private void FrmExamen_Load(object sender, EventArgs e)
        {
            

            this.lblpregunta.Text = ds.Tables[0].Rows[0]["pregunta"].ToString();
         
            /*
            this.rbresp1.Text = this.ds_respuestas.Tables[0].Rows[this.respuestas[0]]["respuesta"].ToString();
            this.rbresp2.Text = this.ds_respuestas.Tables[0].Rows[this.respuestas[1]]["respuesta"].ToString();
            this.rbresp3.Text = this.ds_respuestas.Tables[0].Rows[this.respuestas[2]]["respuesta"].ToString();
            this.rbresp4.Text = this.ds_respuestas.Tables[0].Rows[this.respuestas[3]]["respuesta"].ToString();
            */
        }
    }
}
