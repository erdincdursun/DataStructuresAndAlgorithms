using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_02.HashTables
{
	public class HashTable
	{
		private class MyNodes : List<MyNode> { }
		private int Length;
		private MyNodes[] Data;

		public HashTable(int size)
		{
			this.Length = size;
			this.Data = new MyNodes[size];
		}
		private int Hash(string key)
		{
			int hash = 0;
			for (int i = 0; i < key.Length; i++)
			{
				hash = (hash + (int)key[i] * i) % this.Length;
			}
			return hash;
		}
		public void Set(string key, int value)
		{
			int index = Hash(key);
			if (this.Data[index] == null)
			{
				this.Data[index] = new MyNodes();
			}
			this.Data[index].Add(new MyNode(key, value));
		}
		public int Get(string key)
		{
			int index = Hash(key);
			if (this.Data[index] == null)
			{
				return 0;
			}
			foreach (var node in this.Data[index])
			{
				if (node.Key.Equals(key))
				{
					return node.Value;
				}
			}
			return 0;
		}
		public List<string> Keys()
		{
			List<string> result = new List<string>();
			for (int i = 0; i < this.Data.Length; i++)
			{
				if (this.Data[i] != null)
				{
					for (int j = 0; j < this.Data[i].Count; j++)
					{
						result.Add(this.Data[i][j].Key);
					}
				}
			}
			return result;
		}
	}
}

