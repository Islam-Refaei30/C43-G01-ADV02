using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
	internal class FixedSizeList<T>
	{
		private readonly T[] Items;
		private readonly int Capacity;
		private  int Count;

		public FixedSizeList(int Capacity)
		{
			if (Capacity > 0)
			{
				this.Capacity = Capacity;
				Items = new T[Capacity];
				Count = 0;
			}
			else
				Console.WriteLine("Capacity must be greater than 0");
		}

		public void Add(T item)
		{
			if(Count<Capacity)
			{
				Items[Count] = item;
				Count++;
			}
			else
				Console.WriteLine("Cannot add element; the list has reached its maximum capacity");
		}

		public T GetValue(int index)
		{
			if(index<0 || index>=Count)
			{
				Console.WriteLine($"Invalid index: {index}. Valid indices are from 0 to {Count - 1}.");
				return default(T);
			}
			return Items[index];
		}

	}
}
