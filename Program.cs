// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string path = "./README.md"; //"./pages/agil_systemutveckling.md";
        string fileContent = File.ReadAllText(path);

        Convert(fileContent);
    }

    static private void Convert(string fileContent)
    {
        int fileLength = fileContent.Length;
        for (int i = 0; i < fileLength; i++)
        {
            Console.Write(fileContent[i]);
            if (fileContent[i] == '#')
            {
                if (i + 6 < fileLength && fileContent.Substring(i, 7) == "###### ")
                {
                    Console.WriteLine("Hittade en: H6");
                    i += 6;
                }
                else if (i + 5 < fileLength && fileContent.Substring(i, 6) == "##### ")
                {
                    Console.WriteLine("Hittade en: h5");
                    i += 5;
                }
                else if (i + 4 < fileLength && fileContent.Substring(i, 5) == "#### ")
                {
                    Console.WriteLine("Hittade en: h4");
                    i += 4;
                }
                else if (i + 3 < fileLength && fileContent.Substring(i, 4) == "### ")
                {
                    Console.WriteLine("Hittade en: h3");
                    i += 3;
                }
                else if (i + 2 < fileLength && fileContent.Substring(i, 3) == "## ")
                {
                    Console.WriteLine("Hittade en: h2");
                    i += 2;
                }
                else if (i + 1 < fileLength && fileContent.Substring(i, 2) == "# ")
                {
                    Console.WriteLine("Hittade en: h1");
                    i += 1;
                }
                else {
                    
                }
           
            }
        }
        // foreach (string line in FileLines)
        // {
        //     if (Regex.IsMatch(line, @"^##(?!#)"))
        //     {
        //         Console.WriteLine(line);
        //         Console.WriteLine("Detta är en h2");
        //         Console.WriteLine("---------------------------------------\n");
        //     }
        //     if (Regex.IsMatch(line, @"^###(?!#)"))
        //     {
        //         Console.WriteLine(line);
        //         Console.WriteLine("Detta är en h3");
        //         Console.WriteLine("---------------------------------------\n");
        //     }
        //     else if (Regex.IsMatch(line, @"^\*"))
        //     {
        //         Console.WriteLine(line);
        //         Console.WriteLine("detta är en punkt");
        //         Console.WriteLine("---------------------------------------\n");
        //     }
        //     else
        //     {
        //         Console.WriteLine(line);
        //         Console.WriteLine("Detta är en paragraph");
        //         Console.WriteLine("---------------------------------------\n");
        //     }
        // }
    }
}
