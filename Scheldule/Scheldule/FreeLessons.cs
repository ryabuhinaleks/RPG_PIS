using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheldule
{
    public class FreeLessons: Lessons_List
    {
        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");
        public int SchID { get; set; }

        public List<Lesson> FindLessons(int ds)
        {
            con.Open();
            string Lessons = "select ID,day,time, disciplineName from FreeLessons where disciplineName is null and id_schedule='" + SchID + "'";
            OleDbCommand command = new OleDbCommand(Lessons, con);
            OleDbDataReader reader = command.ExecuteReader();
            List<Lesson> listLes = new List<Lesson>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Lesson l = new Lesson
                    {
                        ID = int.Parse(reader.GetValue(0).ToString()),
                        Day = reader.GetValue(1).ToString(),
                        Time = reader.GetValue(2).ToString(),
                        NameD=ds
                    };
                    listLes.Add(l);
                }
            }
            con.Close();
            return listLes;
        }
        public void DeleteLessons(Lesson UndLesson)
        {
            con.Open();
            string Lessons = "DELETE FROM FreeLessons WHERE Id='"+ UndLesson .ID+ "'";
            OleDbCommand command = new OleDbCommand(Lessons, con);
            command.ExecuteReader();
            con.Close();
        }

    }
}
