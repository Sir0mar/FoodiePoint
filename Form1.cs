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
using System.Data.SqlTypes;


namespace FoodiePointManagementSystem
{
    public partial class Form1 : Form
    {

        string connectionString = "Server=LENO\\SQLEXPRESS;Database=FoodiePointDB;Integrated Security=True;";



        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 入力された値を取得
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // 入力チェック
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


          

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Role FROM Users WHERE UserName=@UserName AND Password=@Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        var role = cmd.ExecuteScalar();

                        if (role != null)
                        {
                            MessageBox.Show($"Login Successful! Role: {role}");

                            // ユーザーの役割に応じてフォームを開く
                            Form userForm;
                            switch (role.ToString())
                            {
                                case "Admin":
                                    userForm = new AdminForm();
                                    break;
                                case "Manager":
                                    userForm = new ManagerForm();
                                    break;
                                case "Chef":
                                    userForm = new ChefForm();
                                    break;
                                case "Reservation Coordinator":
                                    userForm = new ReservationForm();
                                    break;
                                case "Customer":
                                    userForm = new CustomerForm();
                                    break;
                                default:
                                    userForm = null;
                                    break;
                            }

                            if (userForm != null)
                            {
                                userForm.Show();
                                this.Hide(); // Hide login form

                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}