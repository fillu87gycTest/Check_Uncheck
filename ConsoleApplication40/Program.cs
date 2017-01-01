/*
 * 
 * Over Flow
 * result ->44
 * -------------------------
 * System.OverflowException: 算術演算の結果オーバーフローが発生しました。
 *    場所 Program.Main() 場所 D:\Program\Cs\ConsoleApplication40\ConsoleApplication40\Program.cs:行 14
 * -------------------------
*/

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