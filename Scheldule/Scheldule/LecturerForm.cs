using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheldule
{
    public partial class LecturerForm : Form
    {
        public LecturerForm()
        {
            InitializeComponent();
        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_projectDataSet5.Lecturer". При необходимости она может быть перемещена или удалена.
            this.lecturerTableAdapter1.Fill(this.bD_projectDataSet5.Lecturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_projectDataSet4.ListDepartments". При необходимости она может быть перемещена или удалена.
            this.listDepartmentsTableAdapter1.Fill(this.bD_projectDataSet4.ListDepartments);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Lec = new Lecturer();
            string item2 = comboBox1.GetItemText(comboBox1.SelectedItem);
            bool k = Lec.AddLecturer(textBox1.Text, textBox3.Text, item2, int.Parse(numericUpDown1.Value.ToString()));
            if ( k == false)
            {
                MessageBox.Show("Преподаватель НЕ добавлен!");
            }
            Form1 sf = new Form1();
            this.Hide();
            sf.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}
