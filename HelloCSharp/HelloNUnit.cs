using System;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace HelloCSharp
{
	[TestFixture]
	public class HelloNUnit
	{
		[Test]
		public void TestPass () // assertion holds
		{
			const int i = 1 + 1;
			Assert.That (i, Is.EqualTo(2));
		}

		[Test]
		public void TestFail () // assertion fails
		{
			const int i = 1 + 1;
			Assert.That (i, Is.EqualTo(3));
		}
	
		[Test]
		public void TestError () // error occurs before testing assertion
		{
			const int i = 1;
			int j = 1;
			if (true) j = 0;
			Assert.That (i / j, Is.EqualTo (2));
		}

		[Test, Ignore]
		public void TestIgnore () // test is not run
		{
			const int i = 1;
			int j = 1;
			if (true) j = 0;
			Assert.AreEqual (3, i / j);
		}

		[Test, ExpectedException("System.DivideByZeroException")]
		public void TestErrorExpected () // test fails if error does not occur
		{
			const int i = 1;
			int j = 1;
			if (true) j = 0;
			Assert.AreEqual (3, i / j);
		}
	}
}
