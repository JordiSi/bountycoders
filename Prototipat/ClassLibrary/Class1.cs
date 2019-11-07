using System;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class Class1
    {
        private SqlConnection conn;
        private string cnx;

        public void queryCNX()
        {
            cnx = "Server = bountycoders.database.windows.net; Database = BountyCoders; User Id = bountycoders; Password = 123456aA;";
            conn = new SqlConnection(cnx);
            SqlDataAdapter adapter;
            String query;
            query = "select * from Users";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();
            DataSet dts = new DataSet();
            adapter.Fill(dts);

            conn.Close();
            dtgUsers.DataSource = dts.Tables[0];
        }
    }
}
