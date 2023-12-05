namespace Chapter_03.LinkedLists
{
    public class LinkedList
    {
        private Node Head;
        private Node Tail;
        private int Length;

        public LinkedList(Object value)
        {
            this.Head = new Node(value);
            this.Tail = this.Head;
            this.Length = 1;
        }

        public void Append(Object value)
        {
            Node newNode = new Node(value);
            this.Tail.Next = newNode;
            this.Tail = newNode;
            this.Length++;
        }

        public void Prepend(Object value)
        {
            Node newNode = new Node(value);
            newNode.Next = this.Head;
            this.Head = newNode;
            this.Length++;
        }
        public void PrintList()
        {
            if (this.Head == null) return;
            Node current = this.Head;
            while (current != null)
            {
                Console.Write("--->" + current.Value);
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void Insert(int index, Object value)
        {
            if (index >= this.Length)
            {
                Append(value);
                return;
            }
            if (index <= 0)
            {
                Prepend(value);
                return;
            }
            Node newNode = new Node(value);
            Node leader = TraversalIndex(index - 1);
            Node holdingPointer = leader.Next;
            leader.Next = newNode;
            newNode.Next = holdingPointer;
            this.Length++;
        }

        private Node TraversalIndex(int index)
        {
            int counter = 0;
            Node currentNode = Head;
            while (counter != index)
            {
                currentNode = currentNode.Next;
                counter++;
            }
            return currentNode;
        }

        public void Remove(int index)
        {
            if (index == 0)
            {
                Head = Head.Next;
                return;
            }
            Node leader = TraversalIndex(index - 1);
            Node nodeToRemove = leader.Next;
            leader.Next = nodeToRemove.Next;
            this.Length--;
        }

        public void Reverse()
        {
            // 1. İlk adım, başlangıç durumunu ayarlamaktır.
            Node first = Head;  // Bağlı listenin başlangıcındaki düğümü first değişkenine atar.
            Tail = Head;        // Tail (kuyruk) değişkenini de Head'e eşitleyerek, ters çevrildikten sonra yeni başı göstermesini sağlar.
            Node second = first.Next;  // İlk düğümün ardındaki düğümü second değişkenine atar.

            // 2. Ters çevirme işlemi bir döngü içinde gerçekleştirilir.
            for (int i = 0; i < Length - 1; i++)
            {
                // 3. Geçici bir değişken olan 'temp' kullanılarak düğümlerin yerleri değiştirilir.
                Node temp = second.Next;  // İkinci düğümün ardındaki düğümü temp değişkenine atar.
                second.Next = first;      // İkinci düğümü birinci düğümün önüne bağlar.
                first = second;           // first değişkenini bir sonraki adım için günceller.
                second = temp;            // second değişkenini bir sonraki adım için günceller.
            }

            // 4. Ters çevirme işlemi tamamlandığında, baştaki düğümün Next'i null olarak ayarlanır ve Head güncellenir.
            Head.Next = null;  // Bağlı listenin başındaki düğümün Next'i null olarak ayarlanır.
            Head = first;      // Head, ters çevrilmiş liste başını gösterir.
        }

        public int GetLength()
        {
            return this.Length;
        }
        public Node GetHead()
        {
            return this.Head;
        }
        public Node GetTail()
        {
            return this.Tail;
        }

    }
}
