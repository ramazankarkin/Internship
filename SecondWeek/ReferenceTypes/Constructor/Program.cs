
namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Path 
            Customer customer1 = new Customer();
            customer1.Id = 2;
            customer1.Name = "Mehmet";
            customer1.LastName = "Nar";
            customer1.Lesson = "3038";

            // 2.Path
            Customer customer2 = new Customer()
            {
                Id = 1,
                Name = "Ali",
                LastName = "Kavun",
                Address = "Adana",
                Lesson = "3044"
                
            };

            // 3.Path
            Customer customer3 = new Customer(5, "Hazal", "Çiçek", "Kayseri", "3048");



        }
    }

    class Customer
    {
        public Customer()
        {

        }

        public Customer(int id, string name, string lastName, string address, string lesson)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Address = address;
            Lesson = lesson;

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        private string lesson;

        public string Lesson
        {
            get { return "CSE_" + lesson; }
            set { lesson = value; }
        }

    }
}