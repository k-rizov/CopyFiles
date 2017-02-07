using System;

namespace copyingItems
{
	public class EmptyClass
	{
		public static void Main()
		{
			string destinationFolder = Console.ReadLine();
			while (true)
			{
				string sourceFileName = Console.ReadLine();
				if (sourceFileName == "end")
				{
					break;
				}
				string sourcePath = @"PATH NAME"; // Enter source path, for MACS /Users/yourUserName/Desktop/, for WINDOWS C:\Users\yourUserName\Desktop\
				string destinationPath = @"PATH NAME" + destinationFolder; // Enter destination path, for MACS /Users/yourUserName/Desktop/, for WINDOWS C:\Users\yourUserName\Desktop\
				string destinationFileName = sourceFileName; // Outputs file with its original name
				string sourceFile = System.IO.Path.Combine(sourcePath, sourceFileName);
				string destinationFile = System.IO.Path.Combine(destinationPath, destinationFileName);

				if (!System.IO.Directory.Exists(destinationPath))
				{
					System.IO.Directory.CreateDirectory(destinationPath);
				}
				System.IO.File.Copy(sourceFile, destinationFile, true);
			}
		}
	}
}
