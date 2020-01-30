using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Scheldule
{
    public class Schedule
    {
        private static Lessons_List Les = new Lessons_List();
        private static Audiences audien = new Audiences();

        public int SchedudeID { get; set; } //объявить

        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");
        public int Created(int semestr)
        {
            con.Open();
            string createSch = "INSERT INTO schedule VALUES('" + semestr + "'); SELECT SCOPE_IDENTITY();";
            OleDbCommand command = new OleDbCommand(createSch, con);
            int result = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            return result;
        }
        public void AddDiscipline(int ds)
        {
            Les.SchedID = SchedudeID;
            var lessons = Les.GetLesson(ds);
            var UndLesson= audien.GetAudLess(lessons); //день+время+имя+ауд
            Les.AddUndLesson(UndLesson);
            //return UndLesson;
        }

    }
}
