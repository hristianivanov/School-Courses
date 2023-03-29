using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            try
            {
                using SqlConnection conn = new SqlConnection(Config.ConnectionString);
                conn.Open();
                string query = "SELECT username,email FROM users WHERE username = @username";
                using SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@username", username);
                using SqlDataReader reader = command.ExecuteReader();
                MessageBox.Show(reader.HasRows ? "User has been found" : "User doesn't exist");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
