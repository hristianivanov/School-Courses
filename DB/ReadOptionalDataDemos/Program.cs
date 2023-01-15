using Microsoft.Data.SqlClient;

namespace ReadOptionalDataDemos
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            string input;
            while (true)
            {

            }
            string connString = @"Server=.\SQLEXPRESS;Database=firm;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                string queryString = "select concat(first_name,' ',last_name) from employees where job_title = 'Production Supervisor'";
                SqlCommand command = new SqlCommand(queryString, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        Console.WriteLine(reader[0]);
                }
            }
        }
    }
}