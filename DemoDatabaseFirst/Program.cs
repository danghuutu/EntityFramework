// See https://aka.ms/new-console-template for more information
using DemoDatabaseFirst.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStore1Context myStore1 = new MyStore1Context();
            var products = from p in myStore1.Products
                           select new { p.ProductName, p.CategoryId };
            foreach (var product in products)
            {
                Console.WriteLine($"ProductName: {product.ProductName}, CategoryID: {product.CategoryId}");
            }
            Console.WriteLine("---------------------------------");
            IQueryable<Category> cats = myStore1.Categories.Include(c => c.Products);
            foreach (var category in cats)
            {
                Console.WriteLine($"CategoryID: {category.CategoryId} has {category.Products.Count} products.");
            }
            Console.ReadLine();
        }
    }
}