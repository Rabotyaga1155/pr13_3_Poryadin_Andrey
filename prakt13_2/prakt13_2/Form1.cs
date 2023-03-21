using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prakt13_2
{
    public partial class Form1 : Form
    {
        public int a = 1;
      
        //private SortedDictionary<int, Computer> pc = new SortedDictionary<int, Computer>();
        private IList<Computer> comp1 = new List<Computer>();
        private void addPC(string pcNumber, string processor, string monitor,string videok,int op,string dota)
        {
            Computer s = new Computer(pcNumber, processor, monitor,videok,op,dota);
            comp1.Add(s);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = s.setDota().ToString();
            showListInGrid();
        }
        //public string dota(int value)
        //{
        //    string a;
        //    if (value<4)
        //    {
        //        a = "Да";
        //    }
        //    return a;
        //    else
        //    {
        //        a = "Нет";
        //    }

        //    return a;
        //}



        //        private void addStudent(string name, string surname, string
        //recordBookNumber)
        //        {
        //            Student s = new Student(name, surname, recordBookNumber);
        //            studentList.Add(s);
        //            textBox1.Text = "";
        //            textBox2.Text = "";
        //            textBox2.Text = "";
        //            showListInGrid();
        //        }
        //Удаление студента с колекции
        private void deletePC(int elementIndex)
        {
            comp1.RemoveAt(elementIndex);
            showListInGrid();
        }
        //Отображение колекции в таблице
        private void showListInGrid()
        {
            
            dataGridView1.Rows.Clear();
            foreach (Computer s in comp1)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell1 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell3 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell4 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell5 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell6 = new
                DataGridViewTextBoxCell();
                cell1.ValueType = typeof(string);
                cell1.Value = s.getPcNumber();
                cell2.ValueType = typeof(string);
                cell2.Value = s.getProcessor();
                cell3.ValueType = typeof(string);
                cell3.Value = s.getMonitor();
                cell4.ValueType = typeof(string);
                cell4.Value = s.getVideok();
                cell5.ValueType = typeof(string);
                cell5.Value = s.getOp();
                cell6.ValueType = typeof(string);
                cell6.Value = s.setDota();
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
                row.Cells.Add(cell5);
                row.Cells.Add(cell6);
                dataGridView1.Rows.Add(row);
                
            }
            
        }


        private DataGridViewColumn dataGridViewColumn1 = null;
        private DataGridViewColumn dataGridViewColumn2 = null;
        private DataGridViewColumn dataGridViewColumn3 = null;
        private DataGridViewColumn dataGridViewColumn4 = null;
        private DataGridViewColumn dataGridViewColumn5 = null;
        private DataGridViewColumn dataGridViewColumn6 = null;

        private void initDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Add(getDataGridViewColumn1());
            dataGridView1.Columns.Add(getDataGridViewColumn2());
            dataGridView1.Columns.Add(getDataGridViewColumn3());
            dataGridView1.Columns.Add(getDataGridViewColumn4());
            dataGridView1.Columns.Add(getDataGridViewColumn5());
            dataGridView1.Columns.Add(getDataGridViewColumn6());
            dataGridView1.AutoResizeColumns();
        }
        //Динамическое создание первой колонки в таблице
        private DataGridViewColumn getDataGridViewColumn1()
        {
            if (dataGridViewColumn1 == null)
            {
                dataGridViewColumn1 = new DataGridViewTextBoxColumn();
                dataGridViewColumn1.Name = "";
                dataGridViewColumn1.HeaderText = "Номер пк";
                dataGridViewColumn1.ValueType = typeof(string);
                dataGridViewColumn1.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn1;
        }
        //Динамическое создание второй колонки в таблице
        private DataGridViewColumn getDataGridViewColumn2()
        {
            if (dataGridViewColumn2 == null)
            {
                dataGridViewColumn2 = new DataGridViewTextBoxColumn();
                dataGridViewColumn2.Name = "";
                dataGridViewColumn2.HeaderText = "Процессор";
                dataGridViewColumn2.ValueType = typeof(string);
                dataGridViewColumn2.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn2;
        }
        //Динамическое создание третей колонки в таблице
        private DataGridViewColumn getDataGridViewColumn3()
        {
            if (dataGridViewColumn3 == null)
            {
                dataGridViewColumn3 = new DataGridViewTextBoxColumn();
                dataGridViewColumn3.Name = "";
                dataGridViewColumn3.HeaderText = "Монитор";
                dataGridViewColumn3.ValueType = typeof(string);
                dataGridViewColumn3.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn3;
        }
        private DataGridViewColumn getDataGridViewColumn4()
        {
            if (dataGridViewColumn4 == null)
            {
                dataGridViewColumn4 = new DataGridViewTextBoxColumn();
                dataGridViewColumn4.Name = "";
                dataGridViewColumn4.HeaderText = "Видеокарта";
                dataGridViewColumn4.ValueType = typeof(string);
                dataGridViewColumn4.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn4;
        }
        private DataGridViewColumn getDataGridViewColumn5()
        {
            if (dataGridViewColumn5 == null)
            {
                dataGridViewColumn5 = new DataGridViewTextBoxColumn();
                dataGridViewColumn5.Name = "";
                dataGridViewColumn5.HeaderText = "Оперативка";
                dataGridViewColumn5.ValueType = typeof(string);
                dataGridViewColumn5.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn5;
        }
        private DataGridViewColumn getDataGridViewColumn6()
        {
            if (dataGridViewColumn6 == null)
            {
                dataGridViewColumn6 = new DataGridViewTextBoxColumn();
                dataGridViewColumn6.Name = "";
                dataGridViewColumn6.HeaderText = "Поддерживает ли DOTA2";
                dataGridViewColumn6.ValueType = typeof(string);
                dataGridViewColumn6.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn6;
        }

        public Form1()
        {
            InitializeComponent();
            initDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            addPC(textBox1.Text, textBox2.Text, textBox3.Text,textBox4.Text,Convert.ToInt32(textBox5.Text),textBox6.Text);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            DialogResult dr = MessageBox.Show("Удалить компьютер?", "",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    deletePC(selectedRow);
                }
                catch (Exception)
                {
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

