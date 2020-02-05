using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore_Tempdata_ExceptionFilter.Models
{
	public class Category
	{
		[Required(ErrorMessage ="CategoryId is required")]
		public int CategoryId { get; set; }
		[Required(ErrorMessage = "Category Name required")]
		public string CategoryName { get; set; }
		[Required(ErrorMessage = "Base Price is required")]
		public int BasePrice { get; set; }
	}

	public class Categories : List<Category>
	{
		public Categories()
		{
			Add(new Category() { CategoryId = 101, CategoryName = "Electronics", BasePrice = 20000 });
			Add(new Category() { CategoryId = 102, CategoryName = "Electrical", BasePrice = 100 });
			Add(new Category() { CategoryId = 103, CategoryName = "Food", BasePrice = 20 });
		}
	}
}
