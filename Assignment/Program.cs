using System.Collections;

namespace Assignment
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Assignment");
			Console.WriteLine("Test push");

			#region Q1
			ArrayList R = new ArrayList() { 1, 2, 3, 4 };
			//ArrayList R = new ArrayList() { "d","c","s","w" };
			//Console.WriteLine(R.Count);
			foreach (int i in R)
			{
				Console.WriteLine(i);
			}
			Helper.Reversed(ref R);
			foreach (int i in R)
			{
				Console.WriteLine(i);
			}
			#endregion
		}
	}
}
