namespace Chapter_02.HashTables
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
		}
	}

	class HashTable
	{
		private class MyNodes : List<MyNode> { }
		private int length;
		private MyNodes[] data;

		public HashTable(int size)
		{
			this.length = size;
			this.data = new MyNodes[size];	
		}

		private int Hash(string key)
		{
			int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
				hash = (hash + (int)key[i] * i) % this.length; 
            }
			return hash;
        }
		public void Set(string key, int value)
		{
			int index = Hash(key);
            if (this.data[index] == null)
            {
				this.data[index] = new MyNodes();
            }
			this.data[index].Add(new MyNode(key,value));
        }
	}
}
