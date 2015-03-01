// Write a program that compares two text files line by line and prints the number of lines that are the same and 
// the number of lines that are different. Assume the files have equal number of lines.

namespace P04.CompareTextFiles
{
    using System;
    using System.IO;

    class CompareTextFiles
    {
        static void Main()
        {
            using (StreamReader firstReader = new StreamReader(@"..\..\first_file.txt"))
            {
                using (StreamReader secondReader = new StreamReader(@"..\..\second_file.txt"))
                {
                    string firstFileLine = firstReader.ReadLine();
                    string secondFileLine = secondReader.ReadLine();
                    int same = 0;
                    int different = 0;

                    while (firstFileLine != null)
                    {
                        if (firstFileLine.CompareTo(secondFileLine) == 0)
                        {
                            same++;
                        }
                        else
                        {
                            different++;
                        }

                        firstFileLine = firstReader.ReadLine();
                        secondFileLine = secondReader.ReadLine();
                    }

                    Console.WriteLine("The number of same lines is: {0}", same);
                    Console.WriteLine("The number of different lines is: {0}", different);
                }
            }
        }
    }
}
