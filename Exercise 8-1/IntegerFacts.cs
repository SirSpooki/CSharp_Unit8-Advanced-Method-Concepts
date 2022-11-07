using static System.Console;
using System;
using System.Linq;
class IntegerFacts
{
  static int[] nums = new int[10];
   static void Main()
   { 
      int arrayCount, high, low, sum;
      double avg;
      
      arrayCount = FillArray(nums);
      Statistics(nums, arrayCount, out high, out low, out sum, out avg);
   }

   public static int FillArray(int[] array)
   {
     string user = "";
     int count = 0;
     int addnum = 0;
     while(addnum != 999 && count < nums.Length)
      {
        WriteLine("Enter an Integer or 999 to QUIT");
        user = ReadLine();
        if(user == "999")
          {
            break;
          }
        while (!int.TryParse(user, out array[count]))
            {
              WriteLine("Error");
              Write("Enter a number or 999 to exit: ");
              user = ReadLine();
            }
            array[count] = Convert.ToInt32(user);
            addnum = array[count];
            ++count;
      }
      return count;
   }
   public static void Statistics(int[] array, int els, out int high, out int low, out int sum, out double avg)
   {
        
        Array.Resize(ref array, els);
        high = array.Max();
        low = array.Min();
        sum = array.Sum();
        avg = array.Average();

        WriteLine("The array has {0} values", els);
        WriteLine("The highest value is {0}", high);
        WriteLine("The lowest value is {0}", low);
        WriteLine("The sum of the values is {0}", sum);
        WriteLine("The average is {0}", avg);

   }   

}
