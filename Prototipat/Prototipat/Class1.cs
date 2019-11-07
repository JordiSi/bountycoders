using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Prototipat
{
    class Class1
    {
        private string cnx;
        public DataSet LoadCNX(string query)
        {
            cnx = "Server = bountycoders.database.windows.net; Database = BountyCoders; User Id = bountycoders; Password = 123456aA;";

            DataSet dts = new DataSet();

            SqlConnection conn = new SqlConnection(cnx);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(dts);

            conn.Close();
            return dts;

            //conn.Open();
            //SqlCommandBuilder cmdBuilder;
            //cmdBuilder = new SqlCommandBuilder(adapter);

            //if (dts.Tables[0].hasChanges)
            //{
            //    result = adapter.Update(dts.Tables[0]);
            //}
            //conn.Close();
        }
    }
}
