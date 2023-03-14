namespace Clothes
{
    using Microsoft.Data.SqlClient;
    using System.Data;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void onSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(Config.ConnectionString);
                conn.Open();
                string query = "UPDATE products SET price = price * 0.75";
                using SqlCommand command = new SqlCommand(query, conn);
                int rowsAffected = command.ExecuteNonQuery();
                using SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.Visible = true;
                dataGridView1.DataSource = table;
                MessageBox.Show($"{rowsAffected} rows updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void jeansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection sqlConnection = new SqlConnection(Config.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.GetCountOfCloth, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@cloth", "Jeans");
                int count = (int)sqlCommand.ExecuteScalar();
                richTextBox1.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void shirtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection sqlConnection = new SqlConnection(Config.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.GetCountOfCloth, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@cloth", "Shirts");
                int count = (int)sqlCommand.ExecuteScalar();
                richTextBox1.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void sweatshirtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection sqlConnection = new SqlConnection(Config.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.GetCountOfCloth, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@cloth", "Sweatshirts");
                int count = (int)sqlCommand.ExecuteScalar();
                richTextBox1.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void shoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection sqlConnection = new SqlConnection(Config.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.GetCountOfCloth, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@cloth", "Shoes");
                int count = (int)sqlCommand.ExecuteScalar();
                richTextBox1.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection sqlConnection = new SqlConnection(Config.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.GetCountOfCloth, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@cloth", "Dresses");
                int count = (int)sqlCommand.ExecuteScalar();
                richTextBox1.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void underwearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection sqlConnection = new SqlConnection(Config.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.GetCountOfCloth, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@cloth", "Underwear");
                int count = (int)sqlCommand.ExecuteScalar();
                richTextBox1.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void accessoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection sqlConnection = new SqlConnection(Config.ConnectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(SqlQueries.GetCountOfCloth, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@cloth", "Accessoaries");
                int count = (int)sqlCommand.ExecuteScalar();
                richTextBox1.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void productPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(Config.ConnectionString);
                conn.Open();
                string query = "SELECT [name], [price] FROM products ORDER BY [name]";
                using SqlCommand command = new SqlCommand(query, conn);
                using SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.Visible = true;
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
            try
            {
                string query = "SELECT u.username FROM orders AS o " +
                               "LEFT JOIN users AS u ON u.id = o.user_id " +
                               "WHERE o.order_date > @date";

                using (SqlConnection connection = new SqlConnection(Config.ConnectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlParameter dateParam = new SqlParameter("@date", SqlDbType.DateTime);
                    dateParam.Value = dateTime;
                    command.Parameters.Add(dateParam);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(Config.ConnectionString);
                conn.Open();
                string query = "UPDATE products SET price = 49.99 WHERE id = 1 " +
                    "UPDATE products SET price = 15.99 WHERE id = 2" +
                    "UPDATE products SET price = 59.99 WHERE id = 3" +
                    "UPDATE products SET price = 24.99 WHERE id = 4" +
                    "UPDATE products SET price = 39.99 WHERE id = 5" +
                    "UPDATE products SET price = 49.99 WHERE id = 6" +
                    "UPDATE products SET price = 119.99 WHERE id = 7" +
                    "UPDATE products SET price = 14.99 WHERE id = 8" +
                    "UPDATE products SET price = 39.99 WHERE id = 9" +
                    "UPDATE products SET price = 29.99 WHERE id = 10" +
                    "UPDATE products SET price = 34.99 WHERE id = 11" +
                    "UPDATE products SET price = 49.99 WHERE id = 12";
                using SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
                {
                    conn.Open();
                    string query = "UPDATE products SET price = price * 0.5";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} rows updated successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
                {
                    conn.Open();
                    string query = "UPDATE products SET price = price * 0.4";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} rows updated successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
                {
                    conn.Open();
                    string query = "UPDATE products SET price = price * 0.3";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} rows updated successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT username,email FROM users";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }
    }
}