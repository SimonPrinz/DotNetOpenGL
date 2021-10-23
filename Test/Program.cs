using System;

namespace Test
{
	internal class Program
	{
		private static void Main(string[] pArgs)
		{
			Game? lGame = null;
			try
			{
				lGame = new Game();
				lGame.Run();
			}
			catch (Exception lException)
			{
				Console.WriteLine(lException);
				lGame?.Dispose();
			}
		}
	}
}