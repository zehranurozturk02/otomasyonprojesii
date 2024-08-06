using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace otomasyonprojesii
{
   
    public class sqlbağlantım
    {

        public SqlConnection bağlantı()
        {
            SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-7HBVF7V\\SQLEXPRESS04;Initial Catalog=yurtkayıt;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            bağlantı.Open();
            return bağlantı;
        }

    }
}
