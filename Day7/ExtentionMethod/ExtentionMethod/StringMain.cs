
using NewFunctionalities;
using System;
class Program
{
    public static void Main2(string[] args)
    {

        string word = "C# is a powerful language";

        int wordcount = word.GetWordCounted();
        Console.WriteLine("Total words in a given string :" + wordcount);
        Console.ReadKey();

    }
}
