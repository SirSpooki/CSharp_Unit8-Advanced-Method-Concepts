using static System.Console;
class Reverse3
{
   static void Main()
   {
      int firstInt = 23;
      int middleInt = 45;
      int lastInt = 67;

      WriteLine($"Numbers in order are {firstInt} {middleInt} {lastInt}");
      Reverse(ref firstInt, ref middleInt, ref lastInt);
      WriteLine($"Numbers reversed {firstInt} {middleInt} {lastInt}");

   }
   
   public static void Reverse(ref int a, ref int b, ref int c)
   {
     int temp = a;
     a = c;
     b = b;
     c = temp;
   }

}
