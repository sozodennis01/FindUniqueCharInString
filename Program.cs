//DSARSOZO - Post-Interview attempt 08/19/2022
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static string FindFirstUniqueChar(string test)
    {
        //Store unique chars + their counts
        Dictionary<char, int> uniqueChar = new Dictionary<char, int>();
        string result = "String: ";
        //Show the current string for Console.WriteLine();
        result += test;
        //go through each character in the string
        for (int index = 0; index < test.Count(); index++)
        {
            //grab the letter
            char letter = test[index];
            //check if its unique
            if (!uniqueChar.ContainsKey(letter))
            {
                uniqueChar.Add(letter, 1);
            }
            else
            {
                //not unique, update count
                uniqueChar[letter] += 1;
            }
        }

        //now go through EACH uniqueChar, the dictionary is already ORDERED by the string index so the first UNIQUE char will be found first!
        foreach (var entry in uniqueChar)
        {
            if (entry.Value == 1)
            {
                result += " | unique char and index: " + entry.Key + " - " + test.IndexOf(entry.Key);
                break;
            }
        }

        return result;
    }

    public static void Main()
    {
        string test1 = "abc"; //a 
        string test2 = "aab"; //b 
        string test3 = "aaaacaaaaab"; //c 
        string test4 = "aaaaaaaaadb"; //d
        string test5 = "aeaaaaaaadddddddbb"; //e
        string test6 = "banana"; //b 
        string test7 = "hawaii airlines"; //h
        string test8 = "i am using a dictionay iiiiiiiiiiiii"; //should return m
        string test9 = "Hhawaii Airlines";

        //note that lowercase and uppercase characters are distinct, I'll ignore that for now.
        //EX) Hhawaii Airlines would still return H becaues different unicode values.
        var tester = new List<string> { test1, test2, test3, test4, test5, test6, test7, test8, test9 };

        foreach (string test in tester)
        {
            Console.WriteLine(FindFirstUniqueChar(test));
        }
    }
}