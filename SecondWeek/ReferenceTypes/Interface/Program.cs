
namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.AddPersonManager(new CustomerManager());
            projectManager.AddPersonManager(new EmployeeManager());   
        }
    }
    
    // interface'ler sadece method imzası veya property taşır. 
    // interface'den obje oluşturamayız.
    interface IPersonManager
    {
        //unimplemented operation
        void Add();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer added.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee added.");
        }
    }

    class ProjectManager
    {
        public void AddPersonManager(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}