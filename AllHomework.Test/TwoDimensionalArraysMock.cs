using System;
namespace AllHomework.Test
{
	public static class TwoDimensionalArraysMock
	{
		public static int[,] GetMock(Enums.TDAMockType type)
		{
			switch (type)
			{
				case Enums.TDAMockType.empty:
					return new int[,] { };

				case Enums.TDAMockType.oneElement:
					return new int[1, 1] {
						{ 5 }
					    };
				case Enums.TDAMockType.oneElementReverse:
					return new int[1, 1] {
						{ 5 }
						};
				case Enums.TDAMockType.twoByTwo:
					return new int[2, 2] {
						{4, 5},
						{1, 21},
						};
				case Enums.TDAMockType.twoByTwoReverse:
					return new int[2, 2] {
						{4, 1},
						{5, 21},
						};
				case Enums.TDAMockType.threeByThree:
					return new int[3, 3] {
						{5, 12, 3 },
						{8, 4, -11},
						{7, -5, 20},
						};
				case Enums.TDAMockType.threeByThreeReverse:
					return new int[3, 3] {
						{5, 8, 7 },
						{12, 4, -5},
						{3, -11, 20},
						};
				case Enums.TDAMockType.fourByFour:
					return new int[4, 4] {
						{5, 13, 7, 8},
						{-5, 7, 15, 0},
						{2, 0, -3, 7},
						{9, -55, 2, -4}
						};
				case Enums.TDAMockType.fourByFourReverse:
					return new int[4, 4] {
						{5, -5, 2, 9},
						{13, 7, 0, -55},
						{7, 15, -3, 2},
						{8, 0, 7, -4}
						};
				default:
					throw new Exception();
			}
		}
	}
}
