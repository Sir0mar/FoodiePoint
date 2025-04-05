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

namespace FoodiePointManagementSystem
{
    public partial class ChefForm : Form
    {
        private string connectionString = "Server=LENO\\SQLEXPRESS;Database=FoodiePointDB;Integrated Security=True;";

        public ChefForm()
        {
            InitializeComponent();
        }

        private void ChefForm_Load(object sender, EventArgs e)

        {
            LoadOrders();
            LoadInventory();

        }
        private void LoadOrders()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT OrderID, CustomerID, OrderDate, Status FROM Orders";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvOrders.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("注文情報の読み込みエラー: " + ex.Message);
                }
            }
        }

        private void LoadInventory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IngredientID, IngredientName, Quantity, Price FROM Inventory";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvInventory.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ReadError of stock infomation: " + ex.Message);
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateOrderStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            string ingredientName = txtIngredientName.Text.Trim();
            int quantity;
            decimal price;

            if (string.IsNullOrWhiteSpace(ingredientName) ||
                !int.TryParse(txtQuantity.Text.Trim(), out quantity) ||
                !decimal.TryParse(txtPrice.Text.Trim(), out price))
            {
                MessageBox.Show("正しいデータを入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Inventory (IngredientName, Quantity, Price) VALUES (@IngredientName, @Quantity, @Price)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IngredientName", ingredientName);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("新しい食材を追加しました", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInventory();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("追加エラー: " + ex.Message);
                }
            }
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("更新する食材を選択してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ingredientId = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["IngredientID"].Value);
            int quantity;
            if (!int.TryParse(txtQuantity.Text.Trim(), out quantity))
            {
                MessageBox.Show("数量を正しく入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Inventory SET Quantity = @Quantity WHERE IngredientID = @IngredientID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@IngredientID", ingredientId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("在庫情報を更新しました", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInventory();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("更新エラー: " + ex.Message);
                }
            }
        }

        private void btnDeleteInventory_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("削除する食材を選択してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ingredientId = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["IngredientID"].Value);

            DialogResult confirm = MessageBox.Show("本当にこの食材を削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Inventory WHERE IngredientID = @IngredientID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@IngredientID", ingredientId);
                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("食材を削除しました", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadInventory();
                            }
                            else
                            {
                                MessageBox.Show("削除に失敗しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("削除エラー: " + ex.Message);
                    }
                }
            }
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string newEmail = txtProfileEmail.Text.Trim();
            string newPassword = txtProfilePassword.Text.Trim();

            if ( string.Equals(newEmail, "") || string.Equals(newPassword, ""))
            {
                MessageBox.Show("Enter correct ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int chefID = 3;
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Chef SET Email = @Email, Password = @Password WHERE ChefID = @ChefID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", newEmail);
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@ChefID", chefID);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Profile updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update error: " + ex.Message);
                }
            }
        }

        
        }
    }
    

