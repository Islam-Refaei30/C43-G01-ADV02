using System.Collections;
using System.Net.NetworkInformation;

namespace Demo
{
    internal class Program
    {

        public static int SumOfArrayList (ArrayList array)
        {
                int Sum = 0;
            if (array is not null)
            {
                for(int i = 0; i < array.Count; i++)
                {
                    Sum += (int?)array[i] ?? 0;
                    //Casting from object [ref type] to int [Value type]
                    //UnBoxing => UnSafe Casting [May throw Exception]
                }
            }
                return Sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Demo");
            Console.WriteLine("Test push\n");

			#region Part 01 Non Generic Collection [Array List]
			#region EX 1
			//ArrayList A1 = new ArrayList();
			//Console.WriteLine($"Count = {A1.Count} ,Capacity = {A1.Capacity} ");

			//A1.Add(1);
			//A1.Add(2);
			//A1.AddRange(new int[] { 3, 5 });
			//Console.WriteLine("After adding element to ArrayList");
			//Console.WriteLine($"Count = {A1.Count} ,Capacity = {A1.Capacity} ");

			//Console.WriteLine("After adding 7 element to ArrayList");
			//A1.AddRange(new int[] { 3 });
			//Console.WriteLine($"Count = {A1.Count} ,Capacity = {A1.Capacity} ");

			//Console.WriteLine("After Trimming");
			//A1.TrimToSize();
			//Console.WriteLine($"Count = {A1.Count} ,Capacity = {A1.Capacity} ");
			#endregion
			#region EX 2
			//ArrayList A2 = new ArrayList(5) { 1, 2, 36, 5, 6 };
			//Console.WriteLine($"Count = {A2.Count} ,Capacity = {A2.Capacity} ");

			//A2.Add(3);
			//Console.WriteLine($"Count = {A2.Count} ,Capacity = {A2.Capacity} ");
			#endregion
			#region EX3
			//         ArrayList A3 = new ArrayList();
			//         A3.Add(1); // Casting from value type to ref   int=>obj   [Boxing]
			//A3.Add(10);
			//A3.Add(12);
			//A3.Add(16);
			//A3.Add("Islam");
			//compiler can not Enforce type safty
			//HetroGenous

			//         int Result = SumOfArrayList(A3);
			//Console.WriteLine($"The Result = {Result}");




			#endregion

			#endregion

			#region Part 02 Generic Collections [List]
			#region EX 1
			//List<int> list = new List<int>();
			//Console.WriteLine($"Count = {list.Count} ,Capacity = {list.Capacity} ");

			//list.Add(1);
			//Console.WriteLine($"Count = {list.Count} ,Capacity = {list.Capacity} ");


			//list.AddRange(new int[] { 50, 55, 0 });
			//Console.WriteLine($"Count = {list.Count} ,Capacity = {list.Capacity} ");

			//list.Add(22);
			//Console.WriteLine($"Count = {list.Count} ,Capacity = {list.Capacity} ");

			//list.TrimExcess();
			//Console.WriteLine($"Count = {list.Count} ,Capacity = {list.Capacity} ");
			#endregion
			#region EX 2
			//List<int> list = new List<int> { 50, 20, 30, 24, 5, 5 };
			//List<int> list = new List<int>(5) { 50, 20, 30, 24, 5, 5 };
			//Console.WriteLine($"Count = {list.Count} ,Capacity = {list.Capacity} ");
			//list.Sort();
			//list[0] = 5099;// Using Indexer As Setter
			//foreach(int i in list)
			//{
			//    Console.WriteLine(i);
			//}
			//         for(int i = 0;i < list.Count;i++)
			//{
			//             Console.WriteLine(list[i]); // Using Indexer As Getter
			//}
			//list.Add("islam");

			//Console.WriteLine(Helper.SumList(list));

			#endregion
			#endregion

			#region Part 03  Generic Collections (List Methods)
			//List<int> list = new List<int>([5, 2, 6, 8, 6, 4, 0, 5]);
			//List<int> list = new List<int>(){5, 2, 6, 8, 6, 4, 0, 5 };
			//list.Add(1); // Add one element
			//list.AddRange(new int[] {2,3}); // Add Range of elelment
			////Console.WriteLine(list[2]);
			//list.Insert(3, 4);
			//list.InsertRange(4, new int[] { 5, 6 });
			//list.InsertRange(6, [7, 8]);
			//list.Clear(); // Remove All Element In List
			//Console.WriteLine(list.BinarySearch(8)); // Search and return the index
			//Console.WriteLine(list.Contains(22)); // Search and return the bool [True/False]

			//Console.WriteLine(list.Capacity);
			//Console.WriteLine(list.EnsureCapacity(3)); // Increase Capacity but Check Old Capacity First

			//Console.WriteLine(list.IndexOf(5)); // اول ظهور للعنصر
			//Console.WriteLine(list.LastIndexOf(5)); // اخر ظهور للعنصر
			//foreach (int i in list)
			//{
			//	Console.WriteLine(i);
			//}
			#endregion

			#region Part 04 Linked List
			//LinkedList<int> Numbers = new LinkedList<int>();
			//Numbers.AddFirst(10);
			//Numbers.AddAfter(Numbers.First, 20);
			//Numbers.AddLast(60);
			//foreach(int i in Numbers)
			//{
			//	Console.WriteLine(i);
			//}
			#endregion

		}
	}
}
