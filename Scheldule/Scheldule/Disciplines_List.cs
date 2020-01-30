using System.Data.OleDb;

namespace Scheldule
{
    class Disciplines_List
    {
        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");
        private static UndDisciplines_List IndD = new UndDisciplines_List();
        public int CurriculumID { get; set; }
        public int SchedID { get; set; }

        public void AddDiscipline(int dis)
        {
            con.Open();
            string AddDir = "INSERT INTO ListDisciplines VALUES('" + CurriculumID + "','" + dis + "');";
            OleDbCommand command = new OleDbCommand(AddDir, con);
            command.ExecuteScalar();
            con.Close();
        }
        public int GetUndDisc(string nameD)
        {
            IndD.CurriculumID = CurriculumID;
            IndD.SchID = SchedID;
            int discID = IndD.FindUndDiscip(nameD);
            return discID;
        }
    }
}
