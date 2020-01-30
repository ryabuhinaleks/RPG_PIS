using System;
using System.Data.OleDb;

namespace Scheldule
{
    class Groups_List
    {
        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");

        public int FindGroup(string NameGqroup)
        {
            con.Open();
            string id_group = "select id from [group] where name = '" + NameGqroup + "'";
            OleDbCommand command = new OleDbCommand(id_group, con);
            int result = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            return result;
        }
    }
}
