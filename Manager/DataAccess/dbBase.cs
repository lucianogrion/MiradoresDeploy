using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;


namespace Manager.DataAccess
{
    public class dbBase
    {
        internal Database _db;

        public dbBase()
        {
            _db = DatabaseFactory.CreateDatabase("ConnectionString");
        }

    }
}
