using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace BusinessV2Demo.Models
{
    public class DAL
    {
		public static MySqlConnection DB;
		public static List<Employee> GetAllEmployees()
		{
			return DB.GetAll<Employee>().ToList();
		}

		public static Employee GetOneEmployee(int id)
		{
			return DB.Get<Employee>(id);
		}

		public static Employee AddEmployee(Employee emp)
		{
			DB.Insert(emp);
			return emp;
		}
	}
}
