using System;
using System.IO;
using System.Reflection;
namespace ConsoleFileGeneral {
    internal abstract class Program {
        private static void Main() {
            const string sourcePath = @"C:\temp\file.txt";
            const string targetPath = @"C:\temp\file1.txt";
            try {
                 var fileInfo = new FileInfo(sourcePath);
                 if (!File.Exists(targetPath))   {
                     fileInfo.CopyTo(targetPath);
                 }
                 else   {
                     Console.WriteLine("File exists");
                     return;
                 }
                 var lines = File.ReadAllLines(sourcePath);
                 foreach (var line in lines)
                 {
                     Console.WriteLine(line);
                 }
            }
            catch (IOException ex){
                 Console.WriteLine("Error was found, Message: \n" + ex);
            }
            finally {
                 Console.WriteLine();
                 Console.WriteLine("Process done with success!");
            }
        }    
   }
}