using Dapper.Contrib.Extensions;

namespace GroceryCrudDemo.Models
{
	[Table("category")]
	public class Category
	{
		[ExplicitKey]
		public string id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public string location { get; set; }
	}
}
