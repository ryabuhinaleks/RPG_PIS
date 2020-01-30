using System;
using System.Data.OleDb;

namespace Scheldule
{
    class Curriculum
    {
        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");

        private static University Univer = new University();
        private static Discipline Discipl = new Discipline();
        private static Disciplines_List Disc_list = new Disciplines_List();

        public int Created(int semestr)
        {
            con.Open();
            string createDir = "INSERT INTO curriculum VALUES('" + semestr + "'); SELECT SCOPE_IDENTITY();";
            OleDbCommand command = new OleDbCommand(createDir, con);
            int result = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            return result;
        }

        public void assignDiscipline(int CurriculumeID, string name, int hour, string dep)
        {
            int depart = Univer.GetDepartment(dep);
            int Dis = Discipl.CreateDis(name, hour, depart);
            Discipl.SetDiscipline(depart);
            Disc_list.CurriculumID = CurriculumeID;
            Disc_list.AddDiscipline(Dis);
        }

    }
}
