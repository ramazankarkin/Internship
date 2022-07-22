// See https://aka.ms/new-console-template for more information

namespace ConsoleAppFirstTutorial
{

    public class Person
    {
        public string name;

        public void Introduce(String yName)
        {
            Console.WriteLine("Hi {0}, I am {1}", yName, name);
        }
        public static Person Parse(string str)
        {
            Person person = new Person();
            person.name = str;
            return person;
        }
    }
    class Program
    {

        static void Main(String[] args)
        {
            var person = Person.Parse("ramazan");
            person.Introduce("burak");

            var person2 = new Person();
            person2.name = "ali";
            person2.Introduce("enes");

            int num = 5;
            byte count = 1;
            float totalPrice = 12.42f;
            bool isTrue = false;
            var name = "ramazan";
            var lName = "karkin";
            Console.WriteLine(num);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(isTrue);
            Console.WriteLine("{0} {1}", byte.MaxValue, int.MinValue);

            try
            {
                var number = "32";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("This convertion could cause a crash.");
            }
            Console.WriteLine("------------Constructor--------------");
            var cus = new Customer(101, "Fenerbahce");
            Console.WriteLine(cus.Id);
            Console.WriteLine(cus.Name);

        

        }

    }

}







