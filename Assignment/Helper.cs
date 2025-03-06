using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
	internal class Helper
	{
		public static void Reversed (ref ArrayList R)
		{
			object temp = 0;
			int C = R.Count - 1;
			if (R is not null)
			{
				for(int i = 0; i < C-i ; i++)
				{
					temp = R[i];
					R[i] = R[C - i];
					R[C - i] = temp;
				}
			}
		}

	}
}
