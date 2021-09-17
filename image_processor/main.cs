using System;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    string[] filenames = new string[1];

    filenames[0] = "images/meor-mohamad.jpg";

    ImageProcessor.Inverse(filenames);

    string newFile = "meor-mohamad_inverse.jpg";
    DirectoryInfo dirInfo = new DirectoryInfo(".");
    FileInfo[] fInfoArray = dirInfo.GetFiles();

    FileInfo fInfo = Array.Find(fInfoArray, f => f.Name == newFile);

    if (fInfo != null && fInfo.Length > 100000)
    {
      Console.WriteLine("OK");
      File.Delete(Path.GetFullPath(newFile));
    }
    else
      Console.WriteLine("File created incorrectly");
  }
}
