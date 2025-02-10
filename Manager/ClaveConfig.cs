using System;
using System.Collections.Generic;
using System.Text;

namespace MiradorCS.Manager
{
    public class ClaveConfig
    {

        public ClaveConfig()
        {
            key = string.Empty;
            valor = string.Empty;
        }

        public ClaveConfig(string k, string v)
        {
            key = k;
            valor = v;
        }

        public static ClaveConfig ObtenerConfigLineaCS(string lineaCs)
        {
            ClaveConfig clave = new ClaveConfig();

            int conf1 = lineaCs.IndexOf(config1);

            if (conf1 != -1)
            {
                int first = lineaCs.IndexOf("[\"");
                int last = lineaCs.IndexOf("\"]");
                string strclave = lineaCs.Substring(first + 2, last - first - 2);
                clave.Key = strclave;

                //int firstv = lineaCs.IndexOf("=\"");
                //int lastv = lineaCs.LastIndexOf("\";");
                //string strValor = lineaCs.Substring(first + 2, last - first - 2);
                string strValor = string.Empty;

                clave.valor = strValor;
            }

            return clave;
        }

        private const string config1 = "ConfigurationManager.AppSettings[";
       

        private string key;

        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        private string valor;

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }


       
    }
}
