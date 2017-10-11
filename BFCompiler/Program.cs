using System;
using System.IO;

namespace BFCompiler
{
	class Program
	{
		static void Main(string[] args)
		{
			string codeToCompile;

			if(args.Length > 0)
			{
				codeToCompile = OpenFile(args[0]);
			}
			else
			{
				Console.WriteLine("File name expected as first argument.");
				System.Environment.Exit(1);
			}

			//Continue with compilling string here


		}

		static string OpenFile(string filename)
		{
			try
			{   // Open the text file using a stream reader.
				using (StreamReader sr = new StreamReader(filename))
				{
					// Read the stream to a string, and write the string to the console.
					String line = sr.ReadToEnd();
					return line;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("The file could not be read:");
				Console.WriteLine(e.Message);
				System.Environment.Exit(1);
				return "";
			}
		}
	}

}
