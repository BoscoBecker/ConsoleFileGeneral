using System;
using System.IO;
using System.Reflection;
namespace ConsoleFileGeneral {
   class Program {
      static void Main() {
         string sourcePath = @"C:\temp\file.txt";
         string targetPath = @"C:\temp\file1.txt";
         try
         {
             FileInfo fileInfo = new FileInfo(sourcePath);
             if (!File.Exists(targetPath))   {
                 fileInfo.CopyTo(targetPath);
             }
             else   {
                 Console.WriteLine("Arquivo já existe");
                 return;
             }
             string[] lines = File.ReadAllLines(sourcePath);
             foreach (string line in lines)
             {
                 Console.WriteLine(line);
             }
         }
         catch (IOException Ex)
         {
             Console.WriteLine("Ocorreu um erro: " + Ex);
         }
         finally {
             Console.WriteLine();
             Console.WriteLine("Processo realizado com sucesso!");
         }
       }    
   }
}