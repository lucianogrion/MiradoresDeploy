using System;
using System.Collections.Generic;
using System.Text;
using MiradorCS.Manager;
using System.Xml;
using System.IO;
using Manager.DataAccess;
using System.Reflection;

namespace Manager
{
    public class UtilidadesConfig
    {

        
        

        public List<ClaveConfig> ObtenerConfigs(string rutaxml)
        {
            List<ClaveConfig> listadoClaves = new List<ClaveConfig>();
            //ClaveConfig clave = new ClaveConfig();

            
                XmlDocument xDoc = new XmlDocument();

                xDoc.Load(rutaxml);
                XmlNodeList appSettings = xDoc.GetElementsByTagName("appSettings");
                XmlNodeList lista = ((XmlElement)appSettings[0]).GetElementsByTagName("add");
                foreach (XmlElement nodo in lista)
                {
                    //int i=0;
                    String nKey = nodo.GetAttribute("key").ToString();
                    String nValue = nodo.GetAttribute("value").ToString();

                    Console.WriteLine("Elemento nombre {0} Valor {1}",
                        nKey,
                        nValue);

                    listadoClaves.Add(new ClaveConfig(nKey, nValue));
                }
            

            return listadoClaves;
        }

        

        public List<ClaveConfig> WalkDirectoryTreeCs(string p)
        {
            List<ClaveConfig> listadoCs = new List<ClaveConfig>();
            List<ClaveConfig> listadoAcumulador = new List<ClaveConfig>();

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(p);

            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder
            files = di.GetFiles("*.cs");

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    //Console.WriteLine(fi.FullName);
                    listadoCs = BuscarListConfigs(fi.FullName);
                    listadoAcumulador = Acumularclaves(listadoAcumulador, listadoCs);
                }


