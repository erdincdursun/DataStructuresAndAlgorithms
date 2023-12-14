namespace Chapter_04.StacksQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Stack : LinkedList---");
            CustomStackLinkedList stack = new CustomStackLinkedList();
            stack.Push("Google");
            stack.Push("Udemy");
            stack.Push("Discord");
            stack.PrintStack();
            Console.WriteLine($"LinkedList Pop : {stack.Pop()}\n");

            Console.WriteLine("---Stack : Array---");
            CustomStackArray stackArray = new CustomStackArray();
            stackArray.Push("Google");
            stackArray.Push("Udemy");
            stackArray.Push("Discord");
            stackArray.PrintStack();
            Console.WriteLine($"ArrayList Pop : {stackArray.Pop()}\n");


            Console.WriteLine("---Queue : LinkedList---");
            CustomQueueLinkedList queue = new CustomQueueLinkedList();
            queue.Enqueue("Busra");
            queue.Enqueue("Erdinc");
            queue.Enqueue("Ayse");
            queue.Enqueue("Zeynep");
            queue.Enqueue("Ömer");
            queue.Enqueue("Mila");
            queue.Peek();
            queue.Dequeue();
            queue.PrintList();
        }
    }
}
