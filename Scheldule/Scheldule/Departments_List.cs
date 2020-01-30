using System;
using System.Data.OleDb;

namespace Scheldule
{
    class Departments_List
    {
        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");

        public int FindDep(string nameD)
        {
            con.Open();
            string depart = "select id from ListDepartments where Name = '" + nameD + "'";
            OleDbCommand command = new OleDbCommand(depart, con);
            int result = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            return result;
        }
    }
}