                // Now find all the subdirectories under this directory.
                subDirs = di.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    listadoCs = WalkDirectoryTreeCs(dirInfo.FullName);
                    listadoAcumulador = Acumularclaves(listadoAcumulador, listadoCs);
                }

            }

            return listadoAcumulador;
        }


        public List<UnNombre> WalkDirectoryTreeSQL(string p)
        {
            List<UnNombre> listadoCs = new List<UnNombre>();
            List<UnNombre> listadoAcumulador = new List<UnNombre>();

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(p);

            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder
            files = di.GetFiles("*.sql");

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    listadoAcumulador.Add(ObtenerNombreSQL(fi.FullName));
                }


                // Now find all the subdirectories under this directory.
                subDirs = di.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    listadoCs = WalkDirectoryTreeSQL(dirInfo.FullName);
                    listadoAcumulador = AcumularLista(listadoAcumulador, listadoCs);
                }

            }

            return listadoAcumulador;
        }

        private List<UnNombre> AcumularLista(List<UnNombre> listadoAcumulador, List<UnNombre> listadoCs)
        {
            foreach (UnNombre item in listadoCs)
            {
                listadoAcumulador.Add(item);
            }
            return listadoAcumulador;
        }

        private UnNombre ObtenerNombreSQL(string p)
        {
            System.IO.FileInfo file = new FileInfo(p);
            UnNombre archivito = new UnNombre();
            archivito.Nombre = file.Name.ToString();
            return archivito;
        }


        private List<ClaveConfig> BuscarListConfigs(string filename)
        {
            List<ClaveConfig> lista = new List<ClaveConfig>();

            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader(filename))
            {
                String line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    //Buscar en la linea el valor
                    ClaveConfig clave = new ClaveConfig();
                    clave = ClaveConfig.ObtenerConfigLineaCS(line);
                    if (clave.Key != string.Empty)
                    {
                        lista.Add(new ClaveConfig(clave.Key, clave.Valor));
                    }

                }
            }

            return lista;
        }


        public List<ClaveConfig> Acumularclaves(List<ClaveConfig> listadoAcumulador, List<ClaveConfig> listadoCs)
        {
            bool encontrado = false;
            foreach (ClaveConfig item in listadoCs)
            {
                //Buscar si la clave existe
                foreach (ClaveConfig itemAcum in listadoAcumulador)
                {
                    if (itemAcum.Key == item.Key)
                    {
                        encontrado = true;
                        break;
                    }
                }
                //int busqueda = listadoAcumulador.( new ClaveConfig(item.Key, item.Valor));
                if (!encontrado)
                {
                    listadoAcumulador.Add(new ClaveConfig(item.Key, item.Valor));
                }

            }

            return listadoAcumulador;
        }

        public List<ClaveConfig> Cotejar(List<ClaveConfig> listadoOrigen, List<ClaveConfig> listadoDestino)
        {
            //List<ClaveConfig> listadoCs = (List<ClaveConfig>)griCs.DataSource;
            //List<ClaveConfig> listadoConfig = (List<ClaveConfig>)griConfig.DataSource;

            if (listadoOrigen == null)
            {
                listadoOrigen = new List<ClaveConfig>();
            }

            if (listadoDestino == null)
            {
                listadoDestino = new List<ClaveConfig>();
            }

            

            bool encontrado = false;

            List<ClaveConfig> listadoCotejar = new List<ClaveConfig>();

            foreach (ClaveConfig itemCs in listadoOrigen)
            {
                encontrado = false;
                foreach (ClaveConfig itemConfig in listadoDestino)
                {
                    if (itemCs.Key == itemConfig.Key)
                    {
                        encontrado = true;
                        break;
                    }
                }
                //int busqueda = listadoAcumulador.( new ClaveConfig(item.Key, item.Valor));
                if (!encontrado)
                {
                    listadoCotejar.Add(new ClaveConfig(itemCs.Key, itemCs.Valor));

                }
            }
            return listadoCotejar;
            //griCotejar.DataSource = listadoCotejar;
            //griCotejar.Refresh();

        }


        public List<UnNombre> WalkDirectoryTreeCsDATA(string p)
        {
            List<UnNombre> listadoCs           = new List<UnNombre>();
            List<UnNombre> listadoAcumulador   = new List<UnNombre>();

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(p);

            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder
            files = di.GetFiles("*.cs");

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    //Console.WriteLine(fi.FullName);
                    listadoCs = BuscarListDATA(fi.FullName);
                    listadoAcumulador = AcumularLista(listadoAcumulador, listadoCs);
                }


                // Now find all the subdirectories under this directory.
                subDirs = di.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    listadoCs = WalkDirectoryTreeCsDATA(dirInfo.FullName);
                    listadoAcumulador = AcumularLista(listadoAcumulador, listadoCs);
                }

            }

            return listadoAcumulador;
        }

        private List<UnNombre> BuscarListDATA(string filename)
        {
            List<UnNombre> lista = new List<UnNombre>();

            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader(filename))
            {
                String line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    //Buscar en la linea el valor
                    UnNombre nombre = new UnNombre();
                    nombre = UnNombre.ObtenerDATALineaCS(line);
                    if (nombre.Nombre != string.Empty)
                    {
                        lista.Add(new UnNombre(nombre.Nombre));
                    }

                }
            }

            return lista;
        }

        public List<UnNombre> CotejarData(List<UnNombre> listadoCs)
        {
            if (listadoCs == null)
            {
                listadoCs = new List<UnNombre>();
            }


            bool encontrado = false;

            List<UnNombre> listadoCotejar = new List<UnNombre>();
            dbSPs data = new dbSPs();

            foreach (UnNombre itemCs in listadoCs)
            {
                encontrado = false;
                encontrado = data.ExisteSp(itemCs.Nombre);
                if (!encontrado)
                {
                    listadoCotejar.Add(new UnNombre(itemCs.Nombre));
                }
            }
            return listadoCotejar;
        }

        
    }
}
