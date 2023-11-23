namespace Chapter_01.CustomArrayClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray();

            myArray.Push("Hello");
            myArray.Push("BusBus");
            myArray.Push("!");
            myArray.Pop();

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray.Get(i));
            }

        }
    }
}
