using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            char[] arr = new char[9] { 'a', 'b', 'c', '1', '2', '3', '4', '5', '6' };
            List<int> numbers = new List<int>();
            string str = "";


            //TODO START HERE:
            
            // Make a foreach loop to iterate through your character array
            
                // Now create a try catch
                
                
                    // Inside your try block
                        // set your string variable to each array element in your char[] to .ToString()
                        // Now, using int.Parse, parse your string variable and store in an int variable
                        // Then add each int to your list
                
                // catch your Exception:
                // in the scope of your catch you can use the following, 
                
                    //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
                foreach(char item in arr)
            {
                try
                {
                    str = item.ToString();
                    int parsedChar = int.Parse(str);
                    numbers.Add(parsedChar);
                }
                catch(FormatException f)
                {
                    Console.WriteLine(f.Message);
                    Console.WriteLine($"Unable to parse {item}");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine($"Unable to parse {item}");
                }
                finally
                {
                    Console.WriteLine(item);
                }
            }     
                
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
