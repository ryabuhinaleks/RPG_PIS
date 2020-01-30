using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Scheldule
{
    class WorkLoad
    {
        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");
        private int ID { get; }
        private string NameLecturer { get; set; }
        private string Dicsipline { get; set; }

        public bool AddLoad(string Name, string Discipline)
        {
            var Work = new WorkLoad();
            if (NewNameLoad(Name) && NewDisciplineLoad(Discipline))
            {
                con.Open();
                OleDbCommand da = new OleDbCommand("select hour from discipline where discipline = '" + Discipline + "' ", con);
                int result = Convert.ToInt32(da.ExecuteScalar());
                var L = new Lecturer();
                if (L.FindLecturerHours(Name, result))
                {
                    con.Close();
                    con.Open();
                    OleDbCommand da1 = new OleDbCommand("select id from discipline where discipline = '" + Discipline + "' ", con);
                    int idDiscipline = Convert.ToInt32(da1.ExecuteScalar());
                    string ListDisciplines = "Update ListDisciplines SET WorcLoad = '" + 0 + "' WHERE DisciplineID = '" + idDiscipline + "'";
                    OleDbCommand command1 = new OleDbCommand(ListDisciplines, con);
                    command1.ExecuteReader();
                    con.Close();
                    con.Open();
                    string createWorkLoad = "INSERT INTO WorkLoad VALUES('" + Name + "','" + Discipline + "');";
                    OleDbCommand command = new OleDbCommand(createWorkLoad, con);
                    command.ExecuteScalar();
                    con.Close();
                    MessageBox.Show("Нагрузка добавлена!");
                    return true;
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Нагрузка НЕ добавлена!");
                    return false;
                }
                
            }

            return false;
        }










        public bool NewNameLoad(string Name)
        {
            NameLecturer = Name;
            return true;
        }
        public bool NewDisciplineLoad(string discipline)
        {
            Dicsipline = discipline;
            return true;
        }
    }
}
