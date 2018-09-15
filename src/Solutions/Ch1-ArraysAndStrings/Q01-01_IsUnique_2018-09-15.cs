using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Ch1_ArraysAndStrings
{
	public class Q01_01_IsUnique_2018_09_15
	{
		public static bool IsUniqueChars(string str)
		{
			if (str.Length > 128)
				return false;

			bool[] char_set = new bool[128];
			for (int i = 0; i < str.Length; i++)
			{
				int val = str[i];
				if (char_set[val])
				{
					return false;
				}
				char_set[val] = true;
			}
			return true;
		}
	}
}
