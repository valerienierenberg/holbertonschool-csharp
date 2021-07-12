using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
        Console.WriteLine(String.Format("Percent: {0:P2}", percent));
        Console.WriteLine(String.Format("Currency: {0:C}", currency));
	}
}