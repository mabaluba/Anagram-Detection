using System;

namespace Anagram_Detection
{
    class Program
    {

        

        static void Main(string[] args)
        {
            var a = "ab";
            var b = "ba";
            var c = a.ToCharArray();
            if(String.Equals("ab", "ba"))
                Console.WriteLine("true");
            else Console.WriteLine("false");
            Console.WriteLine(String.GetHashCode("ab"));
            Console.WriteLine(String.GetHashCode("ba"));
        }
    }
}
