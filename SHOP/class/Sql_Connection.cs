using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SHOP
{
    class Sql_Connection
    {
        public SqlConnection connection() 
        {
            //Data Source=Data Source='SQL KULLANICI ADINIZ';Initial Catalog=Urun_Tarih_Takibi;Integrated Security=True
            SqlConnection connect = new SqlConnection(@"Data Source=ALI;Initial Catalog=Urun_Tarih_Takibi;Integrated Security=True");
            connect.Open();
            return connect;
            // https://github.com/alii76tt
        }
    }
}
