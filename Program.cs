using abecedarian;
using System;
using System.ComponentModel.Design;
using System.ComponentModel;

namespace abecedarian
{
    public class Abecedarian
    {
        public static bool IsAbecedarian(string word)
        {
            // Iterate through the string
            for (int i = 0; i < word.Length - 1; i++)
            {
                // Compare current character with the next one
                if (word[i] > word[i + 1])
                {
                    // If current character is greater than the next, the word is not abecedarian
                    return false;
                }
            }
            // If we reach here, all characters are in order
            return true;
        }

        public static void Main()
        {
            // Test cases
            string[] testWords = { "abdest", "agnosy", "biopsy", "deux", "dimpsy", "hello", "world" };

            foreach (string word in testWords)
            {
                Console.WriteLine($"Is the word '{word}' abecedarian? {IsAbecedarian(word)}");
            }
        }
    }
}
/* 1) The strategy used by this code to determine if a word is "abecedarian" involves an iterative comparison of each character with the next character in the word. Here's a step-by-step breakdown of the strategy:

Initialization: The method IsAbecedarian is designed to take a string as input and check if the characters are in alphabetical order.

Iteration: It uses a for loop to iterate through the string from the first character to the second-to-last character. This is because each character needs to be compared with the next character in the string.

Comparison: Inside the loop, it compares the current character (word[i]) with the next character (word[i + 1]).

Order Check: If at any point the current character is greater than the next character, it means the characters are not in alphabetical order. The method then immediately returns false, indicating that the word is not abecedarian.

Completion: If the loop completes without finding any characters out of order, the method returns true, indicating that all characters are in alphabetical order and the word is abecedarian.

This strategy ensures that the method efficiently checks the order of characters in a single pass through the string, making it both straightforward and performant.*/
