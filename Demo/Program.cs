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


		}
	}
}
