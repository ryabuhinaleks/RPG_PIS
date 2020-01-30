namespace Scheldule
{
    partial class WorkloadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_projectDataSet6 = new Scheldule.BD_projectDataSet6();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.directionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_projectDataSet7 = new Scheldule.BD_projectDataSet7();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workLoadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_projectDataSet8 = new Scheldule.BD_projectDataSet8();
            this.lecturerTableAdapter = new Scheldule.BD_projectDataSet6TableAdapters.LecturerTableAdapter();
            this.directionTableAdapter = new Scheldule.BD_projectDataSet7TableAdapters.directionTableAdapter();
            this.workLoadTableAdapter = new Scheldule.BD_projectDataSet8TableAdapters.WorkLoadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_projectDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_projectDataSet7)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workLoadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_projectDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.lecturerBindingSource;
            this.comboBox1.DisplayMember = "NameLecturer";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "DepartmenID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "Lecturer";
            this.lecturerBindingSource.DataSource = this.bD_projectDataSet6;
            // 
            // bD_projectDataSet6
            // 
            this.bD_projectDataSet6.DataSetName = "BD_projectDataSet6";
            this.bD_projectDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Преподаватель";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Семестр";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.directionBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(95, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "id";
            // 
            // directionBindingSource
            // 
            this.directionBindingSource.DataMember = "direction";
            this.directionBindingSource.DataSource = this.bD_projectDataSet7;
            // 
            // bD_projectDataSet7
            // 
            this.bD_projectDataSet7.DataSetName = "BD_projectDataSet7";
            this.bD_projectDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Направление";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Получить нераспределенные дисциплины!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(283, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор учебного плана";
            // 
            // comboBox3
            // 
            this.comboBox3.DisplayMember = "name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(109, 208);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(176, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.ValueMember = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дисциплина";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 245);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Добавить нагрузку!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.lectorDataGridViewTextBoxColumn,
            this.disciplineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workLoadBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(325, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(360, 179);
            this.dataGridView1.TabIndex = 11;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // lectorDataGridViewTextBoxColumn
            // 
            this.lectorDataGridViewTextBoxColumn.DataPropertyName = "Lector";
            this.lectorDataGridViewTextBoxColumn.HeaderText = "Lector";
            this.lectorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.lectorDataGridViewTextBoxColumn.Name = "lectorDataGridViewTextBoxColumn";
            this.lectorDataGridViewTextBoxColumn.ReadOnly = true;
            this.lectorDataGridViewTextBoxColumn.Width = 62;
            // 
            // disciplineDataGridViewTextBoxColumn
            // 
            this.disciplineDataGridViewTextBoxColumn.DataPropertyName = "Discipline";
            this.disciplineDataGridViewTextBoxColumn.HeaderText = "Discipline";
            this.disciplineDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.disciplineDataGridViewTextBoxColumn.Name = "disciplineDataGridViewTextBoxColumn";
            this.disciplineDataGridViewTextBoxColumn.ReadOnly = true;
            this.disciplineDataGridViewTextBoxColumn.Width = 77;
            // 
            // workLoadBindingSource
            // 
            this.workLoadBindingSource.DataMember = "WorkLoad";
            this.workLoadBindingSource.DataSource = this.bD_projectDataSet8;
            // 
            // bD_projectDataSet8
            // 
            this.bD_projectDataSet8.DataSetName = "BD_projectDataSet8";
            this.bD_projectDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // directionTableAdapter
            // 
            this.directionTableAdapter.ClearBeforeFill = true;
            // 
            // workLoadTableAdapter
            // 
            this.workLoadTableAdapter.ClearBeforeFill = true;
            // 
            // WorkloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 285);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "WorkloadForm";
            this.Text = "WorkloadForm";
            this.Load += new System.EventHandler(this.WorkloadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_projectDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_projectDataSet7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workLoadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_projectDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BD_projectDataSet6 bD_projectDataSet6;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private BD_projectDataSet6TableAdapters.LecturerTableAdapter lecturerTableAdapter;
        private BD_projectDataSet7 bD_projectDataSet7;
        private System.Windows.Forms.BindingSource directionBindingSource;
        private BD_projectDataSet7TableAdapters.directionTableAdapter directionTableAdapter;
        private BD_projectDataSet8 bD_projectDataSet8;
        private System.Windows.Forms.BindingSource workLoadBindingSource;
        private BD_projectDataSet8TableAdapters.WorkLoadTableAdapter workLoadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineDataGridViewTextBoxColumn;
    }
}