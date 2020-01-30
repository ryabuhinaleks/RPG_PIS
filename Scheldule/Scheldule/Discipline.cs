using System;
using System.Data.OleDb;

namespace Scheldule
{
    class Discipline
    {
        public int Id_discipline { get; set; }

        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");

        public int CreateDis(string name, int hour, int dep)
        {
            con.Open();
            string createDis = "INSERT INTO discipline VALUES('" + name + "','" + dep + "','" + hour + "'); SELECT SCOPE_IDENTITY();";
            OleDbCommand command = new OleDbCommand(createDis, con);
            int result = Convert.ToInt32(command.ExecuteScalar());
            Id_discipline = result;
            con.Close();
            return result;
        }
        public void SetDiscipline(int dep)
        {
            con.Open();
            string SetDicsDep = "INSERT INTO DepartmentLoad VALUES('" + Id_discipline + "','" + dep + "')";
            OleDbCommand command = new OleDbCommand(SetDicsDep, con);
            command.ExecuteScalar();
            con.Close();
        }
    }
}
