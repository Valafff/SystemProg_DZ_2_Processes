//Поиск
static void Main(string[] args)
{
	try
	{
		string Path = args[0];
		string TargetText = args[1];
		string FileText;
		//List<string> FileText = new List<string>();
		int count = 0;

		using (StreamReader reader = new StreamReader(Path))
		{
			FileText = reader.ReadToEnd();
			string[] words = FileText.Split(' ', '\n');
			foreach (string line in words)
			{
				if (line == TargetText)
				{
					count++;
				}
			}
            Console.WriteLine($"Количество найденных совпадений \"{TargetText}\" равно: {count}");
        }
		Console.Read();
	}
	catch (Exception)
	{
		Console.WriteLine($"Ошибка поиска");
		Console.Read();
	}
}
Main(args);
