using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Manager.DataAccess;
using Manager;

namespace MiradorDACCESvsSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            dbSPs data = new dbSPs();
            txtConectionString.Text = data.ObtenerConexion();
        }

        private void cmdConectar_Click(object sender, EventArgs e)
        {
            dbSPs data = new dbSPs();

            List<UnNombre> lista= new List<UnNombre>();
            UnNombre arch= new UnNombre();
            arch.Nombre = data.ObtenerTabla();
            lista.Add(arch);

            griDB.DataSource = lista;

            griDB.Refresh();


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
                listadoAcumulador = util.WalkDirectoryTreeCsDATA(txtCarpeta.Text);


            }
            catch (Exception ex)
            {
                lblEstado.Text = ex.Message;
            }

            griDATA.DataSource = listadoAcumulador;
            griDATA.Refresh();
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

        private void cmdCotejar_Click(object sender, EventArgs e)
        {
           try
            {
            List<UnNombre> listadoCs = (List<UnNombre>)griDATA.DataSource;

            List<UnNombre> listadoCotejar = new List<UnNombre>();

            UtilidadesConfig util = new UtilidadesConfig();
            listadoCotejar = util.CotejarData(listadoCs);

            griCotejar.DataSource = listadoCotejar;
            griCotejar.Refresh();
        }
        catch (Exception ex)
        {

            lblEstado.Text = ex.Message;
        }
        }
    }
}