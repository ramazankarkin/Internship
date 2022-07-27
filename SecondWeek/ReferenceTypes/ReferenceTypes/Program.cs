
namespace ReferenceTypes
{
    class Program
    {
        static void Main(String[] args)
        {
            // value types: variables of these data types directly contain values.
            // Passing Value Type Variables : methodlarda value type gönderdiğimiz
            // zaman aslında bir kopyasını gönderiyoruz gibi düşünebiliriz.
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("Num1:" + num1);
            Console.WriteLine("Num2:" + num2);
            num1 = num2;
            num2 = 55;
            Console.WriteLine("Last Num1:" + num1);
            Console.WriteLine("Last Num2:" + num2);

            // string, array, class, interface
            // Unlike value types, a reference type doesn't store its value directly.Instead, it stores the address
            // where the value is being stored.In other words, a reference type contains a pointer to another 
            // memory location that holds the data.
            // Passing Reference Type Variable: methodlara reference type gönderidiğimiz zaman
            // aslında o değişkenin adresini göndermiş oluyoruz.
            int[] arr1 = new int[] { 8, 16, 23, 36, 42 };
            int[] arr2 = new int[] { 5, 9, 14, 26, 37 };

            // arr1 arr2'nin memory'de gösterdiği alanı gösteriyor artık
            arr1 = arr2;

            Console.WriteLine("Arr1:" + arr1[0]);
            Console.WriteLine("Arr2:" + arr2[0]);

            arr2[0] = 789;

            Console.WriteLine("Last Arr1:" + arr1[0]);
            Console.WriteLine("Last Arr2:" + arr2[0]);

            Person person1 = new Person();
            Person person2 = new Person();

            person2.FirstName = "Ramazan";

            // Person1 Person2'nin memory'de gösterdiği alanı gösteriyor artık
            person1 = person2;

            Console.WriteLine("Person2 FirstName:"+person1.FirstName);
            Console.WriteLine("Person2 LastName:"+person2.LastName);

            Customer customer = new Customer();
            // şimdi  Person person3 = customer ile beraber person3 ve customer ile aynı memory alanını gösteriyor sadece tek bir fark var.
            // person3 Person tipinde olduğu için customer'a ait property and methodlara ulaşamaz ulaşması için type cast yapılması lazım
            // mesela person3 CreditCardNumber property'sine ulaşamaz. (Customer(person3)) ancak bu şekilde boxing yaparsak ulaşabiliriz.
            Person person3 = customer;
            customer.FirstName = "Burak";
            Console.WriteLine("customer and person3 name:" + person3.FirstName);

            person3.FirstName = "Enes";
            Console.WriteLine("customer and person3 name:" + customer.FirstName);

            ((Customer)person3).CreditCardNumber = 46431346;
            
            Console.WriteLine("customer creditcardnumber:" + customer.CreditCardNumber);

            Console.WriteLine("-----------------------------------------------------------");

            Employee employee = new Employee();
            employee.FirstName = "Serkan";

            PersonManager personManager = new PersonManager();
            Console.WriteLine("Aşadaki isimler personManger.Add() methodu sonucu yazdırıldı.");
            personManager.Add(person1);
            // Normalde personManager.Add() methodu parametre olarak Person class'ı alıyor. biz Employee ve Customer class'larını
            // Person class'ından inherit ettiğimiz için onlarda birnevi Person class'ı sayılıyor.
            personManager.Add(employee);
            personManager.Add(customer);





        }
    }

    class Person //base class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    //Customer derived class
    class Customer: Person //Inheritance yani Customer'ın bir Person olduğunu söylüyoruz.
    {
        public int CreditCardNumber { get; set; }

    }

    //Employee derived class
    class Employee:Person //Inheritance yani Employee'in bir Person olduğunu söylüyoruz.
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }

    
}