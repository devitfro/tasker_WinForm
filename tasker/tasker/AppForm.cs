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
using System.Data.SqlClient;
using System.Collections;

namespace tasker
{
    public partial class AppForm : FormBase
    {
        private string deadlineTask;

        private List<TaskBase> tasks = new List<TaskBase>();

        public AppForm()
        {
            InitializeComponent();
            LoadUserData();
            LoadTasksFromDatabase();
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

        private void button2_Click(object sender, EventArgs e) { }

        private void button1_Click_2(object sender, EventArgs e) { }

        private void label7_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void helloBox_Enter(object sender, EventArgs e) { }

        // Button add task
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            string deadlineTask = monthCalendar.SelectionStart.ToString("dd.MM.yyyy");

            if (!string.IsNullOrWhiteSpace(textTaskName.Text) && !string.IsNullOrWhiteSpace(textTaskDescr.Text))
            {
                // Using a factory method to create a task
                var task = TaskFactory.CreateTask(
                    textTaskName.Text,
                    textTaskDescr.Text,
                    deadlineTask,
                    priorityTrack.Value
                );

                tasks.Add(task);
                SaveTaskToDatabase(task); // Save to db
                UpdateTaskList();

                // Default data
                textTaskName.Text = string.Empty;
                textTaskDescr.Text = string.Empty;

                // Default data
                monthCalendar.SelectionStart = DateTime.Now;
                monthCalendar.SelectionEnd = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Please fill in all fields before adding a task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Update task list
        private void UpdateTaskList()
        {
            dataGridView.Rows.Clear();
            foreach (var task in tasks)
            {
                dataGridView.Rows.Add(task.Name, task.Description, task.Deadline, $"{task.Priority} %");
                task.DisplayDetails(); // Выводим детали каждой задачи
            }
        }

        //  Save task to Database
        private void SaveTaskToDatabase(TaskBase task)
        {
            string query = @"INSERT INTO Task (Name, Description, Deadline, Priority, userID) 
                     VALUES (@Name, @Description, @Deadline, @Priority, @userID)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
                {
                    if (command.Connection.State == ConnectionState.Closed)
                    {
                        command.Connection.Open();
                    }

                    command.Parameters.AddWithValue("@userID", GlobalData.UserId);
                    command.Parameters.AddWithValue("@Name", task.Name);
                    command.Parameters.AddWithValue("@Description", task.Description);
                    command.Parameters.AddWithValue("@Deadline", task.Deadline);
                    command.Parameters.AddWithValue("@Priority", task.Priority);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Task saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to save task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dataBase.OpenConnection();
                    command.ExecuteNonQuery();
                    dataBase.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Buttons
        private void bttnEdit_Click(object sender, EventArgs e)
        {
            deadlineTask = monthCalendar.SelectionStart.ToString("dd.MM.yyyy");
            if (dataGridView.CurrentRow != null)
            {
                if (!String.IsNullOrWhiteSpace(textTaskName.Text) || !string.IsNullOrWhiteSpace(textTaskDescr.Text))
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
            if (dataGridView.CurrentRow != null)
            {
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

        //Load user photo to picture box or set dafault
        private void LoadUserData()
        {
            string query = "SELECT login, photo FROM [User] WHERE id = @userID";

            using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
            {
                command.Parameters.AddWithValue("@userID", GlobalData.UserId);

                dataBase.OpenConnection();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Display login and photo
                        string login = reader["login"].ToString();

                        if (reader["photo"] != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])reader["photo"];

                            // Convert BLOB to Image and display
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                userPhotoBox.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            // If there is no image, set the default image
                            userPhotoBox.Image = Properties.Resources.info;
                        }

                        // Display login
                        helloUserLogin.Text = login;
                    }
                }
                dataBase.CloseConnection();
            }
        }

        // Load tasks from the database
        private void LoadTasksFromDatabase()
        {
            string query = "SELECT name, description, deadline, priority FROM Task WHERE userID = @userID";

            using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
            {
                command.Parameters.AddWithValue("@userID", GlobalData.UserId);

                dataBase.OpenConnection();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Clear the DataGridView before loading new data
                    dataGridView.Rows.Clear();

                    while (reader.Read())
                    {
                        string taskName = reader["name"].ToString();
                        string taskDescription = reader["description"].ToString();
                        string deadline = reader["deadline"].ToString();
                        string priority = reader["priority"].ToString();

                        // Add a new row with the task data to the DataGridView
                        dataGridView.Rows.Add(taskName, taskDescription, deadline, priority);
                    }
                }
                dataBase.CloseConnection();
            }
        }

        // Exit
        private void bttnExit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
    }
}

