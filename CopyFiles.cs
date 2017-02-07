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
				if (sourceFileName == "END")
				{
					break;
				}
				int extensionIndex = sourceFileName.IndexOf('.');
				string extension = sourceFileName.Substring(extensionIndex - 1);
				string sourcePath = @"/Users/kix/Desktop";
				string destinationPath = @"/Users/kix/Desktop/" + destinationFolder;
				string destinationFileName = DateTime.Now.ToString("yyyyMMddhhmmss") + extension; // Don't mind this. I did this because I needed to name the copied files with respect to time.
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
