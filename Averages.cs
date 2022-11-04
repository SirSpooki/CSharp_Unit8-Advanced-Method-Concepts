using static System.Console;
public class Averages
{
   public static void Main()
   {
      Average(7,4);
   }

   public static void Average(params double[] numbers) 
   {
     double sum = 0;
     foreach(double num in numbers)
      {
        sum += num;
        Write(num+" ");
      }
      double avg = sum/numbers.Length;
      Write($" -- Average is {avg}");
      
   }

}
