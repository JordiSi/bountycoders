using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Data.Common;

namespace Dades
{
    public class Class1
    {
        private SqlDataAdapter adapter;
        private SqlConnection conn;

        public void Connectar()
        {
            string cnx = "Server = bountycoders.database.windows.net; Database = BountyCoders; User Id = bountycoders; Password = 123456aA;";
            conn = new SqlConnection(cnx);
        }

        public DataSet PortarTaula(string query)
        {
            conn.Open();
            adapter = new SqlDataAdapter(query, conn);

            DataSet dts = new DataSet();
            adapter.Fill(dts);

            conn.Close();

            return dts;
        }

        public void Actualitzar(string query, DataSet dts)
        {
            conn.Open();
            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);
            if (dts.HasChanges()) {
                adapter.Update(dts.Tables[0]);
            }

            conn.Close();
        }
        public void Executa(string query, DataSet dts)
        {
            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = CommandType.Text;
            int rows = command.ExecuteNonQuery();

            conn.Close();
        }
    }
}
