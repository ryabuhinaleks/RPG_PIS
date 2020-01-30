namespace Scheldule
{
    partial class LecturerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listDepartmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD_projectDataSet4 = new Scheldule.BD_projectDataSet4();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD_projectDataSet5 = new Scheldule.BD_projectDataSet5();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_projectDataSet2 = new Scheldule.BD_projectDataSet2();
            this.lecturerTableAdapter = new Scheldule.BD_projectDataSet2TableAdapters.LecturerTableAdapter();
            this.bD_projectDataSet3 = new Scheldule.BD_projectDataSet3();
            this.listDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listDepartmentsTableAdapter = new Scheldule.BD_projectDataSet3TableAdapters.ListDepartmentsTableAdapter();
            this.listDepartmentsTableAdapter1 = new Scheldule.BD_projectDataSet4TableAdapters.ListDepartmentsTableAdapter();
            this.lecturerTableAdapter1 = new Scheldule.BD_projectDataSet5TableAdapters.LecturerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.listDepartmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_projectDataSet4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_projectDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_projectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_projectDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDepartmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кол-во часов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.listDepartmentsBindingSource1;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "id";
            // 
            // listDepartmentsBindingSource1
            // 
            this.listDepartmentsBindingSource1.DataMember = "ListDepartments";
            this.listDepartmentsBindingSource1.DataSource = this.bD_projectDataSet4;
            // 
            // bD_projectDataSet4
            // 
            this.bD_projectDataSet4.DataSetName = "BD_projectDataSet4";
            this.bD_projectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 73);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 127);
            this.textBox3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 23);
            this.textBox3.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(4, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Size = new System.Drawing.Size(246, 197);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление нового преподавателя";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 151);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(109, 99);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 23);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameLecturerDataGridViewTextBoxColumn,
            this.hourDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.departmenIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lecturerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(252, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(517, 197);
            this.dataGridView1.TabIndex = 8;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameLecturerDataGridViewTextBoxColumn
            // 
            this.nameLecturerDataGridViewTextBoxColumn.DataPropertyName = "NameLecturer";
            this.nameLecturerDataGridViewTextBoxColumn.HeaderText = "NameLecturer";
            this.nameLecturerDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nameLecturerDataGridViewTextBoxColumn.Name = "nameLecturerDataGridViewTextBoxColumn";
            this.nameLecturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hourDataGridViewTextBoxColumn
            // 
            this.hourDataGridViewTextBoxColumn.DataPropertyName = "Hour";
            this.hourDataGridViewTextBoxColumn.HeaderText = "Hour";
            this.hourDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.hourDataGridViewTextBoxColumn.Name = "hourDataGridViewTextBoxColumn";
            this.hourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmenIDDataGridViewTextBoxColumn
            // 
            this.departmenIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmenID";
            this.departmenIDDataGridViewTextBoxColumn.HeaderText = "DepartmenID";
            this.departmenIDDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.departmenIDDataGridViewTextBoxColumn.Name = "departmenIDDataGridViewTextBoxColumn";
            this.departmenIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lecturerBindingSource1
            // 
            this.lecturerBindingSource1.DataMember = "Lecturer";
            this.lecturerBindingSource1.DataSource = this.bD_projectDataSet5;
            // 
            // bD_projectDataSet5
            // 
            this.bD_projectDataSet5.DataSetName = "BD_projectDataSet5";
            this.bD_projectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "Lecturer";
            this.lecturerBindingSource.DataSource = this.bD_projectDataSet2;
            // 
            // bD_projectDataSet2
            // 
            this.bD_projectDataSet2.DataSetName = "BD_projectDataSet2";
            this.bD_projectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // bD_projectDataSet3
            // 
            this.bD_projectDataSet3.DataSetName = "BD_projectDataSet3";
            this.bD_projectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listDepartmentsBindingSource
            // 
            this.listDepartmentsBindingSource.DataMember = "ListDepartments";
            this.listDepartmentsBindingSource.DataSource = this.bD_projectDataSet3;
            // 
            // listDepartmentsTableAdapter
            // 
            this.listDepartmentsTableAdapter.ClearBeforeFill = true;
            // 
            // listDepartmentsTableAdapter1
            // 
            this.listDepartmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // lecturerTableAdapter1
            // 
            this.lecturerTableAdapter1.ClearBeforeFill = true;
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 246);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "LecturerForm";
            this.Load += new System.EventHandler(this.LecturerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listDepartmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_projectDataSet4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_projectDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_projectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_projectDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDepartmentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BD_projectDataSet2 bD_projectDataSet2;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private BD_projectDataSet2TableAdapters.LecturerTableAdapter lecturerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameLecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmenIDDataGridViewTextBoxColumn;
        private BD_projectDataSet3 bD_projectDataSet3;
        private System.Windows.Forms.BindingSource listDepartmentsBindingSource;
        private BD_projectDataSet3TableAdapters.ListDepartmentsTableAdapter listDepartmentsTableAdapter;
        private BD_projectDataSet4 bD_projectDataSet4;
        private System.Windows.Forms.BindingSource listDepartmentsBindingSource1;
        private BD_projectDataSet4TableAdapters.ListDepartmentsTableAdapter listDepartmentsTableAdapter1;
        private BD_projectDataSet5 bD_projectDataSet5;
        private System.Windows.Forms.BindingSource lecturerBindingSource1;
        private BD_projectDataSet5TableAdapters.LecturerTableAdapter lecturerTableAdapter1;
    }
}