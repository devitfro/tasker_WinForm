using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace tasker
{

    public partial class RegistrationForm : Form
    {
        DataBase dataBase = new DataBase();

        public RegistrationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void loginRegistration_Changed(object sender, EventArgs e) { }

        private void userBirthday_DateChanged(object sender, DateRangeEventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void passwordRegistration_Changed(object sender, EventArgs e)
        {  
            passwordRegistration.PasswordChar = '*';
            passwordRegistrationRepeat.PasswordChar = '*';
        }

        private Boolean CheckUserLogin(string login)
        {
            var userLogin = loginRegistration.Text;

            string query = "SELECT login FROM [User]";
                
            using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
            {

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows) {
                    if (row["login"].ToString() == login)
                    {
                        MessageBox.Show("Such an account already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false; 
                    }
                }
                return true;
            }
        }

        private Boolean CheckPasswords()
        {
            if (string.IsNullOrWhiteSpace(passwordRegistration.Text) || string.IsNullOrWhiteSpace(passwordRegistrationRepeat.Text))
            {
                MessageBox.Show("Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (passwordRegistration.Text != passwordRegistrationRepeat.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (passwordRegistration.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null; // Если фото нет, вернуть null
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private bool CheckBirthday(DateTime birthday)
        {
            int age = DateTime.Now.Year - birthday.Year;

            if (DateTime.Now < birthday.AddYears(age))
                age--;
            if (age < 12)
            {
                MessageBox.Show("Not correct birthday date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void bttnCreateAcc_Click(object sender, EventArgs e)
        {
            if (!CheckUserLogin(loginRegistration.Text)) return;

            if (!CheckPasswords()) return;

            if (!CheckBirthday(userBirthdayDate.SelectionStart)) return;

            var userLogin = loginRegistration.Text;
            var userPassword = passwordRegistration.Text;        
            DateTime userBirthday = userBirthdayDate.SelectionStart; ;

            byte[] photoBytes = ImageToByteArray(userImgBox.Image);
           
            string query = photoBytes == null
                    ? "INSERT INTO [User] (login, password, birthday) VALUES(@login, @password, @birthday)"
                    : "INSERT INTO [User] (login, password, birthday, photo) VALUES(@login, @password, @birthday, @photo)";
            
            using (SqlCommand command = new SqlCommand(query, dataBase.GetConnection()))
            {
                command.Parameters.AddWithValue("@login", userLogin);
                command.Parameters.AddWithValue("@password", userPassword);
                command.Parameters.AddWithValue("@birthday", userBirthday);

                if (photoBytes != null)
                {
                    command.Parameters.AddWithValue("@photo", photoBytes);
                }

                dataBase.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {            
                    MessageBox.Show("Create an account successfully!");
                    WelcomeForm welcomeForm = new WelcomeForm();
                    welcomeForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
             //GetUserId();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Фильтр по типам файлов
                openFileDialog.Title = "Choose photo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    userImgBox.Image = Image.FromFile(openFileDialog.FileName); // Загружаем изображение
                }
            }
        }
    }
}
