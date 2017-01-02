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
using System.Data.Sql;
namespace PasswordCreator
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=PasswordDB;Integrated Security=True";
        SqlConnection connection = new SqlConnection(conString);

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 otherForm = new Form1();
            if (otherForm.txtPassword == null)
            {
                MessageBox.Show("Lütfen Şifre Belirleyiniz!");
            }
            else
            {
                for (int i = 0; i < Form1.TruePassword.Length; i++)
                {
                    txtSavePassword.Text += Form1.TruePassword[i];
                }
                txtSaveDate.Text = DateTime.Now.ToString();
                
            }
        }

        private void btnSaveSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string create = "insert into PasswordTable(Password,Instruction,Date)values(@_password,@_instruction,@_date)";
                    SqlCommand command = new SqlCommand(create, connection);
                    command.Parameters.AddWithValue("@_password", txtSavePassword.Text);
                    command.Parameters.AddWithValue("@_instruction", txtSaveInstruction.Text);
                    command.Parameters.AddWithValue("@_date", DateTime.Now);
                    command.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Şifre Kaydedildi!","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Hata Oluştu" + error.Message);
            }
        }

    }
}
