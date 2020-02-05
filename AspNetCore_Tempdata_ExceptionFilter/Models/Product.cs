using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore_Tempdata_ExceptionFilter.Models
{
	public class Product
	{
		[Required(ErrorMessage = "ProductId is required")]
		public int ProductId { get; set; }
		[Required(ErrorMessage = "Product Name is required")]
		public string ProductName { get; set; }
		[Required(ErrorMessage = "Manufacturer is required")]
		public string Manufacturer { get; set; }
		[Required(ErrorMessage = "CategoryId is required")]
		public int CategoryId { get; set; }
		[Required(ErrorMessage = "Price is required")]
		public int Price { get; set; }
	}
	public class Products : List<Product>
	{
		public Products()
		{
			Add(new Product() { ProductId = 10001, ProductName = "Laptop", Manufacturer = "HP", Price = 90300, CategoryId = 101 });
			Add(new Product() { ProductId = 10002, ProductName = "Iron", Manufacturer = "Bajaj", Price = 2300, CategoryId = 102 });
			Add(new Product() { ProductId = 10003, ProductName = "Biscuts", Manufacturer = "Parle", Price = 20, CategoryId = 103 });
			Add(new Product() { ProductId = 10004, ProductName = "Desktop", Manufacturer = "IBM", Price = 60300, CategoryId = 101 });
			Add(new Product() { ProductId = 10005, ProductName = "Mixer", Manufacturer = "Godrej", Price = 4500, CategoryId = 102 });
			Add(new Product() { ProductId = 10006, ProductName = "Maggie", Manufacturer = "Nestle", Price = 40, CategoryId = 103 });
			Add(new Product() { ProductId = 10007, ProductName = "RAM", Manufacturer = "Asus", Price = 6000, CategoryId = 101 });
			Add(new Product() { ProductId = 10008, ProductName = "Fan", Manufacturer = "Crompton", Price = 5000, CategoryId = 102 });
			Add(new Product() { ProductId = 10009, ProductName = "Pasta", Manufacturer = "Britinia", Price = 90, CategoryId = 103 });
		}
	}
}
