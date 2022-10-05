using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;

MySqlConnection DB = new MySqlConnection("Server=127.0.0.1;Database=business_fk;Uid=root;Pwd=abc123;");

Employee emp = new Employee() { firstname = "Charmaine", lastname = "Bidelspach", 
	phone = "248-789-9876", email = "cbidelspach@abc.net", department_id = "DEV", 
	hiredate = new DateTime(2022, 10, 4) };

DB.Insert(emp);

[Table("employee")]
public class Employee
{
	[Key]
	public int id { get; set; }
	public string firstname { get; set; }
	public string lastname { get; set; }
	public string phone { get; set; }
	public string email { get; set; }
	public string department_id { get; set; }
	public DateTime hiredate { get; set; }
}
