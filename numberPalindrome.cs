
using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, result = 0, q, rem;
            // Prompt the user for input
            Console.Write("Enter a number and I will tell you whether it is a palindrome or not:  ");
            n = int.Parse(Console.ReadLine());

            // Temporarily store the value of the inputed number as q
            q = n;

            // While loop iterates as long as the value of q is not equal to 0
            while (q != 0)
            {
                // Store as the value of rem the remainder of q divided by 10
                rem = q % 10;
                // Reverse the number by multiplying result by 10 and adding rem
                result = result*10 + rem;
                // Divide q by 10
                q = q/10;
            }

            // If the reversed number is equal to the original number, then it is a palindrome
            if (result == n)
            {
                Console.WriteLine("The number entered is a palindrome");
            }
            else{
                Console.WriteLine("No it is not a palindrome");
            }

        }
           
    }
}
