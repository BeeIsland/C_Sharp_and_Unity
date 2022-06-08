using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main()
    {

        //String Adder

        string[] stringArray = { "This", "array", "contains", "strings", "that", "can", "be", "changed" };
        StringBuilder addText = new StringBuilder("Starter",255);

        Console.WriteLine("Please type some text to add to each word of the sentence\n'This array contains strings that can be changed'\nIf you wish to continue or exit at any time in the program type 'EXIT'");
        addText = addText.Replace(addText.ToString(),Console.ReadLine());
            
        if (addText.ToString().ToUpper() != "EXIT")
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + addText;
            }

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            Console.ReadLine();
        }

        //Infinite loop

        int counter = 0;
        string stop;
            
        while (true)
        {
            Console.WriteLine(counter);
            counter++;
            stop = Console.ReadLine();
            if (stop.ToUpper() == "EXIT")
            {
                break;
            }
        }

        //Number guessing game

        int givenNum = 0;
        string rawNum;
        int setNum = 189;
        int difference = givenNum - setNum;

        while (!(difference <= 10 && difference > -10))
        {
            Console.WriteLine("Pick a number between 1 and 200");
            rawNum = Console.ReadLine();

            if (rawNum.ToUpper() == "EXIT")
            {
                break;
            }

            givenNum = Convert.ToInt32(rawNum);

            difference = givenNum - setNum;
        }

        if (difference <= 10 && difference > -10)
        {
            Console.WriteLine("You guessed the number!");
            Console.ReadLine();
        }

        //String searching

        string searchString;
        int occurCounter = 0;
        bool dontWait = false;

        while (occurCounter == 0)
        {
            Console.WriteLine("\nType some text and I'll give you all the places it appears in my data");
            searchString = Console.ReadLine();
            occurCounter = 0;

            if (searchString.ToUpper() == "EXIT")
            {
                dontWait = true;
                break;
            }

            List<string> stringList = new List<string>() { "words", "this", "list", "has", "several", "of", "indeed", "wow", "and", "don't", "you", "wish", "it", "had", "more", };

            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i].ToLower().Contains(searchString.ToLower()))
                {
                    Console.WriteLine(i);
                    occurCounter += 1;
                }
            }

            if (occurCounter == 0)
            {
                Console.WriteLine("It seems that what you typed didn't appear in my data");
            }
        }
        if (!dontWait)
        {
            Console.ReadLine();
        }
            

        //Matching strings

        string searchString2;
        int occurCounter2 = 0;
        bool dontWait2 = false;

        while (occurCounter2 == 0)
        {
            Console.WriteLine("\nType some text and I'll give you all the places it appears in my data\n(Some data appears twice)");
            searchString2 = Console.ReadLine();
            occurCounter2 = 0;

            if (searchString2.ToUpper() == "EXIT")
            {
                dontWait2 = true;
                break;
            }

            List<string> stringList2 = new List<string>() { "words", "this", "list", "has", "several", "of", "indeed", "wow", "and", "don't", "you", "wish", "it", "had", "more", "well", "now", "it", "does", "indeed", "have", "more", };

            for (int i = 0; i < stringList2.Count; i++)
            {
                if (stringList2[i].ToLower().Contains(searchString2.ToLower()))
                {
                    Console.WriteLine(i);
                    occurCounter2 += 1;
                }
            }

            if (occurCounter2 == 0)
            {
                Console.WriteLine("It seems that what you typed didn't appear in my data");
            }
        }
        if (!dontWait2)
        {
            Console.ReadLine();
        }

        //Foreach Matching Strings

        List<string> stringList3 = new List<string>() { "words", "this", "list", "has", "several", "of", "indeed", "wow", "and", "don't", "you", "wish", "it", "had", "more", "well", "now", "it", "does", "indeed", "have", "more", "and", "just", "for", "kicks", "I", "added", "a", "few", "extra", };
        List<string> modList = new List<string>() { "words", "this", "list", "has", "several", "of", "indeed", "wow", "and", "don't", "you", "wish", "it", "had", "more", "well", "now", "it", "does", "indeed", "have", "more", "and", "just", "for", "kicks", "I", "added", "a", "few", "extra", };
        List<string> skipWord= new List<string>();

        Console.WriteLine("Text | Duplicate?");

        foreach (string word in stringList3)
        {
            if (skipWord.Contains(word))
            {
                continue;
            }
            modList.Remove(word);
            if (modList.Contains(word))
            {
                Console.WriteLine(word + " |         True");
            }
            else
            {
                Console.WriteLine(word + " | False");
            }
            skipWord.Add(word);
        }
        Console.ReadLine();
    }
}

