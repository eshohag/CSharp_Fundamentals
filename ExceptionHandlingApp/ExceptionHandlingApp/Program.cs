using System;
using System.IO;

namespace ExceptionHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"G:\Intro CSharp\ExceptionHandlingApp\Example.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }
            //catch (NotSupportedException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Code to finalize
                //Setting object to null
                //CLosing database connection
                Console.WriteLine("\nAlways excute finally block\nClosing applications now...");
            }
            Console.ReadKey();
        }
    }
}
