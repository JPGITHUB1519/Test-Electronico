using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Utilidades
{
    public class utilidades
    {

        public static DataSet ejecuta(string comando)
        {
            DataSet ds = new DataSet();

            try
            {
                // conectar
                SqlConnection con = new SqlConnection(Properties.Settings.Default.cn);
                con.Open();

                /*
                //ejecutar comando
                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.ExecuteNonQuery();
                */

                //adaptar datos
                SqlDataAdapter da = new SqlDataAdapter(comando, con);
                da.Fill(ds);


            }
            catch (Exception ex)
            {

                //MessageBox.Show("Error! : " + ex.ToString());

            }

            return ds;

        }

       
        /// Encripta una cadena
        public static string encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string desencriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        public static void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "TEST ELECTRONICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "TEST ELECTRONICO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ocultarcolumnas(DataGridView datalistado)
        {
            datalistado.Columns[0].Visible = false;
        }


        public static bool validar(Control frm, ErrorProvider errorp)
        {
            bool cond = false;


            foreach (Control obj in frm.Controls)
            {
                if (obj.Controls.Count > 0)
                {
                    cond = validar(obj, errorp);
                }
                else
                {
                    if (obj is textbox)
                    {
                        textbox obj2 = (textbox)obj;

                        if (obj2.validar)
                        {
                            //en una linea
                            //puedo poner tambien obj2
                            //errorp.SetError(obj2, (string.IsNullOrEmpty(obj.Text.Trim()) == true) ? "Campo Obligatorio" : "");

                            // otra forma
                            if (String.IsNullOrEmpty(obj2.Text.Trim()))
                            {
                                errorp.SetError(obj, "Campo obligatorio");
                                cond = true;
                            }

                            else
                            {
                                errorp.SetError(obj, "");
                            }



                        }
                    }


                }
            }

            return cond;
        }

        public static int numero_aleatorios(int min, int max)
        {
           
            // random next(min, max -1)
            Random r = new Random();

            int num = r.Next(min, max + 1);

            return num;
        }

        public static List<int> generar_preguntas()
        {
            /* retorna una lista con el indice de las preguntas aleatorias"*/

            List<int> preguntas = new List<int>();

            DataSet ds = new DataSet();
            string cmd = "select * from preguntas";
            ds = ejecuta(cmd);
            int max = ds.Tables[0].Rows.Count;


            int cont = 0;
            //int cant_preguntas = 5;
            int cant_preguntas = 3;
            int n;

            while (cont < cant_preguntas)
            {
                n = numero_aleatorios(1, max);

                // si no existe agregalo
                if (preguntas.IndexOf(n) == -1)
                {
                    preguntas.Add(n);
                    cont = cont + 1;

                }
                else
                {
                    continue;

                }

            }
            return preguntas;

        }

        public static List<int> generar_respuestas(int max)
        {
            /* retorna una lista con el indice de las respuestas aleatorias"*/
            List<int>respuestas = new List<int>();
            int cont = 0;
            int cant_preguntas = 4;
            int n;

            while (cont < cant_preguntas)
            {
                n = numero_aleatorios(0, max - 1);

                // si no existe agregalo
                if (respuestas.IndexOf(n) == -1)
                {
                    respuestas.Add(n);
                    cont = cont + 1;

                }
                else
                {
                    continue;

                }

            }
            return respuestas;

        }


        // list like a quue
        public static int pop(List<int> preguntas)
        {
            int tam = preguntas.Count;
            int aux = preguntas[tam - 1];
            preguntas.RemoveAt(tam - 1);

            return aux;
        }

       

    }
}
