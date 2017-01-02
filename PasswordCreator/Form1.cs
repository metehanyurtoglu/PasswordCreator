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

namespace PasswordCreator
{
    public partial class Form1 : Form
    {
        public static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public static string numbers = "0123456789";
        public static string characters = "*/+-!^%&()=?_$#{[]}";

        public static string [] TruePassword;  //Global Password
        public Form1()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=PasswordDB;Integrated Security=True";
        SqlConnection connection = new SqlConnection(conString);

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtPassword.Text = null;

            if (txtPassword.Text == null)
            {
                MessageBox.Show("Lütfen Parola İçin Gerekli Kriterleri Giriniz!");
            }

            int size = Convert.ToInt32(comboBox1.SelectedItem);
            string[] password = new string[size];
            Random random = new Random();

            if (checkNumbers.Checked == true)  // Sadece Rakam Yazma..
            {
                for (int i = 0; i < size; i++)
                {
                    password[i] = numbers[random.Next(10)].ToString();
                }
            }

            if (checkAlphabet.Checked == true) // Sadece Harf Yazma...
            {
                for (int i = 0; i < size; i++)
                {
                    password[i] = alphabet[random.Next(52)].ToString();
                }
            }

            if (checkCharacter.Checked == true) // Sadece Karakter Yazma...
            {
                for (int i = 0; i < size; i++)
                {
                    password[i] = characters[random.Next(19)].ToString();
                }
            }

            if (checkNumbers.Checked == true && checkAlphabet.Checked == true) // Numara + Harf Yazma...
            { 

                for (int i = 0; i < size; i++)
                {
                    int a = random.Next(2);
                    if (a == 0)
                    {
                        password[i] = numbers[random.Next(10)].ToString();
                    }
                    if (a == 1)
                    {
                        password[i] = alphabet[random.Next(52)].ToString();
                    }
                }
            }

            if (checkNumbers.Checked == true && checkCharacter.Checked == true) // Numara + Karakter Yazma...
            {

                for (int i = 0; i < size; i++)
                {
                    int a = random.Next(2);
                    if (a == 0)
                    {
                        password[i] = numbers[random.Next(10)].ToString();
                    }
                    if (a == 1)
                    {
                        password[i] = characters[random.Next(19)].ToString();
                    }
                }
            }

            if (checkAlphabet.Checked == true && checkCharacter.Checked == true) // Harf + Karakter Yazma...
            {

                for (int i = 0; i < size; i++)
                {
                    int a = random.Next(2);
                    if (a == 0)
                    {
                        password[i] = alphabet[random.Next(52)].ToString();
                    }
                    if (a == 1)
                    {
                        password[i] = characters[random.Next(19)].ToString();
                    }
                }
            }

            if (checkNumbers.Checked == true && checkAlphabet.Checked == true && checkCharacter.Checked == true) // Numara + Harf + Karakter Yazma...
            {
                for (int i = 0; i < size; i++)
                {
                    int a = random.Next(3);
                    if (a == 0)
                    {
                        password[i] = numbers[random.Next(10)].ToString();
                    }
                    if (a == 1)
                    {
                        password[i] = alphabet[random.Next(52)].ToString();
                    }
                    if (a == 2)
                    {
                        password[i] = characters[random.Next(19)].ToString();
                    }
                }

            }

            for (int i = 0; i < password.Length; i++)  //Password Ekrana Yazma...
            {
                txtPassword.Text += password[i];
            }

            TruePassword = new string[size];
            for (int i = 0; i < password.Length; i++)  //Değişkenleri global yapma..
            {
                TruePassword[i]= password[i];
            }

        } //Password Oluşturma

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword == null)
            {
                MessageBox.Show("Lütfen Şifre Belirleyiniz!");
            }
            Form2 form = new Form2();
            form.ShowDialog();
        } //Password Kaydetme

        private void btnShow_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            connection.Open();

            
            string select = "SELECT * FROM PasswordTable";

            SqlCommand command = new SqlCommand(select,connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            form.dataGridViewPassword.DataSource = table;
            connection.Close();
        }
    }
}
