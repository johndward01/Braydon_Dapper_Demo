using System.Data;
using Braydon_Dapper_Demo;
using MySql.Data.MySqlClient;


string connectionString = "Server=localhost;Database=bestbuy;Uid=root;Pwd=password;";

IDbConnection conn = new MySqlConnection(connectionString);

var repo = new EmployeeRepository(conn);

var employees = repo.GetAllEmployees();

foreach (var employee in employees)
{
    Console.WriteLine(employee.EmployeeID);
    Console.WriteLine(employee.FirstName);
    Console.WriteLine(employee.LastName);
    Console.WriteLine();
    Console.WriteLine();
}