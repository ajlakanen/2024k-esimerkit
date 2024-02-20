// ReSharper disable all
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using NUnit.Framework;
using static Taulukot;

	[TestFixture]
	[DefaultFloatingPointTolerance(0.000001)]
	public  class TestTaulukot
	{
		[Test]
		public  void TestLoytyykoKirjainA112()
		{
			string[] jonot = { "Antti-Jussi", "Jonne", "Vesa", "Tuomo" };
			Assert.AreEqual( 2, LoytyykoKirjainA(jonot) , "in method LoytyykoKirjainA, line 114");
			string[] jonot2 = { "Jonne", "Tuomo" };
			Assert.AreEqual( 0, LoytyykoKirjainA(jonot2) , "in method LoytyykoKirjainA, line 116");
			string[] jonot3 = {  };
			Assert.AreEqual( 0, LoytyykoKirjainA(jonot3) , "in method LoytyykoKirjainA, line 118");
		}
	}

