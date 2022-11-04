using System;
using static System.Console;
public class SortWords
{
   public static void Main()
   {
      SortAndDisplayWords("Bravo", "Charlie", "Alpha", "Zulu");
   }
    
   public static void SortAndDisplayWords(params string[] words)
   {
     Array.Sort(words);
     foreach(string word in words)
      {
        Write(word + " ");
      }
   }
}
