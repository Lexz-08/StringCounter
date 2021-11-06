namespace StringCounter
{
	/// <summary>
	/// A class that can be used to count the number of words in a string,<br/>
	/// or get the first letter of each word in a string.
	/// </summary>
	public static class StrCounter
	{
		/// <summary>
		/// Counts the number of words in the current string.
		/// </summary>
		/// <param name="String">The <see langword="string"/> to inspect.</param>
		/// <returns>The number of words in the current string.</returns>
		public static int CountWords(this string String)
		{
			if ((String.Contains("a") == true || String.Contains("A") == true) == true ||
				(String.Contains("b") == true || String.Contains("B") == true) == true ||
				(String.Contains("c") == true || String.Contains("C") == true) == true ||
				(String.Contains("d") == true || String.Contains("D") == true) == true ||
				(String.Contains("e") == true || String.Contains("E") == true) == true ||
				(String.Contains("f") == true || String.Contains("F") == true) == true ||
				(String.Contains("g") == true || String.Contains("G") == true) == true ||
				(String.Contains("h") == true || String.Contains("H") == true) == true ||
				(String.Contains("i") == true || String.Contains("I") == true) == true ||
				(String.Contains("j") == true || String.Contains("J") == true) == true ||
				(String.Contains("k") == true || String.Contains("K") == true) == true ||
				(String.Contains("l") == true || String.Contains("L") == true) == true ||
				(String.Contains("m") == true || String.Contains("M") == true) == true ||
				(String.Contains("n") == true || String.Contains("N") == true) == true ||
				(String.Contains("o") == true || String.Contains("O") == true) == true ||
				(String.Contains("p") == true || String.Contains("P") == true) == true ||
				(String.Contains("q") == true || String.Contains("Q") == true) == true ||
				(String.Contains("r") == true || String.Contains("R") == true) == true ||
				(String.Contains("s") == true || String.Contains("S") == true) == true ||
				(String.Contains("t") == true || String.Contains("T") == true) == true ||
				(String.Contains("u") == true || String.Contains("U") == true) == true ||
				(String.Contains("v") == true || String.Contains("V") == true) == true ||
				(String.Contains("w") == true || String.Contains("W") == true) == true ||
				(String.Contains("x") == true || String.Contains("X") == true) == true ||
				(String.Contains("y") == true || String.Contains("Y") == true) == true ||
				(String.Contains("z") == true || String.Contains("Z") == true) == true)
			{
				bool isWord = false,
				wordStarted = false;
				int wordCount = 0;

				for (int i = 0; i < String.Length; i++)
				{
					char char_ = String[i];
					char upperComma = '\'';
					bool isLetter = char.IsLetter(char_);
					bool isUpperComma = String[i] == upperComma;

					if (isLetter == true)
					{
						isWord = true;
						if (i > 0)
						{
							if (char.IsLetter(String[i - 1]) == false ||
								char.IsUpper(char_) == true && char.IsLetter(String[i - 1]) == false)
								wordStarted = true;
						}
						else if (i == 0)
						{
							if (char.IsLetter(String[i]) == true &&
								char.IsUpper(char_) == true || char.IsLower(char_))
								wordStarted = true;
						}
					}
					else if (isLetter == false)
					{
						isWord = false;
						wordStarted = false;
					}

					if (isWord == true)
					{
						if (wordStarted == true)
						{
							wordCount++;
							wordStarted = false;
						}
					}

					if (i > 0) if (isUpperComma == true && char.IsLetter(String[i - 1])) wordCount--;
				}

				return wordCount;
			}
			else return 0;
		}

		/// <summary>
		/// Gets the first letter of each word in the current string.
		/// </summary>
		/// <param name="String">The <see langword="string"/> to inspect.</param>
		/// <returns>An array of characters (a <see langword="string"/>) that contains the first letter of each word in the string.</returns>
		public static string GetWordBeginnings(this string String)
		{
			if ((String.Contains("a") == true || String.Contains("A") == true) == true ||
				(String.Contains("b") == true || String.Contains("B") == true) == true ||
				(String.Contains("c") == true || String.Contains("C") == true) == true ||
				(String.Contains("d") == true || String.Contains("D") == true) == true ||
				(String.Contains("e") == true || String.Contains("E") == true) == true ||
				(String.Contains("f") == true || String.Contains("F") == true) == true ||
				(String.Contains("g") == true || String.Contains("G") == true) == true ||
				(String.Contains("h") == true || String.Contains("H") == true) == true ||
				(String.Contains("i") == true || String.Contains("I") == true) == true ||
				(String.Contains("j") == true || String.Contains("J") == true) == true ||
				(String.Contains("k") == true || String.Contains("K") == true) == true ||
				(String.Contains("l") == true || String.Contains("L") == true) == true ||
				(String.Contains("m") == true || String.Contains("M") == true) == true ||
				(String.Contains("n") == true || String.Contains("N") == true) == true ||
				(String.Contains("o") == true || String.Contains("O") == true) == true ||
				(String.Contains("p") == true || String.Contains("P") == true) == true ||
				(String.Contains("q") == true || String.Contains("Q") == true) == true ||
				(String.Contains("r") == true || String.Contains("R") == true) == true ||
				(String.Contains("s") == true || String.Contains("S") == true) == true ||
				(String.Contains("t") == true || String.Contains("T") == true) == true ||
				(String.Contains("u") == true || String.Contains("U") == true) == true ||
				(String.Contains("v") == true || String.Contains("V") == true) == true ||
				(String.Contains("w") == true || String.Contains("W") == true) == true ||
				(String.Contains("x") == true || String.Contains("X") == true) == true ||
				(String.Contains("y") == true || String.Contains("Y") == true) == true ||
				(String.Contains("z") == true || String.Contains("Z") == true) == true)
			{
				bool isWord = false,
					wordStarted = false;
				int wordCount = 0;
				string wordBegins = string.Empty;

				for (int i = 0; i < String.Length; i++)
				{
					char char_ = String[i];
					char upperComma = '\'';
					bool isLetter = char.IsLetter(char_);
					bool isUpperComma = String[i] == upperComma;

					if (isLetter == true)
					{
						isWord = true;
						if (i > 0)
						{
							if (char.IsLetter(String[i - 1]) == false ||
								(char.IsUpper(char_) == true && char.IsLetter(String[i - 1]) == false))
								wordStarted = true;
						}
						else if (i == 0)
						{
							if (char.IsLetter(String[i]) == true &&
								(char.IsUpper(char_) == true || char.IsLower(char_)))
								wordStarted = true;
						}
					}
					else if (isLetter == false)
					{
						isWord = false;
						wordStarted = false;
					}

					if (isWord == true)
					{
						if (wordStarted == true)
						{
							wordCount++;

							if (i - 1 > -1)
							{
								if (String[i - 1] == '\'')
								{
									if (i + 1 != String.Length)
									{
										bool nextIsLetter = char.IsLetter(String[i + 1]);

										if (nextIsLetter == true)
										{
											wordBegins += ", " + String[i];
										}
										else if (nextIsLetter == false)
										{
											// do nothing
										}
									}
								}
								else wordBegins += ", " + char_;
							}
							else wordBegins += ", " + char_;

							wordStarted = false;
						}
					}

					if (i > 0) if (isUpperComma == true && char.IsLetter(String[i - 1])) wordCount--;
				}

				return wordBegins.Substring(2);
			}
			else return string.Empty;
		}
	}
}
