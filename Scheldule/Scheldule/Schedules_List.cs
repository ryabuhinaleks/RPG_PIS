using System;
using System.Data.OleDb;

namespace Scheldule
{
    class Schedules_List
    {
        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");
        public int id_group { get; set; }

        public void Add(int Schedule)
        {
            con.Open();
            string AddDisDir = "INSERT INTO ListSchedule VALUES('" + Schedule + "','" + id_group + "'); INSERT INTO FreeLessons VALUES ('"+Schedule+ "',NULL,NULL,NULL,NULL)";
            OleDbCommand command = new OleDbCommand(AddDisDir, con);
            command.ExecuteScalar();
            con.Close();
        }
        public int? FindSchGroup(int semestr)
        {
            con.Open();
            string id_sch = "select l.id_schedule from ListSchedule as l INNER JOIN schedule as sch ON l.id_schedule = sch.id_schedule where id_group = '" + id_group + "' and semestr = '" + semestr + "'";
            OleDbCommand command = new OleDbCommand(id_sch, con);
            int result = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            if (result == 0)
                return null;
            return result;
        }
    }
}
