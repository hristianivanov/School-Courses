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
                using SqlCommand command = new SqlCommand(SqlQueries.SetTwentyFivePercentSale, conn);
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
                SqlCommand command = new SqlCommand(SqlQueries.ShowProductPrice, conn);
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
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(Config.ConnectionString);
                conn.Open();
                SqlCommand command = new SqlCommand(SqlQueries.ResetPrices, conn);
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
                using SqlConnection conn = new SqlConnection(Config.ConnectionString);
                conn.Open();
                SqlCommand command = new SqlCommand(SqlQueries.SetFiftyPercentSale, conn);
                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show($"{rowsAffected} rows updated successfully.");
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
                using SqlConnection conn = new SqlConnection(Config.ConnectionString);
                conn.Open();
                using SqlCommand command = new SqlCommand(SqlQueries.SetSixtyPercentSale, conn);
                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show($"{rowsAffected} rows updated successfully.");
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
                using SqlConnection conn = new SqlConnection(Config.ConnectionString);
                conn.Open();
                SqlCommand command = new SqlCommand(SqlQueries.SetSeventyPercentSale, conn);
                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show($"{rowsAffected} rows updated successfully.");
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
                using SqlConnection conn = new SqlConnection(Config.ConnectionString);
                conn.Open();
                SqlCommand command = new SqlCommand(SqlQueries.ShowAllUsers, conn);
                using SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void productSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(Config.ConnectionString);
                conn.Open(); 
                using SqlCommand command = new SqlCommand(SqlQueries.ShowProductSizes, conn);
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
    }
}