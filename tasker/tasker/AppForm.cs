using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace tasker
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) { }

        private void groupBox2_Enter(object sender, EventArgs e) { }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e) { }

        private void button1_Click_1(object sender, EventArgs e) { }


        /// <summary>
        /// start function
        /// </summary>

        private string deadlineTask;
        private string jsonFilePath = "tasks.json";

        private void SaveTasksToJson()
        {
            var tasks = new List<dynamic>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var task = new
                    {
                        Name = row.Cells["task_name"].Value?.ToString(),
                        Description = row.Cells["task_description"].Value?.ToString(),
                        Deadline = row.Cells["deadline"].Value?.ToString(),
                        Priority = row.Cells["priority_task"].Value?.ToString()
                    };
                    tasks.Add(task);
                }
            }

            string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
        }

        // buttons
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            deadlineTask = monthCalendar.SelectionStart.ToString("dd.MM.yyyy");

            if (!string.IsNullOrWhiteSpace(textTaskName.Text) && !string.IsNullOrWhiteSpace(textTaskDescr.Text))
            {
                dataGridView.Rows.Add(textTaskName.Text, textTaskDescr.Text, deadlineTask, priorityTrack.Value + " %");
                textTaskName.Text = null;
                textTaskDescr.Text = null;

                // Set the current date in the calendar
                monthCalendar.SelectionStart = DateTime.Now;
                monthCalendar.SelectionEnd = DateTime.Now;
            }
            else
            {
                // Display an error message if one of the fields is empty
                MessageBox.Show("Please fill in all fields before adding a task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }      
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            deadlineTask = monthCalendar.SelectionStart.ToString("dd.MM.yyyy");
            if (dataGridView.CurrentRow != null)
            {
                if(!String.IsNullOrWhiteSpace(textTaskName.Text) || !string.IsNullOrWhiteSpace(textTaskDescr.Text))
                {
                    dataGridView.CurrentRow.Cells["task_name"].Value = textTaskName.Text;
                    dataGridView.CurrentRow.Cells["task_description"].Value = textTaskDescr.Text;
                }
               
                dataGridView.CurrentRow.Cells["deadline"].Value = deadlineTask;
                dataGridView.CurrentRow.Cells["priority_task"].Value = priorityTrack.Value + " %";
            }

            textTaskName.Text = null;
            textTaskDescr.Text = null;

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

        // Button response to action
        private void bttn_MouseDown(object sender, MouseEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                clickedButton.FlatAppearance.BorderColor = SystemColors.ControlDark;
            }
        }

        private void bttn_MouseEnter(object sender, EventArgs e)
        {
            Button hoveredButton = sender as Button;
            if (hoveredButton != null)
            {
                var color = Color.FromArgb(32, 4, 68);
                hoveredButton.FlatAppearance.BorderColor = color;
                hoveredButton.BackColor = Color.FromArgb(250, 168, 133);
            }
        }

        private void bttn_MouseLeave(object sender, EventArgs e)
        {
            Button hoveredButton = sender as Button;
            if (hoveredButton != null)
            {
                hoveredButton.BackColor = Color.FromArgb(238, 238, 238);
            }
        }

        private void bttn_MouseUp(object sender, MouseEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                var color = Color.FromArgb(32, 4, 68);
                clickedButton.FlatAppearance.BorderColor = color;
            }
        }

    }
}
