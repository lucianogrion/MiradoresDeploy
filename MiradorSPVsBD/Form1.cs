using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Manager;

namespace MiradorSPVsBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void cmdProcesarCarpeta_Click(object sender, EventArgs e)
        {

            List<UnNombre> listadoCs = new List<UnNombre>();
            List<UnNombre> listadoAcumulador = new List<UnNombre>();

            try
            {
                if (txtCarpeta.Text.Length == 0)
                {
                    throw new Exception("No se ha seleccionada Carpeta");
                }
                UtilidadesConfig util = new UtilidadesConfig();
                listadoAcumulador = util.WalkDirectoryTreeSQL(txtCarpeta.Text);


            }
            catch (Exception ex)
            {
                lblEstado.Text = ex.Message;
            }

            griSQL.DataSource = listadoAcumulador;
            griSQL.Refresh();
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

                lblEstado.Text = ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}