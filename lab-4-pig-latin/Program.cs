// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Welcome to the Pig Latin Translator!");

bool runProgram = true;
while (runProgram) {

    Console.WriteLine("Enter a line to be translated:");
    string word = Console.ReadLine().ToLower();

    //"clean" the string to only have first letter capitalized
    //use Substring() to target first letter
    //string cleaned = dirty.Substring(0, 1).ToUpper() + dirty.Substring(1).ToLower();

    //vowel finder
    int vowelIndex = -1;
    foreach (char letter in word)
    {
        vowelIndex = vowelIndex + 1;; //advance to next letter of line
        if (letter == 'a'
            || letter == 'e'
            || letter == 'i'
            || letter == 'o'
            || letter == 'u')
        {
            break;
        }
    }

    //what do with vowel? (update)

    string pigLatinWord = "";
    string beforeLetters = "";
    string afterLetters = "";
    switch(vowelIndex)
    {
        //word starts with vowel: append "way"
        case 0: 
            pigLatinWord = word + "way";
            break;
        //word starts with 1 consonant: 1st letter at end + "ay"
        case 1:
            beforeLetters = word.Substring(0, 1);
            afterLetters = word.Substring(1);
            pigLatinWord = afterLetters + beforeLetters + "ay";
            //empty second Substring() parameter automatically goes to end of string
            break;
        //word starts with 2 consonants
        //what about 2+ letter consonant clusters?
        case 2:
            beforeLetters = word.Substring(0, 2);
            afterLetters = word.Substring(2);
            pigLatinWord = afterLetters + beforeLetters + "ay";
            break;
        case 3: //3 letter consonant clusters? (three, thrum, etc)
            beforeLetters = word.Substring(0, 3);
            afterLetters = word.Substring(3);
            pigLatinWord = afterLetters + beforeLetters + "ay";
            break;
        default:
            pigLatinWord = "Orrysay, unableway otay anslatetray.";
            break;
    }

    Console.WriteLine($"Translation: {pigLatinWord}");


    
    while (true)
    {
        Console.WriteLine("Would you like to translate another word? (y/n)");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "n")
        {
            Console.WriteLine("See ya!");
            runProgram = false;
            break;
        }
        else if (choice == "y")
        {

            runProgram = true;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}



Console.ReadLine();
//tests
//vowel:
//Apple
//Appleway
//con:
//What
//atWhay

//string substr1 = text.Substring(0, 1);
//string substr2 = text.Substring(1, 2);

//    Substring for splitting
//substring(starting index, how many characters)
//for (int i = 0; i < input.length; i++)
//            two substrings to build the word
//result = second half of word + first half of word + "ay"

//Pig Latin =

//conditional if vowel

//while loop to re-run program