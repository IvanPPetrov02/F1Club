using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IConnection
    {
        public static string GetConnectionString()
        {
            string DBString = "Server=studmysql01.fhict.local;Uid=dbi481790;Database=dbi481790;Pwd=Password;Allow User Variables=True";
            return DBString;
        }

    }
}
