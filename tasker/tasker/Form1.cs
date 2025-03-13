using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private string deadlineTask;

        // buttons
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            deadlineTask = monthCalendar.SelectionStart.ToString("dd.MM.yyyy");

            dataGridView.Rows.Add(textTaskName.Text, textTaskDescr.Text, deadlineTask, priorityTrack.Value + " %");
            textTaskName.Text = null;
            textTaskDescr.Text = null;

            // Set the current date in the calendar
            monthCalendar.SelectionStart = DateTime.Now;
            monthCalendar.SelectionEnd = DateTime.Now;
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            deadlineTask = monthCalendar.SelectionStart.ToString("dd.MM.yyyy");
            if (dataGridView.CurrentRow != null)
            {
                dataGridView.CurrentRow.Cells["task_name"].Value = textTaskName.Text;
                dataGridView.CurrentRow.Cells["task_description"].Value = textTaskDescr.Text;
                dataGridView.CurrentRow.Cells["deadline"].Value = deadlineTask;
                dataGridView.CurrentRow.Cells["priority_task"].Value = priorityTrack.Value + " %";
            }

            // Set the current date in the calendar
            monthCalendar.SelectionStart = DateTime.Now;
            monthCalendar.SelectionEnd = DateTime.Now;
        }

      

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null) {
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
