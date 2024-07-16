using System;
using System.IO;

namespace FileInterpreter
{
  class Program
  {
    static void Main(string[] args)
    {
      //wrtiting to a text file
      string[] linesToWrite = { "First Line", "Second Line", "Third Line" };
      File.WriteAllLines(@"E:\Fundamentals\C#-Fundamentals\FileTest\testWrite.txt", linesToWrite);
      Console.WriteLine("Lines added to new file.");
      Console.ReadLine();

      //method 
      using (StreamWriter file = new StreamWriter(@"E:\Fundamentals\C#-Fundamentals\FileTest\myText.txt"))
      {
        foreach (string line in linesToWrite)
        {
          if (line.Contains("Third"))
          {
            file.WriteLine(line);
          }
        }
      }

      //appending new lines to an existing doc
      using (StreamWriter file = new StreamWriter(@"E:\Fundamentals\C#-Fundamentals\FileTest\myText.txt", true))
      {
        file.WriteLine("Appending new line");
      }

      //reading the whole text
      string text = System.IO.File.ReadAllText(@"E:\Fundamentals\C#-Fundamentals\FileTest\test.txt");
      Console.WriteLine($"TextFile contains following text: {text}");
      Console.ReadKey();

      //reading each line
      string[] lines = System.IO.File.ReadAllLines(@"E:\Fundamentals\C#-Fundamentals\FileTest\test.txt");

      Console.WriteLine($"Printing each line of the file: ");
      foreach (string line in lines)
      {
        Console.WriteLine(line);
      }
    }
  }
}
