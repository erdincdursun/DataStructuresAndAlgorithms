namespace Chapter_02.HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable hash = new HashTable(50);
            hash.Set("grapes", 1000);
            hash.Set("apples", 54);
            hash.Set("orange", 2);

            Console.WriteLine(hash.Get("grapes"));
            hash.Keys();
        }
    }
}



