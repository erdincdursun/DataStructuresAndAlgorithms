namespace Chapter_04.StacksQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---LinkedList---");
            CustomStackLinkedList stack = new CustomStackLinkedList();
            stack.Push("Google");
            stack.Push("Udemy");
            stack.Push("Discord");
            stack.PrintStack();
            Console.WriteLine($"LinkedList Pop : {stack.Pop()}\n");

            Console.WriteLine("---Array---");
            CustomStackArray stackArray = new CustomStackArray();
            stackArray.Push("Google");
            stackArray.Push("Udemy");
            stackArray.Push("Discord");
            stackArray.PrintStack();
            Console.WriteLine($"ArrayList Pop : {stackArray.Pop()}");
        }
    }
}
