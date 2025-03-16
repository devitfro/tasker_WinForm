using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasker
{
    public partial class WelcomeForm : Form
    {

        DataBase dataBase = new DataBase();

        public WelcomeForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }


        private void bttnEnterWelcome_Click(object sender, EventArgs e)
        {
            var loginUser = loginWelcome.Text;
            var passwordUser = passwordWelcome.Text;

            string query = "SELECT id, login, password FROM [User] WHERE login = @login AND password = @password";

            using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
            {
                command.Parameters.AddWithValue("@login", loginUser);
                command.Parameters.AddWithValue("@password", passwordUser);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("You enter!", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AppForm appForm = new AppForm();
                    this.Hide();
                    appForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You not enter!", "No!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtLoginWelcome_Changed(object sender, EventArgs e)
        {

        }

        private void txtPasswordWelcome_Changed(object sender, EventArgs e)
        {
            passwordWelcome.PasswordChar = '*';
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registForm = new RegistrationForm();

            registForm.Show();
            this.Hide();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
