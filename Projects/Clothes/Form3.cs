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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    command.Parameters.AddWithValue("@date", dateTime);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    StringBuilder stringBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        stringBuilder.AppendLine(reader[0].ToString());
                    }
                    MessageBox.Show(stringBuilder.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
