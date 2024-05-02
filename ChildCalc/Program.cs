//Калькулятор
static void Main(string[] args)
{
	try
	{
		int arg1 = Convert.ToInt32(args[0]);
		int arg2 = Convert.ToInt32(args[1]);
		char symbol = Convert.ToChar(args[2]);
		int result = 0;

		if (symbol == '+')
		{
			result = arg1 + arg2;
		}
		else if (symbol == '-')
		{
			result = arg1 - arg2;
		}
		else if (symbol == '*')
		{
			result = arg1 * arg2;
		}
		else if (symbol == '/')
		{
			result = arg1 / arg2;
		}
		else
		{
			Console.WriteLine($"Ошибка ввода символа: {symbol}");
			return;
		}
		Console.WriteLine($"Результат вычисления: {arg1} {symbol} {arg2} = {result}");
		Console.Read();
	}
	catch (Exception)
	{
		Console.WriteLine($"Ошибка вычисления");
		Console.Read();
	}
}
Main(args);
