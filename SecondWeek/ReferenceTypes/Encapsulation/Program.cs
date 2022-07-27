
namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Hasan";
            customer.SurName = "Limon";
            customer.Address = "Samsun";
            customer.Id = 24534546;

            Customer customer2 = new Customer()
            {
                //Object initializer
                Name = "Ali",
                SurName = "Karpuz",
                Address = "Nevşehir",
                Id = 461238,
                MyLesson = "3063"
                


            };
            Console.WriteLine(customer2.MyLesson);
        }
    }

    class Customer
    {

        public string MiddleName; // Field
        public string Name { get; set; } // Property
        public string SurName { get; set; } = "portakal";
        public string Address { get; set; }
        public int Id { get; set; }

        private string myVar;
        public string MyLesson
        {
            get { return "CSE_" + myVar; }
            set { myVar = value; }
        }

    }
}