using System;
using System.Data.OleDb;

namespace Scheldule
{
    class Curriculums_List
    {
        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");

        public int Name { get; set; }//направление

        public void Add(int Curriculum)
        {
            con.Open();
            string AddDisDir = "INSERT INTO ListCurriculum VALUES('" + Curriculum + "','" + Name + "')";
            OleDbCommand command = new OleDbCommand(AddDisDir, con);
            command.ExecuteScalar();
            con.Close();
        }
        public int? FindCurDir(int semestr) //Находит УП по id_направлению и номера семестра. Направление задается в Name
        {
            con.Open();
            string id_cur = "select l.id_curriculum from ListCurriculum as l INNER JOIN curriculum as c ON l.id_curriculum = c.id_curriculum where id_direction = '" + Name + "' and semestr = '" + semestr + "'";
            OleDbCommand command = new OleDbCommand(id_cur, con);
            int result = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            if (result == 0)
                return null;
            return result;
        }
    }
}
