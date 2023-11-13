namespace GDB_Viewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataSet1 = new System.Data.DataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVВыгрузкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьСоединениеСБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(532, 466);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(224, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(376, 508);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 57);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Подключенная БД:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GDB_Viewer.Properties.Resources.cancel_outline;
            this.pictureBox1.Location = new System.Drawing.Point(422, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Открыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(302, 22);
            this.textBox2.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.проверитьСоединениеСБДToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVВыгрузкаToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Image = global::GDB_Viewer.Properties.Resources.download_outline;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить:";
            // 
            // cSVВыгрузкаToolStripMenuItem
            // 
            this.cSVВыгрузкаToolStripMenuItem.Image = global::GDB_Viewer.Properties.Resources.clipboard;
            this.cSVВыгрузкаToolStripMenuItem.Name = "cSVВыгрузкаToolStripMenuItem";
            this.cSVВыгрузкаToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.cSVВыгрузкаToolStripMenuItem.Text = "CSV Выгрузка";
            this.cSVВыгрузкаToolStripMenuItem.Click += new System.EventHandler(this.cSVВыгрузкаToolStripMenuItem_Click);
            // 
            // проверитьСоединениеСБДToolStripMenuItem
            // 
            this.проверитьСоединениеСБДToolStripMenuItem.Image = global::GDB_Viewer.Properties.Resources.arrow_sync_outline;
            this.проверитьСоединениеСБДToolStripMenuItem.Name = "проверитьСоединениеСБДToolStripMenuItem";
            this.проверитьСоединениеСБДToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.проверитьСоединениеСБДToolStripMenuItem.Text = "Проверить соединение с БД";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(550, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 468);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Запрос в БД:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Выполнить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(17, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Дата\\Время";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 56);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 20);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "IMEI";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(129, 56);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(55, 20);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "IMSI";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Location = new System.Drawing.Point(6, 82);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(281, 145);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Дата\\Время:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTimePicker3);
            this.groupBox5.Controls.Add(this.dateTimePicker4);
            this.groupBox5.Location = new System.Drawing.Point(6, 84);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(269, 52);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "До:";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(143, 21);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(120, 22);
            this.dateTimePicker4.TabIndex = 3;
            this.dateTimePicker4.Value = new System.DateTime(2023, 2, 1, 23, 59, 59, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(6, 21);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.RightToLeftLayout = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(120, 22);
            this.dateTimePicker3.TabIndex = 2;
            this.dateTimePicker3.Value = new System.DateTime(2021, 12, 12, 17, 18, 12, 0);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Location = new System.Drawing.Point(6, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 57);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "От:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(143, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 22);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.Value = new System.DateTime(2023, 2, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2021, 12, 12, 17, 18, 12, 0);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(129, 30);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(127, 20);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Имя источника";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(6, 233);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(281, 53);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "IMEI:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(269, 22);
            this.textBox3.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox4);
            this.groupBox8.Enabled = false;
            this.groupBox8.Location = new System.Drawing.Point(6, 292);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(281, 53);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "IMSI:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(269, 22);
            this.textBox4.TabIndex = 3;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox5);
            this.groupBox9.Enabled = false;
            this.groupBox9.Location = new System.Drawing.Point(6, 351);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(281, 53);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Имя источника:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 21);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(269, 22);
            this.textBox5.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(168, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(850, 571);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(868, 618);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Просмоторщик";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверитьСоединениеСБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVВыгрузкаToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
    }
}

