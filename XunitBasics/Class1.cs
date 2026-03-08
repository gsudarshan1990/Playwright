namespace AIAssistedDevelopment
{
	public class Class1
	{
		private static void Main(string[] args)
		{

			// SentenceWords is a string array.
			string[] SentenceWords = {
									"the",
									"quick",
									"brown",
									"fox",
									"jumps"
								};

			//string[] moreWords = {
			//						"over",
			//						"the",
			//						"lazy",
			//						"dog"
			//					};

			// Alphabetically sort the words.
			IEnumerable<string> query = from word in SentenceWords
										orderby word
										select word;

		}

	}


}
