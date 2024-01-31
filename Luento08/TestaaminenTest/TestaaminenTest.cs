// ReSharper disable all
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Testaaminen;

	[TestFixture]
	[DefaultFloatingPointTolerance(0.000001)]
	public  class TestTestaaminen
	{
		[Test]
		public  void TestJaaKolmella32()
		{
			Assert.AreEqual( 1.0, JaaKolmella(3.0) , "in method JaaKolmella, line 33");
			Assert.AreEqual( 3.333333, JaaKolmella(10.0) , "in method JaaKolmella, line 34");
			Assert.AreEqual( 0.1, JaaKolmella(0.3) , "in method JaaKolmella, line 35");
			Assert.AreEqual( 0.3333333, JaaKolmella(1.0) , 0.000001, "in method JaaKolmella, line 36");
		}
		[Test]
		public  void TestMonista52()
		{
			Assert.AreEqual( "aaa", Monista('a') , "in method Monista, line 53");
			Assert.AreEqual( "bbb", Monista('b') , "in method Monista, line 54");
			Assert.AreEqual( "   ", Monista(' ') , "in method Monista, line 55");
			Assert.AreEqual( "AAA", Monista('A') , "in method Monista, line 56");
		}
	}

