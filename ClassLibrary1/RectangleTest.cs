using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp7;


namespace RectangleTest
{
	public class RectangleTest
	{



		[Test]
		public void GetLength_Input10_Returns10()
		{

			//Arrange
			int length = 10;
			int width = 50;

			int expectedResult = length;

			Rectangle testRectangle = new Rectangle(length, width);

			//Act 
			double actualResult = testRectangle.GetLength();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}


		[Test]
		public void GetWidth_Input70_Returns70()
		{

			//Arrange
			int length = 30;
			int width = 70;

			int expectedResult = width;

			Rectangle testRectangle = new Rectangle(length, width);

			//Act 
			double actualResult = testRectangle.GetWidth();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void SetLength_Input123_Returns123()
		{

			//Arrange
			int length = 123;
			int width = 12;

			int expectedResult = length;

			Rectangle testRectangle = new Rectangle(length, width);

			//Act 
			double actualResult = testRectangle.SetLength(length);

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void Setwidth_Input200_Returns200()
		{

			//Arrange
			int length = 15;
			int width = 200;

			int expectedResult = width;

			Rectangle testRectangle = new Rectangle(length, width);

			//Act 
			double actualResult = testRectangle.SetWidth(width);

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetPerimeter_Input_Length30And_Width30_Returns120()
		{

			//Arrange
			int length = 30;
			int width = 30;

			int expectedResult = 2 * (length + width);

			Rectangle testRectangle = new Rectangle(length, width);

			//Act 
			double actualResult = testRectangle.GetPerimeter();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void GetArea_Input_Length8And_Width8_Returns64()
		{

			//Arrange
			int length = 8;
			int width = 8;

			int expectedResult = (length * width);

			Rectangle testRectangle = new Rectangle(length, width);

			//Act 
			double actualResult = testRectangle.GetArea();

			//Assert 
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}