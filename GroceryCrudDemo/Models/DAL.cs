using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace GroceryCrudDemo.Models
{

	// Functionality to access our data.
	// This is the "data access layer"

	public class DAL
	{
		public static MySqlConnection DB = new MySqlConnection("Server=127.0.0.1;Database=grocerystore;Uid=root;Pwd=abc123;");

		// CRUD operations for our Category table

		// Read all

		public static List<Category> GetAllCategories()
		{
			// Throughout our app, any time we need to get a list of all categories, we just call
			//      DAL.GetAllCategories();
			return DB.GetAll<Category>().ToList();
		}

		// Read one
		public static Category GetOneCategory(string id)
		{
			return DB.Get<Category>(id);
		}

		// Create one (insert)
		public static Category InsertCategory(Category cat)
		{
			DB.Insert<Category>(cat);
			return cat;
		}

		// Delete one
		public static void DeleteCategory(string id)
		{
			Category cat = new Category();
			cat.id = id;
			// or
			// Category cat = new Category() { id = id };
			DB.Delete<Category>(cat);
		}


		// Update one (Users prefer the term "edit")
		public static void UpdateCategory(Category cat)
		{
			DB.Update<Category>(cat);
		}

		// CRUD operations for our Product table

		// Read all

		// Read one

		// Create one (insert)

		// Delete one

		// Update one (Users prefer the term "edit")
		
	}
}
