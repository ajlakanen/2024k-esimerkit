// ReSharper disable all
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;
using static MontakoLukua;

	[TestFixture]
	[DefaultFloatingPointTolerance(0.000001)]
	public  class TestMontakoLukua
	{
		[Test]
		public  void TestMontakoNegatiivista229()
		{
			Assert.AreEqual( 3, MontakoNegatiivista2(new int[] {-1, -2, 0, -2, -1, -5, 1, 2, -3 }) , "in method MontakoNegatiivista2, line 30");
			Assert.AreEqual( 4, MontakoNegatiivista2(new int[] {-1, -2, 0, -2, -1, -5, 1, 2, -3, -4, -5, -6 })  , "in method MontakoNegatiivista2, line 31");
			Assert.AreEqual( 5, MontakoNegatiivista2(new int[] {-1, -2, 0, -2, -1, -5, 1, 2, -3, -4, -5, -6, -6 })  , "in method MontakoNegatiivista2, line 32");
			Assert.AreEqual( 0, MontakoNegatiivista2(new int[] { 0, 1, 2 }) , "in method MontakoNegatiivista2, line 33");
			Assert.AreEqual( 1, MontakoNegatiivista2(new int[] { 0, -1, 2 }) , "in method MontakoNegatiivista2, line 34");
			Assert.AreEqual( 1, MontakoNegatiivista2(new int[] { -1, 1, -2 }) , "in method MontakoNegatiivista2, line 35");
			Assert.AreEqual( 5, MontakoNegatiivista2(new int[] { -1, -2, -1, -3, -2, 0, -1, 2}) , "in method MontakoNegatiivista2, line 36");
			Assert.AreEqual( 0, MontakoNegatiivista2(new int[] { }) , "in method MontakoNegatiivista2, line 37");
			Assert.AreEqual( 3, MontakoNegatiivista2(new int[] {-1, -1, -1 }) , "in method MontakoNegatiivista2, line 38");
		}
		[Test]
		public  void TestMontakoNegatiivista84()
		{
			Assert.AreEqual( 3, MontakoNegatiivista(new int[] {-1, -2, 0, -2, -1, -5, 1, 2, -3 }) , "in method MontakoNegatiivista, line 85");
			Assert.AreEqual( 4, MontakoNegatiivista(new int[] {-1, -2, 0, -2, -1, -5, 1, 2, -3, -4, -5, -6 })  , "in method MontakoNegatiivista, line 86");
			Assert.AreEqual( 5, MontakoNegatiivista(new int[] {-1, -2, 0, -2, -1, -5, 1, 2, -3, -4, -5, -6, -6 })  , "in method MontakoNegatiivista, line 87");
			Assert.AreEqual( 0, MontakoNegatiivista(new int[] { 0, 1, 2 }) , "in method MontakoNegatiivista, line 88");
			Assert.AreEqual( 1, MontakoNegatiivista(new int[] { 0, -1, 2 }) , "in method MontakoNegatiivista, line 89");
			Assert.AreEqual( 1, MontakoNegatiivista(new int[] { -1, 1, -2 }) , "in method MontakoNegatiivista, line 90");
			Assert.AreEqual( 5, MontakoNegatiivista(new int[] { -1, -2, -1, -3, -2, 0, -1, 2}) , "in method MontakoNegatiivista, line 91");
			Assert.AreEqual( 0, MontakoNegatiivista(new int[] { }) , "in method MontakoNegatiivista, line 92");
			Assert.AreEqual( 3, MontakoNegatiivista(new int[] {-1, -1, -1 }) , "in method MontakoNegatiivista, line 93");
		}
	}

