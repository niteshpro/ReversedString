using System;
namespace ReversedString
{
    class Reversed
    {
        public static void Main()
        {
            Console.WriteLine("Enter your name: ");
            var names = Console.ReadLine();

            //creating array
            char[]? array = new char[names.Length];
            for(var i= names.Length; i>0; i--)
            {
                array[names.Length - i] = names[i - 1];
            }

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);

        }
    }
}