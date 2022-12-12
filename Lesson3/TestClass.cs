namespace Lesson3
{
	public class SystemCoordinate
	{
		public static int GetQuarter(int x, int y)
		{
			if (x > 0 && y > 0)
			{
				return 1;
			}
			if (x < 0 && y > 0)
			{
				return 2;
			}
			if (x < 0 && y < 0)
			{
				return 3;
			}
			if (x > 0 && y < 0)
			{
				return 4;
			}
			return -1;
		}
	}
}