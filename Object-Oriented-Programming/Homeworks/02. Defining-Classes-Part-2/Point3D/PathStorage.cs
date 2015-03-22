namespace Point3D
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage                                     // Problem 4
    {
        public static void SavePath(Path path, string filePathName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePathName, false))
                {
                    writer.WriteLine(path);
                }
            }
            catch (DirectoryNotFoundException dnf)
            {
                Console.WriteLine(dnf.Message);
            }
            catch (PathTooLongException ptl)
            {
                Console.WriteLine(ptl.Message);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        }

        public static Path LoadPath(string filePathName)
        {
            Path loadedPaths = new Path();

            try
            {
                using (StreamReader reader = new StreamReader(filePathName))
                {
                    string line = reader.ReadLine();

                    while (reader.EndOfStream != true)
                    {
                        line = line.Substring(15);
                        double[] points = line.Split(new char[] { ' ', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(double.Parse)
                            .ToArray();
                        loadedPaths.AddPath(new Point3D(points[0], points[1], points[2]));
                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (DirectoryNotFoundException dnf)
            {
                Console.WriteLine(dnf.Message);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }

            return loadedPaths;
        }
    }
}
