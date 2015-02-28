/* Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
   Find in Google how to download files in C#.
   Be sure to catch all exceptions and to free any used resources in the finally block.
 */

namespace P04.DownloadFile
{
    using System;
    using System.Net;
    using System.IO;

    class DownloadFile
    {
        static void Main()
        {
            try
            {
                WebClient webClient = new WebClient();
                string url = "http://telerikacademy.com/Content/Images/news-img01.png";
                string file = "news-img01.png";
                webClient.DownloadFile(url, @file);
                Console.WriteLine("Download finished\nFile saved at:\n {0}", Directory.GetCurrentDirectory());
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (WebException we)
            {
                Console.WriteLine(we.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("***");
            }
        }
    }
}
