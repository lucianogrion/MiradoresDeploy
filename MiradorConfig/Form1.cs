using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MiradorCS.Manager;
using Manager;

namespace MiradorConfig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void griCs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdConfigOrigen_Click(object sender, EventArgs e)
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
                            txtConfigOrigen.Text = openFileDialog1.FileName.ToString();
                            UtilidadesConfig util = new UtilidadesConfig();
                            List<ClaveConfig> listadoClaves = util.ObtenerConfigs(txtConfigOrigen.Text);
                            griConfigOrigen.DataSource = listadoClaves;
                            griConfigOrigen.Refresh();

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdConfigDestino_Click(object sender, EventArgs e)
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
                            txtConfigDestino.Text = openFileDialog1.FileName.ToString();
                            UtilidadesConfig util = new UtilidadesConfig();
                            List<ClaveConfig> listadoClaves = util.ObtenerConfigs(txtConfigDestino.Text);
                            griConfigDestino.DataSource = listadoClaves;
                            griConfigDestino.Refresh();

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
            List<ClaveConfig> listadoDestino = (List<ClaveConfig>)griConfigOrigen.DataSource;
            List<ClaveConfig> listadoOrigen = (List<ClaveConfig>)griConfigDestino.DataSource;


            List<ClaveConfig> listadoCotejar = new List<ClaveConfig>();

            UtilidadesConfig util = new UtilidadesConfig();
            listadoCotejar = util.Cotejar(listadoOrigen, listadoDestino);

            griCotejar.DataSource = listadoCotejar;
            griCotejar.Refresh();
        }
    }
}