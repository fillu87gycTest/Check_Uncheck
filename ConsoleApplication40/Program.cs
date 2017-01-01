using System;

class Program
{
	static void Main()
	{
		byte a = 100, b=200;
		byte result;

		try
		{
			result = unchecked((byte)( a + b));
			Console.WriteLine("Over Flow \nresult ->" + result);
			result = checked((byte)(a + b));
			Console.WriteLine("non check");
		}
		catch (OverflowException exp)
		{
			Console.WriteLine("-------------------------");
			Console.WriteLine(exp);
			Console.WriteLine("-------------------------");
		}
	}
}