// Describe the strings in C#.
// What is typical for the string data type?
// Describe the most important methods of the String class.

using System;

namespace P01.StringsInCsharp
{
    using System;

    class StringsInCsharp
    {
        static void Main()
        {
            Console.WriteLine(new string('-', 26));
            Console.WriteLine("Describe the strings in C#");
            Console.WriteLine(new string('-', 26));
            Console.WriteLine(
@"A string is an object of type String whose value is text. Internally, 
the text is stored as a sequential read-only collection of Char objects. " + "\n");

            Console.WriteLine(new string('-', 41));
            Console.WriteLine("What is typical for the string data type?");
            Console.WriteLine(new string('-', 41));
            Console.WriteLine(
@"# String is a reference type, the equality operators (== and !=) are 
defined to compare the values of string objects, not references." + "\n");
            Console.WriteLine(
@"# String objects are immutable: they cannot be changed after they have been 
created. All of the String methods and C# operators that appear to modify a 
string actually return the results in a new string object." + "\n");
            Console.WriteLine(
@"# It overloads the == operator. When the == operator is used to compare two 
strings, the Equals method is called, which checks for the equality of the 
contents of the strings rather than the references themselves." + "\n");
            Console.WriteLine(
@"# Strings are stored in the dynamic memory (managed heap)." + "\n");
            Console.WriteLine(
@"# Strings use Unicode to support multiple languages and alphabets." + "\n");

            Console.WriteLine(new string('-', 55));
            Console.WriteLine("Describe the most important methods of the String class");
            Console.WriteLine(new string('-', 55));
            Console.WriteLine(
@"# Compare(string strA, string strB) Compares two specified string objects and 
returns an integer that indicates their relative position in the sort order." + "\n");
            Console.WriteLine("# Concat(string str0, string str1) Concatenates two string objects." + "\n");
            Console.WriteLine(
@"# Contains(string value) Returns a value indicating whether the specified 
string object occurs within this string." + "\n");
            Console.WriteLine(
@"# Copy(string str) Creates a new String object with the same value as 
the specified string." + "\n");
            Console.WriteLine(
@"# Format(string format, Object arg0) Replaces one or more format items in a 
specified string with the string representation of a specified object." + "\n");
            Console.WriteLine(
@"# Remove(int startIndex, int count) Removes the specified number of characters 
in the current string beginning at a specified position and returns the string." + "\n");
            Console.WriteLine(
@"# Insert(int startIndex, string value) Returns a new string in which a 
specified string is inserted at a specified index position in the current 
string object." + "\n");
            Console.WriteLine(
@"# Replace(string oldValue, string newValue) Replaces all occurrences of a 
specified string in the current string object with the specified string and 
returns the new string." + "\n");
            Console.WriteLine("# ToLower() Returns a copy of this string converted to lowercase." + "\n");
            Console.WriteLine("# ToUpper() Returns a copy of this string converted to uppercase." + "\n");
            Console.WriteLine(
@"# IndexOf(string value, int startIndex) Returns the zero-based index of the 
first occurrence of the specified string in this instance, starting search 
at the specified character position." + "\n");
            Console.WriteLine(
@"# Split(params char[] separator) Returns a string array that contains the 
substrings in the current string object, delimited by elements of a specified 
Unicode character array." + "\n");
        }
    }
}
