using Solutions.Ch1_ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solutions.Test.Ch1_ArraysAndStrings
{
	public class Q01_01_IsUniqueTests_2018_09_16
	{
		[Fact]
		public void Test1()
		{
			Assert.True(Q01_01_IsUnique_2018_09_15.IsUniqueChars("abcde"));
		}

		[Fact]
		public void Test2()
		{
			Assert.False(Q01_01_IsUnique_2018_09_15.IsUniqueChars("hello"));
			Assert.False(Q01_01_IsUnique_2018_09_15.IsUniqueChars("apple"));
			Assert.True(Q01_01_IsUnique_2018_09_15.IsUniqueChars("kite"));
			Assert.True(Q01_01_IsUnique_2018_09_15.IsUniqueChars("padle"));
		}

	}
}
