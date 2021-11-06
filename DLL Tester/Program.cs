using StringCounter;
using System;

namespace DLL_Tester
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "String Counter Console";

			// user choices
			Console.WriteLine("\t\tWelcome to the STRING COUNTER CONSOLE!");
			Console.WriteLine("");
			Console.WriteLine("Please enter a choice:");
			Console.WriteLine("");
			Console.WriteLine("1) Word Counter");
			Console.WriteLine("");
			Console.WriteLine("2) Word Beginnings");
			Console.WriteLine("");
			Console.WriteLine("3) Exit Console");

			Console.WriteLine("\n----------------------------------------");

			// user input
			int userChoice = GetUserChoice();

			// do a method based on the user's input
			if (userChoice == 1)
			{
				Console.Write("\nPlease enter a sentence: ");
				string sentence = Console.ReadLine();

				int wordCount = sentence.CountWords();
				Console.WriteLine("\nThere are {0} words in this sentence.", wordCount);

				Console.ReadKey();
			}
			else if (userChoice == 2)
			{
				Console.Write("\nPlease enter a sentence: ");
				string sentence = Console.ReadLine();

				string wordBeginnings = sentence.GetWordBeginnings();
				Console.WriteLine("\nHere is the first letter of every word in the given sentence:");
				Console.WriteLine("\n{0}", wordBeginnings);

				Console.ReadKey();
			}
			else if (userChoice == 3)
			{
				return;
			}

			Console.Clear();
			Main(args);
		}

		/// <summary>
		/// Create a looped method that only returns valid input.
		/// </summary>
		/// <returns>&lt;&lt;&lt; - ONLY VALID INPUT - &gt;&gt;&gt;</returns>
		private static int GetUserChoice()
		{
			int userChoice = 0;

			try
			{
				Console.Write("\nYour Choice: ");
				int choice = int.Parse(Console.ReadLine());

				if (choice == 1 || choice == 2 || choice == 3)
				{
					userChoice = choice;
				}
				else
				{
					Console.WriteLine("\nInvalid response. Please enter '1', '2', or '3'.");
					userChoice = GetUserChoice();
				}
			}
			catch
			{
				Console.WriteLine("\nInvalid response. Please enter '1', '2', or '3'.");
				userChoice = GetUserChoice();
			}

			return userChoice;
		}
	}
}
