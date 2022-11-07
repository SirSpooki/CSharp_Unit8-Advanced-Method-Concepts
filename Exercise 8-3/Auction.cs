using static System.Console;
using System;
using System.Linq;
using System.Text.RegularExpressions;
public class Auction
{
   static void Main()
   {   string user;
       int userInt;
       double userDouble;
       const int MIN = 10;
       WriteLine("Enter bid amount >> ");
       user = ReadLine();

      if(int.TryParse(user, out userInt))
        {
            AcceptBid(userInt, MIN);
        }
      if(double.TryParse(user,out userDouble))
        {
            AcceptBid(userDouble, MIN);
        }
      if(user.StartsWith("$") || user.EndsWith("dollars"))
        {
            AcceptBid(user, MIN);
        }
      else
        {
          WriteLine("Bid was not in correct format");
        }
   }
    
   public static void AcceptBid(int bid, int min)
   {
     if (bid >= min)
        {
          WriteLine("Bid accepted");
        }
    else
      {
        WriteLine("Bid not high enough");
      }
   }
   public static void AcceptBid(double bid, int min)
   {
     if (bid >= min)
        {
          WriteLine("Bid accepted");
        }
    else
      {
        WriteLine("Bid not high enough");
      }
   }
   public static void AcceptBid(string bid, int min)
   {
      if(bid.Any(char.IsDigit))
        {
          string[] numbers = Regex.Split(bid, @"\D+");
          foreach (string value in numbers)
            {
              if (!string.IsNullOrEmpty(value))
                {
                  int i = int.Parse(value);
                  if(i >= 10)
                    {
                      WriteLine("Bid accepted");
                    }
                  else
                    {
                      WriteLine("Bid not high enough");
                    }
                }
            }

        }
      else
        {
          WriteLine("Bid was not in correct format");
        }
   }

}
