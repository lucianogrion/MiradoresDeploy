using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Manager.DataAccess
{
    public class dbSPs : dbBase
    {
        public String ObtenerTextoSp(String NombreSp)
        {
            return _db.ExecuteScalar(@"sp_HelpText",
                  NombreSp
                 ).ToString();
        }

        public String ObtenerConexion()
        {
            return _db.ConnectionStringWithoutCredentials.ToString();
        }



        public String ObtenerTabla()
        {
            return _db.CreateConnection().DataSource.ToString();
        }

        internal bool ExisteSp(string NombreSp)
        {
            String texto = "";
            bool rta= false;
            try
            {
                using (SqlDataReader dr = (SqlDataReader)_db.ExecuteReader("SELECT * FROM sys.objects WHERE  type='P' and name='"+ NombreSp + "'"))
                {
                    while (dr.Read())
                    {
                        texto = texto + dr[0].ToString();
                    }
                }
                rta = (texto != string.Empty);
            }
            catch (Exception Ex)
            {
                //throw Ex;
                rta = false;
            }
           
            return (rta);
        }
    }
}
