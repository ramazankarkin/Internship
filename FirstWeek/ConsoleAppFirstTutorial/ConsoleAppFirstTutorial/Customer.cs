namespace ConsoleAppFirstTutorial
{
    public class Customer
    {
        public int Id;
        public string Name;


        public Customer()
        {
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;

        }
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }


}
