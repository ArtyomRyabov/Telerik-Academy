/* Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
   reads its contents and prints it on the console.
   Find in MSDN how to use System.IO.File.ReadAllText(…).
   Be sure to catch all possible exceptions and print user-friendly error messages.
 */

namespace P03.ReadFileContents
{
    using System;
    using System.IO;
    using System.Text;
    using System.Security;

    class ReadFileContents
    {
        static void Main()
        {
            Console.WriteLine("Enter file name along with its full file path:");
            string filePath = Console.ReadLine();

            try
            {
                Console.WriteLine(File.ReadAllText(filePath, Encoding.UTF8));
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (PathTooLongException ptle)
            {
                Console.WriteLine(ptle.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine(dnfe.Message);
            }
            catch (FileNotFoundException fnf)
            {
                Console.WriteLine(fnf.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }
            catch (SecurityException se)
            {
                Console.WriteLine(se.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
