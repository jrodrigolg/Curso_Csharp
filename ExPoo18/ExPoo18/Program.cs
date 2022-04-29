using System;
using System.IO;
using System.Globalization;
class Test
{
    public static void Main()
    {
        // Specify the directories you want to manipulate.
        DirectoryInfo di = new(@"c:\Myfolder");
        try
        {
            // Determine whether the directory exists.
            if (di.Exists)
            {
                // Indicate that the directory already exists.
                Console.WriteLine(di.CreationTimeUtc);
                return;
            }

            // Try to create the directory.
            di.Create();
            Console.WriteLine("The directory was created successfully.");

            // Delete the directory.
            di.Delete();
            Console.WriteLine("The directory was deleted successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
        finally { }
    }
}