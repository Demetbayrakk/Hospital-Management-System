using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace HospitalManagementSystem
{
    class SqlBaglanti
    {
        public static SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("SERVER=LAPTOP-9U5K7JLD\\SQLEXPRESS; DATABASE=Hospital; Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
