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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void учебныйПланToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurriculumForm cf = new CurriculumForm();
            this.Hide();
            cf.ShowDialog();
            this.Close();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchedForm sf = new SchedForm();
            this.Hide();
            sf.ShowDialog();
            this.Close();
        }

        private void преподавательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LecturerForm sf = new LecturerForm();
            this.Hide();
            sf.ShowDialog();
            this.Close();
        }

        private void нагрузкаПреподавателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkloadForm sf = new WorkloadForm();
            this.Hide();
            sf.ShowDialog();
            this.Close();
        }
    }
}
