
namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>()
            {
                new Category() { CategoryId = 1, CategoryName = "Computer"},
                new Category() { CategoryId = 2, CategoryName = "Phone" },
                new Category() { CategoryId = 3, CategoryName = "Electronic" }


            };

            List<Product> products = new List<Product>()
            {
                new Product() {ProductId=1, CategoryId=1, ProductName="Dell", QuantityPerUnit = 12, UnitPrice =35, UnitsInStock = 32 },
                new Product() {ProductId=2, CategoryId=2, ProductName="Iphone", QuantityPerUnit = 5, UnitPrice =3, UnitsInStock = 6 },
                new Product() {ProductId=3, CategoryId=2, ProductName="Xiaomi", QuantityPerUnit = 53, UnitPrice =12, UnitsInStock =9 },
                new Product() {ProductId=4, CategoryId=3, ProductName="Iron", QuantityPerUnit = 42, UnitPrice =68, UnitsInStock = 14 },
                new Product() {ProductId=5, CategoryId=3, ProductName="Fridge", QuantityPerUnit = 27, UnitPrice =17, UnitsInStock = 1 },
                new Product() {ProductId=6, CategoryId=3, ProductName="Car", QuantityPerUnit = 9, UnitPrice =53, UnitsInStock = 4 },


            };

            // Linq
            var result = products.Where(p => p.QuantityPerUnit > 30 && p.UnitsInStock < 15);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }

        GetProducts(products);

        }

        static List<Product> GetProducts(List<Product> products)
        {   // Linq
            return products.Where(p => p.QuantityPerUnit > 30 && p.UnitsInStock < 15).ToList();
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


    }
}
