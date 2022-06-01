using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace codebase3
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exam out started please press enter key...!");
            Console.ReadLine();
            var datasource = @"POOLW42SLPC6930\\SQLEXPRESS";//My server name
            var database = "EmployeeManagement"; //My database name
            var username = "sa"; //username of server to connect
            var password = "Temp1234"; //password
            int empNumber;
            //your connection string 
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            //create instanace of database connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();

                using (SqlCommand command = new SqlCommand("SELECT MAX(empno) AS ID FROM Code_Employee", conn))
                {
                    empNumber = Convert.ToInt32(command.ExecuteScalar()) + 1;

                }
                Console.WriteLine("Connection successful!");
                StringBuilder strBuilder = new StringBuilder();
                Console.WriteLine("Please enter employee name...!");
                string EmployeeName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Please enter employee salary...!");
                double EmployeeSal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter employee type eithr (C or P)");
                string EmployeeType = Convert.ToString(Console.ReadLine());

                using (var cmd = conn.CreateCommand())
                {
                    Console.WriteLine("Query execution Started ...");

                    cmd.CommandText = "InsertEmployeeProcdure";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empno", empNumber);
                    cmd.Parameters.AddWithValue("@empname", EmployeeName);
                    cmd.Parameters.AddWithValue("@empsal", EmployeeSal);
                    cmd.Parameters.AddWithValue("@emptype", EmployeeType);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Query execution end ...");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("clossing Connection ...");
            }
            Console.Read();
        }
    }
}
