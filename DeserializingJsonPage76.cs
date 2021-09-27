using System;
using System.IO;
using Newtonsoft.Json;


namespace DeserializingJsonPage76
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\QaLearning\\jsonfile.json";
            string filecontent = File.ReadAllText(path);
            Product product = JsonConvert.DeserializeObject<Product>(filecontent);
            Console.WriteLine(product.ProductId);
            Console.WriteLine(product.Description);
            Console.WriteLine(product.Price);
        }
    }
}
