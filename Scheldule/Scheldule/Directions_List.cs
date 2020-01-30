using System;
using System.Data.OleDb;

namespace Scheldule
{
    class Directions_List
    {
        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");
        public int FindDirection(string nameD)
        {
            con.Open();
            string id_direction = "select id from direction where name = '" + nameD + "'";
            OleDbCommand command = new OleDbCommand(id_direction, con);
            int result = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            return result;
        }
    }
}
