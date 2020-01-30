namespace Scheldule
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.учебныйПланToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нагрузкаПреподавателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учебныйПланToolStripMenuItem,
            this.расписаниеToolStripMenuItem,
            this.преподавательToolStripMenuItem,
            this.нагрузкаПреподавателяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // учебныйПланToolStripMenuItem
            // 
            this.учебныйПланToolStripMenuItem.Name = "учебныйПланToolStripMenuItem";
            this.учебныйПланToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.учебныйПланToolStripMenuItem.Text = "Учебный план";
            this.учебныйПланToolStripMenuItem.Click += new System.EventHandler(this.учебныйПланToolStripMenuItem_Click);
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.расписаниеToolStripMenuItem.Text = "Расписание";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеToolStripMenuItem_Click);
            // 
            // преподавательToolStripMenuItem
            // 
            this.преподавательToolStripMenuItem.Name = "преподавательToolStripMenuItem";
            this.преподавательToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.преподавательToolStripMenuItem.Text = "Преподаватель";
            this.преподавательToolStripMenuItem.Click += new System.EventHandler(this.преподавательToolStripMenuItem_Click);
            // 
            // нагрузкаПреподавателяToolStripMenuItem
            // 
            this.нагрузкаПреподавателяToolStripMenuItem.Name = "нагрузкаПреподавателяToolStripMenuItem";
            this.нагрузкаПреподавателяToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.нагрузкаПреподавателяToolStripMenuItem.Text = "Нагрузка преподавателя";
            this.нагрузкаПреподавателяToolStripMenuItem.Click += new System.EventHandler(this.нагрузкаПреподавателяToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 246);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(816, 337);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(401, 222);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информационная система составления расписания на один семестр";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem учебныйПланToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нагрузкаПреподавателяToolStripMenuItem;
    }
}

