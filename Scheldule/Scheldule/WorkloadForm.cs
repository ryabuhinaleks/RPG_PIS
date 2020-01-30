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
    public partial class WorkloadForm : Form
    {
        public WorkloadForm()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=SQLOLEDB;Data Source=LAPTOP-JA1SSE7M;Initial Catalog=BD_project;Integrated Security=SSPI");
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static int CurID { get; set; }
        private void WorkloadForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_projectDataSet8.WorkLoad". При необходимости она может быть перемещена или удалена.
            this.workLoadTableAdapter.Fill(this.bD_projectDataSet8.WorkLoad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_projectDataSet7.direction". При необходимости она может быть перемещена или удалена.
            this.directionTableAdapter.Fill(this.bD_projectDataSet7.direction);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_projectDataSet6.Lecturer". При необходимости она может быть перемещена или удалена.
            this.lecturerTableAdapter.Fill(this.bD_projectDataSet6.Lecturer);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(comboBox1.GetItemText(comboBox1.SelectedItem));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JournalDirection j = new JournalDirection();
            CurID = j.GetCurriculum(comboBox2.Text.ToString(), int.Parse(textBox1.Text));
            label1.Text = CurID.ToString();
            Update();
            button1.Enabled = false;
            textBox1.Enabled = false;
            comboBox2.Enabled = false;
            button2.Enabled = true;
            Text += ": направление " + comboBox2.Text.TrimEnd() + ", семестр " + textBox1.Text;
        }
        public void Update()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select disc.discipline as 'Дисциплина' from ListDisciplines as l INNER JOIN discipline as disc on l.DisciplineID = disc.id INNER JOIN ListDepartments as dep on disc.department_id = dep.id where CurriculumID = '" + CurID + "' and WorcLoad = '1'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "DisciplineCurrID");
            comboBox3.DataSource = ds.Tables["DisciplineCurrID"];
            comboBox3.DisplayMember = "Дисциплина";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var W = new WorkLoad();
            string item1 = comboBox1.GetItemText(comboBox1.SelectedItem);
            string item2 = comboBox3.GetItemText(comboBox3.SelectedItem);
            bool k = W.AddLoad(item1,item2);
            if (k == false)
            {
                MessageBox.Show("Нагрузка НЕ добавлена!");
            }
            Form1 sf = new Form1();
            this.Hide();
            sf.ShowDialog();
            this.Close();
        }
    }
}
