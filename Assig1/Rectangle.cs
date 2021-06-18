using System;
using System.Collections.Generic;
using System.Text;

namespace Assig1
{
	public class Rectangle
	{
		private int length;
		private int width;
	
		

		public Rectangle()
		{
			length = 1;
			width = 1;
		}

		public Rectangle(int length, int width)
		{
			this.length = length;
			this.width = width;
		}


		public int GetLength()
		{
			return length;
		}

		public int SetLength(int length)
		{
			this.length = length;
			return this.length;
		}

		public int GetWidth()
		{
			return width;
		}

		public int SetWidth(int width)
		{
			this.width = width;
			return this.width;
		}

		public int GetPerimeter()
		{
			return 2 * length + 2 * width;
		}

		public int GetArea()
		{
			return length * width;
		}

		//public static int Result(int length, int width, int perimeter, int area)
		//{
		//	Console.WriteLine("Conclusion of measurement");
		//	Console.WriteLine("length:", length);
		//	Console.WriteLine("width:", width);
		//	Console.WriteLine("perimeter:", perimeter);
		//	Console.WriteLine("area:", area);
		//	Console.Write("value is {}");
		//}
	}
}