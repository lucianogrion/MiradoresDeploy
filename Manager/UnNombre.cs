using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    public class UnNombre
    {
        public UnNombre(string k)
        {
            nombre = k;
            
        }
        public UnNombre()
        {
            nombre = string.Empty;

        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private const string sp1 = ".ExecuteNonQuery(";
        private const string sp2 = ".ExecuteScalar(";
        private const string sp3 = ".ExecuteReader(";
        private const string sp4 = ".Execute(";
        private const string sp5 = ".ExecuteDataset(";

        internal static UnNombre ObtenerDATALineaCS(string lineaCs)
        {
            UnNombre clave = new UnNombre();

            int conf1 = lineaCs.IndexOf(sp1);
            int conf2 = lineaCs.IndexOf(sp2);
            int conf3 = lineaCs.IndexOf(sp3);
            int conf4 = lineaCs.IndexOf(sp4);
            int conf5 = lineaCs.IndexOf(sp5);

            if ((conf1 != -1) || (conf2 != -1) || (conf3 != -1) || (conf4 != -1) || (conf5 != -1))
            {
                int first = lineaCs.IndexOf("\"");
                int last = lineaCs.IndexOf("\",");
                if (last==-1)
                {
                    last = lineaCs.IndexOf("\")");
                }

                if ((first == -1) || (last == -1))
                {
                    first = 0;
                    last = lineaCs.Length;
                }

                string strclave = lineaCs.Substring(first + 1, last - first - 1);
                clave.Nombre = strclave;
            }

            return clave;
        }
    }
}
