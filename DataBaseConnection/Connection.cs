using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnection
{
    public static class Connection
    {
        public static SqlConnection ConnectionData()
        {
           return  new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moc\Documents\LocadoraDB.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
