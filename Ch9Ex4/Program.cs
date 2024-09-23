using System;
using static System.Console;

/*
Create a program named PaintingDemo that instantiates an array of eight Room objects and demonstrates the Room methods.

The Room constructor requires parameters for length, width, and height fields;
	use a variety of values when constructing the objects.

The Room class also contains a field for wall area of the Room and number of gallons of paint needed to paint the room.

Both of these values are computed by calling private methods.

Include read-only properties to get a Room’s values.

A room is assumed to have four walls, and you do not need to allow for windows and doors, and you do not need to allow for painting the ceiling.

A room requires one gallon of paint for every 350 square feet (plus an extra gallon for any square feet greater than 350).

In other words, a 12 X 10 room with 9-foot ceilings has 396 square feet of wall space, and so requires two gallons of paint.
*/

namespace Ch9Ex4
{
	class Room
	{
		// Fields
		private int length;
		private int width;
		private int height;

		// Properties
		public int Length
		{
			get
			{
				return length;
			}
		}
		public int Width
		{
			get
			{
				return width;
			}
		}
		public int Height
		{
			get
			{
				return height;
			}
		}

		// Constructor
		public Room(int length, int width, int height)
		{
			this.length = length;
			this.width = width;
			this.height = height;
		}

		// Methods
		public int WallArea()
		{
			return 4 * (length * width);
		}
		public int GallonsOfPaint()
		{
			return WallArea() / 350 + (WallArea() % 350 > 0 ? 1 : 0);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Room[] rooms = new Room[8];
			rooms[0] = new Room(12, 10, 9);
			rooms[1] = new Room(15, 8, 7);
			rooms[2] = new Room(10, 12, 8);
			rooms[3] = new Room(8, 15, 9);
			rooms[4] = new Room(16, 12, 10);
			rooms[5] = new Room(12, 16, 11);
			rooms[6] = new Room(11, 12, 12);
			rooms[7] = new Room(10, 11, 15);

			foreach (Room room in rooms)
			{
				WriteLine($"Room with length {room.Length}, width {room.Width}, and height {room.Height} requires {room.GallonsOfPaint()} gallons of paint. (Total area: {room.WallArea()} square feet.)");
			}
		}
	}
}
