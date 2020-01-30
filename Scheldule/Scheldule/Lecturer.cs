using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Scheldule
{
    class Lecturer
    {
        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");
        private int ID { get; }
        private string NameLecturer { get; set; }
        private int Hour { get; set; }
        private string Departmen { get; set; }
        private string Position { get; set; }
    
        public bool AddLecturer(string Name, string Position, string Dep, int Hour)
        {
            var Lec = new Lecturer();
            if (Lec.NewName(Name) && Lec.NewHour(Hour) && Lec.NewDepartmen(Dep) && Lec.NewPosition(Position))
            {
                con.Open();
                string createLecturer = "INSERT INTO Lecturer VALUES('" + Name + "','" + Hour + "','" + Position + "','" + Dep + "');";
                OleDbCommand command = new OleDbCommand(createLecturer, con);
                command.ExecuteScalar();
                con.Close();
                MessageBox.Show("Преподаватель " + Name + " добавлен!");
                return true;
            }

            return false;
        }


        public int NewHourNum(int hour, int disciplineHour)
        {
            if (hour - disciplineHour >= 0)
            {
                hour -= disciplineHour; 
            }
            else
            {
                MessageBox.Show("Невозможно добавить дисциплину!");
            }
            Hour = hour;
            return hour;
        }

        public bool FindLecturerHours(string lec, int disciplineHour)
        {
            con.Open();
            OleDbCommand da = new OleDbCommand("select Hour from Lecturer where NameLecturer = '" + lec + "' ", con);
            int result = Convert.ToInt32(da.ExecuteScalar());
            if (disciplineHour <= result)
            {
                result -= disciplineHour;
            }
            else
            {
                MessageBox.Show("Невозможно добавить дисциплину!");
                return false;
            }
            con.Close();
            UpdateLecturer(lec, result);
            return true;
        }
        public void UpdateLecturer(string lec, int result)
        {
            con.Open();
            string Lessons = "Update Lecturer SET Hour = '" + result + "' WHERE NameLecturer = '" + lec + "'";
            OleDbCommand command = new OleDbCommand(Lessons, con);
            command.ExecuteReader();
            con.Close();
        }

        public bool NewName(string Name)
        {
            NameLecturer = Name;
            return true;
        }
        public bool NewHour(int hour)
        {
            Hour = hour;
            return true;
        }
        public bool NewDepartmen(string Dep)
        {
            Departmen = Dep;
            return true;
        }
        public bool NewPosition(string position)
        {
            Position = position;
            return true;
        }
    }
}
