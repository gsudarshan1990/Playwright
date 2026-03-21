namespace ConsoleApplications
{
	public class StringTrimming
	{
		private static string greeting = "           Hello World!          ";
		private static string sayHello = "Hello World!";
		private static string songLyrics = "You say goodbye, and I say hello";
		private static bool result = false;

		private static void Main()
		{
			Console.WriteLine("***Triming at Begining********");
			Console.WriteLine($"[{greeting}]");
			string trimBeginningGreetings = greeting.TrimStart();
			Console.WriteLine($"[{trimBeginningGreetings}]");
			Console.WriteLine();
			Console.WriteLine("***Triming at Ending********");
			Console.WriteLine($"[{greeting}]");
			string trimEndingGreetings = greeting.TrimEnd();
			Console.WriteLine($"[{trimEndingGreetings}]");
			Console.WriteLine();
			Console.WriteLine("******Triming********");
			string trimGreetings = greeting.Trim();
			Console.WriteLine($"[{trimGreetings}]");
			Console.WriteLine();
			Console.WriteLine("String Replacement");
			Console.WriteLine(sayHello);
			string replacementString = sayHello.Replace("Hello", "Greetings");
			Console.WriteLine(replacementString);
			Console.WriteLine();
			Console.WriteLine("Convert to Lower");
			Console.WriteLine(sayHello.ToLower());
			Console.WriteLine("Convert to Upper");
			Console.WriteLine(sayHello.ToUpper());
			Console.WriteLine();
			Console.WriteLine("Checking the word present in the string");
			result = songLyrics.Contains("goodbye");
			Console.WriteLine();
			Console.WriteLine($"check the string 'goodbye' is present: {result}");
			result = songLyrics.Contains("greetings!");
			Console.WriteLine();
			Console.WriteLine($"check the string 'greetings' is present: {result}");
			Console.WriteLine();
			result = songLyrics.StartsWith("you");
			Console.WriteLine($"check the string starts with 'you' : {result}");
			Console.WriteLine();
			result = songLyrics.StartsWith("goodbye");
			Console.WriteLine($"check the string starts with 'goodbye':{result}");
			Console.WriteLine();
			result = songLyrics.EndsWith("hello");
			Console.WriteLine($"check the string ends with 'hello' : {result}");
			Console.WriteLine();
			result = songLyrics.EndsWith("goodbye");
			Console.WriteLine($"check with string ends with 'goodbye': {result}");



		}
	}
}
