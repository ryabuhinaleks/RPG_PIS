using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheldule
{
    class FreeAudinces
    {
        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");
        public Lesson FindAud(List<Lesson> Les)
        {
            con.Open();
            int i = 0;       
            bool flag = true;
            Lesson lesson= Les[i];
            while (flag)
            {
                lesson = Les[i];
                string findAud = "select name from audience EXCEPT select aud from BusyAudinces where day = '" + lesson.Day+ "' and time = '"+ lesson.Time+ "'";
                OleDbCommand Aud = new OleDbCommand(findAud, con);
                OleDbDataReader readerAud = Aud.ExecuteReader();
                if (readerAud.HasRows) 
                {
                    var r = readerAud.Read();
                    lesson.aud = readerAud.GetValue(0).ToString();
                    flag = false;
                }
                i++;
            }
            con.Close();
            return lesson;
        }

        public void DeleteAud(Lesson aud)
        {
            con.Open();
            string Aud = "DELETE FROM FreeLessons WHERE aud='"+aud.aud+"' and  disciplineName='"+aud.NameD+"'";
            OleDbCommand cmd = new OleDbCommand(Aud, con);
            cmd.ExecuteReader();
            con.Close();
        }
    }
}
