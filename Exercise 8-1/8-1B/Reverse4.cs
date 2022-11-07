using static System.Console;
class Reverse4
{
   static void Main()
   {
      int int1 = 23;
      int int2 = 45;
      int int3 = 55;
      int int4 = 67;

      WriteLine($"Numbers in order: {int1} {int2} {int3} {int4}");
      Reverse(ref int1, ref int2, ref int3, ref int4);
      WriteLine($"Numbers reversed: {int1} {int2} {int3} {int4}");
      
   }

   public static void Reverse(ref int a, ref int b, ref int c, ref int d)
   {
     int temp1, temp2;
     temp1 = a;
     temp2 = b;
     
     a = d;
     b = c;
     c = temp2;
     d = temp1;
   }

}
