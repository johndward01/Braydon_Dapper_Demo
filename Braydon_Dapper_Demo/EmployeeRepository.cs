using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braydon_Dapper_Demo;
internal class EmployeeRepository
{
    private readonly IDbConnection _conn;

	public EmployeeRepository(IDbConnection conn)
	{
		_conn = conn;
	}

	public IEnumerable<Employee> GetAllEmployees()
	{
		return _conn.Query<Employee>("SELECT * FROM Employees;");
	}

}
