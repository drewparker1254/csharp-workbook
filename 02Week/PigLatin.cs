using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What's the word?");
        string word = Console.ReadLine().ToLower();

        Console.WriteLine(TranslateWord(word));
        Console.ReadLine();
    }

    

    public static string TranslateWord(string word)
    {
        // Your code here
        //string firstPart = word.Substring(0,1);
        //string restWord = word.Substring(1);
        //return (restWord + firstPart + "ay");

        int vowelIndex = -1;

        if ((word.IndexOf('a') > -1 && word.IndexOf('a') < vowelIndex) || vowelIndex == -1)
        { vowelIndex = word.IndexOf('a'); }

        if ((word.IndexOf('e') > -1 && word.IndexOf('e') < vowelIndex) || vowelIndex == -1)
        { vowelIndex = word.IndexOf('e'); }

        if ((word.IndexOf('i') > -1 && word.IndexOf('i') < vowelIndex) || vowelIndex == -1)
        { vowelIndex = word.IndexOf('i'); }

        if ((word.IndexOf('o') > -1 && word.IndexOf('o') < vowelIndex) || vowelIndex == -1)
        { vowelIndex = word.IndexOf('o'); }

        if ((word.IndexOf('u') > -1 && word.IndexOf('u') < vowelIndex) || vowelIndex == -1)
        { vowelIndex = word.IndexOf('u'); }

        if ((word.IndexOf('y') > -1 && word.IndexOf('y') < vowelIndex) || vowelIndex == -1)
        { vowelIndex = word.IndexOf('y'); }

        if (vowelIndex == 0)
        {
            return word + "yay";
        }

        string firstPart = word.Substring(0, vowelIndex);

        string restWord = word.Substring(vowelIndex);

        return restWord + firstPart + "ay";

       
    }

    
}
