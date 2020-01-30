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
    public partial class CurriculumForm : Form
    {
        public CurriculumForm()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");

        
        public static int CurID { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            JournalDirection j = new JournalDirection();
            CurID = j.GetCurriculum(comboBox1.Text.ToString(), int.Parse(textBox1.Text));
            label1.Text = CurID.ToString();
            Update();
            button1.Enabled = false;
            textBox1.Enabled = false;
            comboBox1.Enabled = false;
            button2.Enabled = true;
            Text += ": направление " + comboBox1.Text.TrimEnd() + ", семестр " + textBox1.Text;
        }
        public void Update()
        {

            OleDbDataAdapter da = new OleDbDataAdapter("select disc.discipline as 'Дисциплина', disc.hour as 'Часы', dep.name as 'Кафедра' from ListDisciplines as l INNER JOIN discipline as disc on l.DisciplineID = disc.id INNER JOIN ListDepartments as dep on disc.department_id = dep.id where CurriculumID = '" + CurID + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "DisciplineCurrID");
            dataGridView1.DataSource = ds.Tables["DisciplineCurrID"];
            dataGridView1.Columns[0].Width = 240;
            dataGridView1.Columns[1].Width = 46;
            dataGridView1.Columns[2].Width = 240;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Curriculum c = new Curriculum();
                c.assignDiscipline(CurID, textBox2.Text, int.Parse(textBox3.Text), comboBox2.Text);
                MessageBox.Show(textBox2.Text.TrimEnd() + " добавлен в УП", "Уведомление");
                Update();
            }
            else
                MessageBox.Show("Заполните поле 'Дисциплина'","Уведомление");
        }

        private void CurriculumForm_Load(object sender, EventArgs e)
        {
            listDepartmentsTableAdapter.Fill(this.bD_projectDataSet1.ListDepartments);
            directionTableAdapter.Fill(this.bD_projectDataSet.direction);
        }

        private void CurriculumForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
