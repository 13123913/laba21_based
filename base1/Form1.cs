using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "группыDataSet.Факультет". При необходимости она может быть перемещена или удалена.
            this.факультетTableAdapter.Fill(this.группыDataSet.Факультет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "группыDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.группыDataSet.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "группыDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.группыDataSet.Группы);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.RowCount - 1; i++)
            {
                string str = dataGridView3.Rows[i].Cells[1].Value.ToString();
                if (str.Contains(textBox1.Text) == true)
                    dataGridView3.Rows[i].Selected = true;
                else dataGridView3.Rows[i].Selected = false;
                if (textBox1.Text == "") dataGridView3.Rows[i].Selected = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView3.SortOrder == SortOrder.Ascending)
                dataGridView3.Sort(dataGridView3.Columns[1], ListSortDirection.Descending);
            else dataGridView3.Sort(dataGridView3.Columns[1], ListSortDirection.Ascending);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.RowCount - 1; i++)
            {
                string str = dataGridView3.Rows[i].Cells[1].Value.ToString();
                if (str == textBox2.Text) dataGridView3.Rows[i].Selected = true;
                else dataGridView3.Rows[i].Selected = false;
            }
        }
    }
}
