## StringCounter
### Description
It's a C# library that adds extension methods to strings to do a couple cool things.

### What It Does
This library (when provided with a string obviously) will allow the programmer to count the # of words in a string or get the first letter of each word.<br/>
This can be useful if you're trying to make a program that tells the user how many words they've typed.
```csharp

using StringCounter;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        string sentence = "'; The quick BROWN FOX jUmPeD over the LaZy dOG;.";
        
        Console.WriteLine(sentence);
        // output: '; The quick BROWN FOX jUmPeD over the LaZy dOG;.
        
        Console.WriteLine("\nThe sentence above has {0} words.", sentence.CountWords());
        // output: The sentence above has 9 words.
        
        Console.WriteLine("\nWord Beginnings:");
        Console.WriteLine(sentence.GetWordBeginnings());
        // output: Word Beginnings:
        // output: T, q, B, F, j, o, t, L, d
        
        // total output
        /*
            '; The quick BROWN FOX jUmPeD over the LaZy dOG;.
            
            The sentence above has 9 words.
            
            Word Beginnings:
            T, q, B, F, j, o, t, L, d
        */
    }
}

```

### Download (C# Library)
[StringCounter.dll](https://github.com/Lexz-08/StringCounter/releases/download/string-counter/StringCounter.dll)

### Download (C# Library / Console To Test DLL)
[StringCounter.zip](https://github.com/Lexz-08/StringCounter/releases/download/string-counter/StringCounter.zip)
