using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using MiradorCS.Manager;
using Manager;

namespace MiradorCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCarpeta_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtCarpeta.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                
                lblEstado.Text= ex.Message;
            }
        }

        private void cmdConfig_Click(object sender, EventArgs e)
        {
            try
            {
                Stream myStream = null;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "config files (*.config)|*.config";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                            txtConfig.Text = openFileDialog1.FileName.ToString();
                            UtilidadesConfig util = new UtilidadesConfig();
                            List<ClaveConfig> listadoClaves = util.ObtenerConfigs(txtConfig.Text);
                            griConfig.DataSource = listadoClaves;
                            griConfig.Refresh();

                        }
                    }
                    catch (Exception ex)
                    {
                         lblEstado.Text = "Error: Could not read file from disk. Original error: " + ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                lblEstado.Text = ex.Message;
            }

        }

        

        private void cmdCotejar_Click(object sender, EventArgs e)
        {
            List<ClaveConfig> listadoCs =(List<ClaveConfig>) griCs.DataSource;
            List<ClaveConfig> listadoConfig = (List<ClaveConfig>)griConfig.DataSource;
          

            List<ClaveConfig> listadoCotejar = new List<ClaveConfig>() ;

            UtilidadesConfig util = new UtilidadesConfig();
            listadoCotejar = util.Cotejar(listadoCs, listadoConfig);

            griCotejar.DataSource = listadoCotejar;
            griCotejar.Refresh();

        }

        //Buscar clave en Cs
        //Recibe un cs y devuelve array de textos
        private void cmdProcesarCarpeta_Click(object sender, EventArgs e)
        {

            List<ClaveConfig> listadoCs = new List<ClaveConfig>();
            List<ClaveConfig> listadoAcumulador = new List<ClaveConfig>();

            try
            {
                if (txtCarpeta.Text.Length == 0)
                {
                    throw new Exception("No se ha seleccionada Carpeta");
                }
                UtilidadesConfig util = new UtilidadesConfig();
                listadoAcumulador = util.WalkDirectoryTreeCs(txtCarpeta.Text);


            }
            catch (Exception ex)
            {
                lblEstado.Text = ex.Message;
            }

            griCs.DataSource = listadoAcumulador;
            griCs.Refresh();

        }
       
    }
}