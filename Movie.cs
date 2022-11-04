using static System.Console;
class Movie
{
   static void Main()
   {
      DisplayMovie("Titanic", 182);
      DisplayMovie("Titanic");
   }

   public static void DisplayMovie(string movie, int minutes = 90)
   {
      WriteLine($"The movie {movie} has a running time of {minutes} minutes.");
   }
}
