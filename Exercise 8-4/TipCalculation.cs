using System;
using static System.Console;
using System.Globalization;
class TipCalculation
{
   static void Main()
   {
      DisplayTipInfo(30.00, .20);
      WriteLine("----------------------------------");
      DisplayTipInfo(30.00, 5);
   }

   public static void DisplayTipInfo(double price, double tipRate)
   {
     double tipDollars, total;
     WriteLine("Meal price: {0}. Tip percent: {1}",price.ToString("C", CultureInfo.GetCultureInfo("en-US")), tipRate.ToString("0.00"));
     tipDollars = (price * tipRate);
     total = price + tipDollars;
     WriteLine("Tip in dollars: {0}.  Total bill {1}", tipDollars.ToString("C", CultureInfo.GetCultureInfo("en-US")), total.ToString("C", CultureInfo.GetCultureInfo("en-US")));
   }
   public static void DisplayTipInfo(double price, int tipInDollars)
   {
     double tipPercent, total;
     tipPercent = tipInDollars/price;
     total = tipInDollars + price;

     WriteLine("Meal price: {0}. Tip percent: {1}",price.ToString("C", CultureInfo.GetCultureInfo("en-US")), tipPercent.ToString("0.00"));
     WriteLine("Tip in dollars: {0}.  Total bill {1}", tipInDollars.ToString("C", CultureInfo.GetCultureInfo("en-US")), total.ToString("C", CultureInfo.GetCultureInfo("en-US")));

   }

}
