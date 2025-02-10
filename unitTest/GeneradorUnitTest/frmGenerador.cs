using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Reflection;
using System.IO;

namespace GeneradorUnitTest
{
    public partial class frmGenerador : Form
    {
        public frmGenerador()
        {
            InitializeComponent();
        }

        private void cmdCarpeta_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter= "Code Files|*.dll";
                openFileDialog1.Title = "Select a CODE File";


                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtCarpeta.Text =openFileDialog1.FileName.ToString();
                }
            }
            catch (Exception ex)
            {

                lblEstado.Text = ex.Message;
            }
        }

        private void cmdProcesarCarpeta_Click(object sender, EventArgs e)
        {
            String strResultado="";
            //try
            //{
                if (txtCarpeta.Text.Length == 0)
                {
                    throw new Exception("No se ha seleccionada Carpeta");
                }

                 //UtilidadesConfig util = new UtilidadesConfig();
                 strResultado = ObtenerMetodos(txtCarpeta.Text);


            //}
            //catch (Exception ex)
            //{
            //    lblEstado.Text = ex.Message;
            //}

            txtResult.Text = strResultado;
            
        }

        public static string ObtenerMetodos(string p)
        {
            string result = "";
            Assembly a = Assembly.LoadFile(p);
            Type[] mytypes = a.GetTypes();
            //BindingFlags flags = (BindingFlags.NonPublic | BindingFlags.Public |
            //    BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            BindingFlags flags = (BindingFlags.NonPublic | BindingFlags.Public |
                BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly);


            foreach (Type t in mytypes)
            {
                MethodInfo[] mi = t.GetMethods(flags);
                //try
                //{
                //    Object obj = Activator.CreateInstance(t);
                //}
                //catch (Exception)
                //{
                //    break;
                //}

                foreach (MethodInfo m in mi)
                {
                    // Instead of invoking the methods,
                    // it's safer to initially just list them.
                  
                        Console.WriteLine(m);
                        result = result + m.ToString() + "\r\n";
                   
                    
                }
            }
            return result;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Code Files|*.cs";
                openFileDialog1.Title = "Select a CODE File";


                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtCs.Text = openFileDialog1.FileName.ToString();
                }
            }
            catch (Exception ex)
            {

                lblEstado.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                Stream myStream = null;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "config files (*.cs)|*.cs";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                            txtCs.Text = openFileDialog1.FileName.ToString();

                            txtResult.Text = ObtenerPublic(txtCs.Text);
                           

                        }
                    }
                    catch (Exception ex)
                    {
                        lblEstado.Text = "Error: Could not read file from disk. Original error: " + ex.Message;
                    }
                }
            //}
            //catch (Exception ex)
            //{
            //    lblEstado.Text = ex.Message;
            //}
        }

        private string ObtenerPublic(string filename)
        {
            string result = "";
            string firma ="";
             string linea= "";
            using (StreamReader sr = new StreamReader(filename))
            {
                String line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    //Buscar en la linea el valor
                   
                    firma= ObtenerDATALineaCS(line);
                    if (firma != string.Empty)
                    {
                        
                    //public void TestTrue()
                    //{
                    //    Assert.IsTrue(true);
                    //}
                        //string strnombre = obtenerNombre(firma);
                        linea = "";
                        linea = linea + " [Test]\r\n";
                        linea = linea + "public void TestTrue() \r\n";
                        linea = linea + "{ \r\n";
                        linea = linea + "     /* ACA VA EL TEST!!! */  \r\n";
                        linea = linea + "    " + firma + "\r\n";
                        linea = linea + "    Assert.IsTrue(true);";
                        linea = linea + "} \r\n\r\n";
                    }
                    result = result + linea;

                }
            }
            return result;

        }

        //private string obtenerNombre(string firma)
        //{
        //    //string nombre="";

        //    //int first = firma.IndexOf("public");
        //    //int last = firma.IndexOf("(");
        //    //if (last == -1)
        //    //{
        //    //    last = firma.IndexOf("\")");
        //    //}

        //    //if ((first == -1) || (last == -1))
        //    //{
        //    //    first = 0;
        //    //    last = firma.Length;
        //    //}

        //    //nombre = firma.Substring(first,  last);
        //    //return nombre;
        //}

        private const string sp1 = "public";
        private const string sp2 = "private";
        private const string sp3 = "protected";
        private const string sp4 = "TODO";
        private const string sp5 = "static";


        private String ObtenerDATALineaCS(string lineaCs)
        {
            int conf1 = lineaCs.IndexOf(sp1);
            int conf2 = lineaCs.IndexOf(sp2);
            int conf3 = lineaCs.IndexOf(sp3);
            int conf4 = lineaCs.IndexOf(sp4);
            int conf5 = lineaCs.IndexOf(sp5);
            string strclave ="";

            if ((conf1 != -1) || (conf2 != -1) || (conf3 != -1) || (conf4 != -1) || (conf5 != -1))
            {
                //int first = lineaCs.IndexOf("\"");
                //int last = lineaCs.IndexOf("\",");
                //if (last == -1)
                //{
                //    last = lineaCs.IndexOf("\")");
                //}

                //if ((first == -1) || (last == -1))
                //{
                //    first = 0;
                //    last = lineaCs.Length;
                //}

                strclave = lineaCs;
            }

            return strclave;
        }


    }
}
