using System;
using NUnit.Framework;

namespace HelloCSharp
{
	[TestFixture()]
	public class HelloNUnit
	{
		[Test()]
		public void TestPass () // assertion holds
		{
			const int i = 1 + 1;
			Assert.AreEqual(2, i);
		}

		[Test()]
		public void TestFail () // assertion fails
		{
			const int i = 1 + 1;
			Assert.AreEqual(3, i);
		}
	
		[Test()]
		public void TestError () // error occurs before testing assertion
		{
			const int i = 1;
			int j = 1;
			if (true) j = 0;
			Assert.AreEqual(3, i / j);
		}
	}
}

