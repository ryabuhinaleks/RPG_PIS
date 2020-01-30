using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheldule
{
    public partial class SchedForm : Form
    {
        public SchedForm()
        {
            InitializeComponent();
        }

        private void SchedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.ShowDialog();
        }

        private void SchedForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_projectDataSet.direction". При необходимости она может быть перемещена или удалена.
            this.directionTableAdapter.Fill(this.bD_projectDataSet.direction);
            comboBox1.SelectedIndex = -1;
            SetTime(dataGridView1);
            SetTime(dataGridView2);
            SetTime(dataGridView3);
            SetTime(dataGridView4);
            SetTime(dataGridView5);
            SetTime(dataGridView6);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");
             con.Open();
             string gr = "select name from[group] where id_direction = '" + comboBox1.SelectedValue + "'";
             OleDbCommand command = new OleDbCommand(gr, con);
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader.GetValue(0));
                }
                comboBox2.SelectedIndex = 0;
            }
            con.Close();
        }
        public static int SchID { get; set; }
        public static int CurID { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && textBox1.Text != "")
            {
                Direction d = new Direction();
                SchID = d.GetSchedule(comboBox2.Text, int.Parse(textBox1.Text));
                label4.Text = SchID.ToString();
                JournalDirection j = new JournalDirection();
                CurID = j.GetCurriculum(comboBox1.Text.ToString(), int.Parse(textBox1.Text));
                UpdateUndDiscipline();
                button2.Enabled = true;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                textBox1.Enabled = false;
                Text += " направление: " + comboBox1.Text.TrimEnd() + ", семестр: " + textBox1.Text;
            }
            else MessageBox.Show("Заполните все поля","Уведомление");
            UpdateSch();
        }

        private void UpdateUndDiscipline()
        {
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");
            con.Open();
            string UndD = "select dd.discipline from discipline as dd Inner JOIN (select l.DisciplineID from ListDisciplines as l INNER JOIN discipline as d on l.DisciplineID = d.id where l.CurriculumID = '"+CurID+ "' EXCEPT( select disciplineName from BusyLessons where id_schedule = '" + SchID+"')) as ll on ll.DisciplineID = dd.id";
            OleDbCommand command = new OleDbCommand(UndD, con);
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox3.Items.Add(reader.GetValue(0));
                }
                comboBox3.SelectedIndex = 0;
            }
            con.Close();
        }
        private void UpdateSch()
        {
            OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");
            con.Open();
            string lesson = "select b.day, b.time,b.aud, d.discipline from BusyLessons as b INNER JOIN discipline as d on d.id = b.disciplineName where id_schedule = '"+ SchID + "'";
            OleDbCommand command = new OleDbCommand(lesson, con);
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    i = Id_time(reader);

                    if (reader.GetValue(0).ToString() == "Понедельник")
                    {
                        dataGridView1.Rows[i].Cells[1].Value = reader.GetValue(3).ToString();
                        dataGridView1.Rows[i].Cells[2].Value = reader.GetValue(2).ToString();
                    }
                    else if (reader.GetValue(0).ToString() == "Вторник")
                    {
                        dataGridView2.Rows[i].Cells[1].Value = reader.GetValue(3).ToString();
                        dataGridView2.Rows[i].Cells[2].Value = reader.GetValue(2).ToString();
                    }
                    if (reader.GetValue(0).ToString() == "Среда")
                    {
                        dataGridView3.Rows[i].Cells[1].Value = reader.GetValue(3).ToString();
                        dataGridView3.Rows[i].Cells[2].Value = reader.GetValue(2).ToString();
                    }
                    if (reader.GetValue(0).ToString() == "Четверг")
                    {
                        dataGridView4.Rows[i].Cells[1].Value = reader.GetValue(3).ToString();
                        dataGridView4.Rows[i].Cells[2].Value = reader.GetValue(2).ToString();
                    }
                    if (reader.GetValue(0).ToString() == "Пятница")
                    {
                        dataGridView5.Rows[i].Cells[1].Value = reader.GetValue(3).ToString();
                        dataGridView5.Rows[i].Cells[2].Value = reader.GetValue(2).ToString();
                    }
                    if (reader.GetValue(0).ToString() == "Суббота")
                    {
                        dataGridView6.Rows[i].Cells[1].Value = reader.GetValue(3).ToString();
                        dataGridView6.Rows[i].Cells[2].Value = reader.GetValue(2).ToString();
                    }
                }
            }
            con.Close();
        }

        private static int Id_time(OleDbDataReader reader)
        {
            int i;
            if (reader.GetValue(1).ToString() == "8:00-10:00")
                i = 0;
            else if (reader.GetValue(1).ToString() == "11:00-13:00")
                i = 1;
            else i = 2;
            return i;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text != "")
            {
                Disciplines_List ds = new Disciplines_List();
                ds.CurriculumID = CurID;
                ds.SchedID = SchID;
                int dss = int.Parse(ds.GetUndDisc(comboBox3.Text).ToString());
                UpdateUndDiscipline();
                Schedule sch = new Schedule();
                sch.SchedudeID = SchID;
                sch.AddDiscipline(dss);
                MessageBox.Show("Дисциплина (" + comboBox3.Text + ") добавлена в расписание", "Уведомление");
                UpdateUndDiscipline();
            }
            UpdateSch();

        }

        public void SetTime(DataGridView d)
        {
            d.RowCount = 3;
            d[0, 0].Value = "8:00-10:00";
            d[0, 1].Value = "11:00-13:00";
            d[0, 2].Value = "14:00-16:00";
        }

        private void directionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
