﻿using System;
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

        private void txtLoginWelcome_Changed(object sender, EventArgs e) { }

        private Boolean CheckWelcomeUser()
        {
            var loginUser = loginWelcome.Text;
            var passwordUser = passwordWelcome.Text;

            string query = "SELECT id, password FROM [User] WHERE login = @login";

            try
            {
                using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
                {
                    command.Parameters.AddWithValue("@login", loginUser);

                    dataBase.OpenConnection();

                    // Используем ExecuteReader для получения данных
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) // Если строки найдены
                        {
                            // Читаем данные пользователя
                            reader.Read();
                            string storedPassword = reader["password"].ToString();

                            if (storedPassword == passwordUser)
                            {
                                // Если пароли совпадают
                                GlobalData.UserId = Convert.ToInt32(reader["id"]);
                                MessageBox.Show("You entered!", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                            else
                            {
                                // Если пароли не совпадают
                                MessageBox.Show("Incorrect password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // Если пользователь не найден
                            MessageBox.Show("User not registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка исключений
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            return false;
        }

        private void bttnEnterWelcome_Click(object sender, EventArgs e)
        {
            if (CheckWelcomeUser())
            {
                AppForm appForm = new AppForm();
                this.Hide();
                appForm.ShowDialog();
            }       
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

        private void WelcomeForm_Load(object sender, EventArgs e) { }
    }
}
