using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheldule
{
    class UndDisciplines_List
    {
        public int CurriculumID { get; set; }
        public int SchID { get; set; }

        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");

        public int FindUndDiscip(string nameD)
        {
            con.Open();
            string undDisc = "select l.DisciplineID from ListDisciplines as l INNER JOIN discipline as d on l.DisciplineID = d.id where l.CurriculumID = '" + CurriculumID + "' and d.discipline='"+nameD+"' EXCEPT ( select disciplineName from FreeLessons where id_schedule = '" + SchID+"' and disciplineName is not NULL )";
            OleDbCommand command = new OleDbCommand(undDisc, con);
            int result = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            return result;
        }
    }
}
