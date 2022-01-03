using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> Employees = new List<Employee>();
            string connectionString = "Data Source=desktop-l8k7db0;Initial Catalog=MyOfficeDB;Integrated Security=True;Pooling=False";
            ////AddEmployee(connectionString);
            ////UpdateEmployee(connectionString);
            //DeleteEmployee(connectionString);

            List<Manager> managers =new List<Manager>();
            //SqlDataShow(connectionString);
            //AddManager(connectionString);
            UpdateManager(connectionString);
        }
        static void SqlData(string connectionString)
        {
            //try and catch for exceptions
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Employee";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataFromDB = command.ExecuteReader();
                    if (dataFromDB.HasRows)
                    {
                        while (dataFromDB.Read())
                        {
                            Console.WriteLine(dataFromDB.GetString(0));
                        }
                    }
                    else
                    {
                        Console.WriteLine("no rows in table");
                    }
                }
            }
            catch (SqlException err)
            {
                Console.WriteLine(err.Message);
            }
            catch (Exception)
            {

            }
        }
        static void AddEmployee(string connectionString)
        {
            Console.WriteLine("enter name");
            string Name = Console.ReadLine();
            Console.WriteLine("enter birthday");
            string BirthDate = Console.ReadLine();
            Console.WriteLine("enter email");
            string Email = Console.ReadLine();
            Console.WriteLine("enter salary");
            int Salary = int.Parse(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $@"INSERT INTO Employee(Name,BirthDate,Email,Salary)
                          VALUES('{Name}','{BirthDate}','{Email}',{Salary})";

                SqlCommand command = new SqlCommand(query, connection);

                int rowEffected = command.ExecuteNonQuery();
                Console.WriteLine(rowEffected);
                connection.Close();

            }
            //SqlCommand command = new SqlCommand(query, connectionString);
        }
        static void UpdateEmployee(string connectionString)
        {
            Console.WriteLine("enter new id");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter new name");
            string Name = Console.ReadLine();
            Console.WriteLine("enter new birthday");
            string BirthDate = Console.ReadLine();
            Console.WriteLine("enter new email");
            string Email = Console.ReadLine();
            Console.WriteLine("enter new salary");
            int Salary = int.Parse(Console.ReadLine());
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $@"UPDATE Employee
                             SET Name='{Name}',BirthDate='{BirthDate}',Email='{Email}'
                              ,Salary='{Salary}'
                                WHERE Id={Id}";

                SqlCommand command = new SqlCommand(query, connection);

                int rowEffected = command.ExecuteNonQuery();
                Console.WriteLine(rowEffected);
                connection.Close();

            }
        }
        static void DeleteEmployee(string connectionString)
        {
            Console.WriteLine("enter id");
            string Id = Console.ReadLine();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                string query = $@"DELETE FROM Employee
                               WHERE Id={Id}";

                SqlCommand command = new SqlCommand(query, connection);

                int rowEffected = command.ExecuteNonQuery();
                Console.WriteLine(rowEffected);
                connection.Close();
            }
        }

        static void SqlDataShow(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Manager";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataFromDB = command.ExecuteReader();
                    if (dataFromDB.HasRows)
                    {
                        while (dataFromDB.Read())
                        {
                            Console.WriteLine(dataFromDB.GetString(0));
                        }
                    }
                    else
                    {
                        Console.WriteLine("no rows in table");
                    }
                }
            }
            catch (SqlException err)
            {
                Console.WriteLine(err.Message);
            }
            catch (Exception)
            {

            }
        }

        static void AddManager(string connectionString)
        {
            Console.WriteLine("enter fname");
            string FName = Console.ReadLine();
            Console.WriteLine("enter lname");
            string LName = Console.ReadLine();
            Console.WriteLine("enter birthday");
            string BirthDate = Console.ReadLine();
            Console.WriteLine("enter email");
            string Email = Console.ReadLine();
            Console.WriteLine("enter department");
            string Department = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $@"INSERT INTO Manager(FName,LName,BirthDay,Email,Department)
                          VALUES('{FName}','{LName}','{BirthDate}','{Email}','{Department}')";

                SqlCommand command = new SqlCommand(query, connection);

                int rowEffected = command.ExecuteNonQuery();
                Console.WriteLine(rowEffected);
                connection.Close();

            }
        }

        static void UpdateManager(string connectionString)
        {
            Console.WriteLine("enter new id");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter fname");
            string FName = Console.ReadLine();
            Console.WriteLine("enter lname");
            string LName = Console.ReadLine();
            Console.WriteLine("enter birthday");
            string BirthDate = Console.ReadLine();
            Console.WriteLine("enter email");
            string Email = Console.ReadLine();
            Console.WriteLine("enter department");
            string Department = Console.ReadLine();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $@"UPDATE Manager
                             SET fname='{FName}',LName='{LName}',BirthDay='{BirthDate}'
                              ,Email='{Email}',Department='{Department}'
                                WHERE Id={Id}";

                SqlCommand command = new SqlCommand(query, connection);

                int rowEffected = command.ExecuteNonQuery();
                Console.WriteLine(rowEffected);
                connection.Close();

            }
        }
    }
} 
