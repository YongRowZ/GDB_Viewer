using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InterBaseSql.Data.InterBaseClient;

using System.IO;

using GDB_Viewer.Properties;
//using System.Threading.Tasks;

namespace GDB_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(Settings.Default.Width, Settings.Default.Height);
            this.Location = new Point(Settings.Default.LocationX, Settings.Default.LocationY);
        }

        //  Создаем таблицу
        public DataTable dataTable = new DataTable();

        //  Создаем параметр подключения 
        private string connectionString(string db_path) 
        {
            string str = @"UserID=sysdba;
                           Password=masterkey;
                           Database=" + db_path + @";
                           DataSource=localhost;
                           Port = 3050;
                           Charset=WIN1251;"; 
            return str;
        }

        // SQL запрос в БД
        private void SQLRequest(string connString, string commandText, DataGridView dgv, DataSet ds, DataTable dt, BindingSource source) 
        {
            IBDataAdapter dataAdapter = new IBDataAdapter();
            IBConnection connection = new IBConnection(connString);
            IBCommand command = new IBCommand();

            command.Connection = connection;

            cleanDataGrid(dgv,dt,ds,source);

            try
            {
                connection.Open();

                command.CommandText = commandText;
                dataAdapter.SelectCommand = command;

                dt = ds.Tables.Add("TB");
                dataAdapter.Fill(ds.Tables["TB"]);

                connection.Close();

               update_table(ds, dt, source, dgv);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //  Функция очистки таблицы
        private void cleanDataGrid(DataGridView dgv, DataTable dt, DataSet ds, BindingSource source) 
        {
            dgv.AllowUserToAddRows = false;
            ds.Tables.Clear();
            dt.Clear();
            //dgv.AllowUserToAddRows = true;
            dgv.DataSource = source;
        }

        //  Функция обновления таблицы
        private void update_table(DataSet ds, DataTable dt, BindingSource source, DataGridView dgv)
        {
            ds.Tables.Clear();
            ds.Tables.Add(dt);
            source.DataSource = ds.Tables[0];
            dgv.DataSource = source;
        }

        //  Функция поиска в таблице
        private void searcDataGrid(DataGridView dataGrid, BindingSource source, TextBox textBox)
        {
            if (textBox.Text != "")
            {
                source.Filter =
                  "[IMSI] LIKE '*"              + textBox.Text + "*'" +
                  "OR [IMEI] LIKE '*"           + textBox.Text + "*'" +
                  "OR [Имя источника] LIKE '*"  + textBox.Text + "*'" +
                  "OR [Оператор] LIKE '*"       + textBox.Text + "*'";

                dataGrid.DataSource = source;
            }

            else
            {
                source.Filter = "";
                dataGrid.DataSource = source;
            }
        }

        //  Подключение к БД
        private void button2_Click(object sender, EventArgs e)
        {
            проверитьСоединениеСБДToolStripMenuItem.Visible = false;

            openFileDialog1.FileName = "";
            openFileDialog1.Filter = @"База данных АПК(Модуль)|*.gdb";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                string connString = connectionString(openFileDialog1.FileName);

                IBConnection connection = new IBConnection(connString);
               
                IBCommand command = new IBCommand();

                command.Connection = connection;

                try 
                {
                    connection.Open();
                    connection.Close();

                    using (StreamWriter sw = new StreamWriter(@"Data\param.ini", false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(openFileDialog1.FileName);
                    }

                    textBox2.Text = openFileDialog1.FileName;
                    button2.Text = @"Изменить";

                    pictureBox1.Image = GDB_Viewer.Properties.Resources.database;
                    проверитьСоединениеСБДToolStripMenuItem.Visible = true;
                }

                catch (Exception ex) 
                { 
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //  Загрузка приложения
        private void Form1_Load(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem.Visible = false;
            проверитьСоединениеСБДToolStripMenuItem.Visible = false;

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;

            try
            {
                string line;

                using (StreamReader sr = new StreamReader(@"Data\param.ini", System.Text.Encoding.Default))
                {
                    line = sr.ReadLine();
                }

                string connString = connectionString(line);

                IBConnection connection = new IBConnection(connString);
                IBCommand command = new IBCommand();

                command.Connection = connection;

                try
                {
                    connection.Open();
                    connection.Close();

                    pictureBox1.Image = GDB_Viewer.Properties.Resources.database;
                    textBox2.Text = line;
                    button2.Text = @"Изменить";
                    проверитьСоединениеСБДToolStripMenuItem.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    using (StreamWriter sw = new StreamWriter(@"Data\param.ini", false, System.Text.Encoding.Default))
                    {
                        sw.Write("");
                    }
                }
            }

            catch{ }
        }

        //  Запрос в БД, получение и вывод информации
        private void button3_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem.Visible = true;

            string SQLcommand = "SELECT " +
                                        "DATETIME AS \"Дата/Время\", " +
                                        "IMSI, " +
                                        "IMEI, " +
                                        "PRIORITY_IMSI_TEXT AS \"Имя источника\", " +
                                        "OPERATOR_NAME AS \"Оператор\" " +

                                  //"FROM VIEW_SESSIONS WHERE (SERVICE_NAME = 'Регистрация')";
                                  "FROM VIEW_SESSIONS WHERE (SERVICE_TYPE_ID = '1')";

            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked) 
            {
                SQLcommand += " AND";

                if (checkBox1.Checked) 
                {
                    SQLcommand += " (DATETIME BETWEEN '" + 
                        dateTimePicker1.Value.ToShortDateString() + " " + 
                        dateTimePicker2.Value.ToLongTimeString() + 
                        "' AND '" +
                        dateTimePicker3.Value.ToShortDateString() + " " +
                        dateTimePicker4.Value.ToLongTimeString() + "')";
                }

                if (checkBox2.Checked) 
                {
                    if (checkBox1.Checked) 
                    { SQLcommand += " AND"; }

                    SQLcommand += " (IMEI = '" + textBox3.Text + "')";
                }

                if (checkBox3.Checked) 
                {
                    if (checkBox1.Checked || checkBox2.Checked) 
                    { SQLcommand += " AND"; }

                    SQLcommand += " (IMSI = '" + textBox4.Text + "')";
                }

                if (checkBox4.Checked) 
                {
                    if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
                    { SQLcommand += " AND"; }

                    SQLcommand += " (PRIORITY_IMSI_TEXT = '" + textBox5.Text + "')";
                }

                SQLRequest(connectionString(textBox2.Text), SQLcommand, dataGridView1, dataSet1, dataTable, bindingSource1);

            }

            else
            {
                string message = "Будут загружены все данные из БД";
                string title = "Продолжить?";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
               
                if (result == DialogResult.Yes)
                {
                    SQLRequest(connectionString(textBox2.Text), SQLcommand, dataGridView1, dataSet1, dataTable, bindingSource1);
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////
        //  Обработка подготовки SQL запроса в БД
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            { 
                groupBox6.Enabled = true;
            }

            else 
            {
                groupBox6.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                groupBox7.Enabled = true;
            }

            else
            {
                groupBox7.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) 
            {
                groupBox8.Enabled = true;
            }

            else
            {
                groupBox8.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                groupBox9.Enabled = true;
            }

            else
            {
                groupBox9.Enabled = false;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////
        
        //  Поиск по таблице
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            searcDataGrid(dataGridView1, bindingSource1, textBox1);
        }

        // Очистка значения в поиске
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            searcDataGrid(dataGridView1, bindingSource1, textBox1);
        }

        //  Очистка значений в запросе к БД
        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        // Сохранение CSV Выгрузки
        private void cSVВыгрузкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Выгрузка PostWorks (*.csv)|*.csv";
            saveFileDialog1.FileName = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, System.Text.Encoding.UTF8)) 
                {
                    sw.WriteLine("\"Дата/Время\";\"Системный номер (IMSI)\";\"Номер терминала (IMEI)\";");

                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        sw.WriteLine("\"" + dataGridView1[0, i].Value
                                          + "\";\"" + dataGridView1[1, i].Value + "\";\""
                                          + dataGridView1[2, i].Value + "\"");
                    }
                }
            }
        }

        //  Завершения работы приложения
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Width = this.Width;
            Settings.Default.Height = this.Height;
            Settings.Default.LocationY = this.Location.Y;
            Settings.Default.LocationX = this.Location.X;
            Settings.Default.Save();
        }
    }
}
