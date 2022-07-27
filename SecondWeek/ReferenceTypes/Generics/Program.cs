
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> city = new List<string>();
            city.Add("aydın");
            city.Add("adıyaman");
            city.Add("aydın");
            city.Add("adıyaman");
            Console.WriteLine(city.Count);

            Mylist<string> mylist = new Mylist<string>();
            mylist.Add("ramazan");
            mylist.Add("ramazan");
            mylist.Add("ramazan");
            Console.WriteLine(mylist.Count);


        }
    }

    class Mylist<T> // Generic class
    {
        T[] _array;
        T[] _tempArray;

        public Mylist()
        {
            _array = new T[0];

        }
        public void Add(T item)// bu method her çağrıldığında eleman sayısı bir artıcak.
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i]= _tempArray[i];
            }
            _array[_array.Length-1] = item;
        }

        public int Count { get { return _array.Length; } }  
    }
}