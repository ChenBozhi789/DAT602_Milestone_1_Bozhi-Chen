using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAT602_MIlestone_One
{
    public class UserDAO
    {
        //private string connectionString = "Server=localhost:3306;Database=DAODb;User=root;Password=P@ssword1;";
        private string connectionString = "Server=localhost; Port=3306; Database=daodb; Uid=root; Pwd=P@ssword1;";

        public bool Register(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tb_User (Username, Email, Password) VALUES (@Username, @Email, @Password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to the query
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        
                        int result = cmd.ExecuteNonQuery();
                        Console.WriteLine("You have logged successfully");
                        // Check if the query was successful
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public bool Login(string email, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM tb_user WHERE email = @email AND password = @password";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        int countresult = Convert.ToInt32(cmd.ExecuteScalar());

                        // return whether user login or not
                        return countresult > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

                
            }
        }

    }
}
