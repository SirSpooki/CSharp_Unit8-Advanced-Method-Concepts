using static System.Console;
using System;
using System.Linq;
class Flights
{
   static int [] flightNumbers = {201  , 321  , 510, 633};
   static string [] codes = {"AUS", "CRP", "DFW", "HOU"};
   static string [] names = {"Austin", "Corpus Christi", "Dallas Fort Worth", "Houston"};
   static string[] times = {"0710", "0830", "0915", "1140"};

   static void Main()
   {
      string user = "";
      WriteLine("Enter flight numer or Airport Code >>");
      user = ReadLine();

      if(user.All(char.IsDigit))
        {
          int userNum = Convert.ToInt32(user);
          String Validation = GetFlightInfo(userNum, flightNumbers, codes, names, times);
          WriteLine(Validation);
        }
      else
        {
          String Validation = GetFlightInfo(user, flightNumbers, codes, names, times);
          WriteLine(Validation);
        }
   }
    
   public static string GetFlightInfo(int flight, int[] flightNumbers, string[] codes, string[] names, string[] times)
   {
     string Validation = "";
     int x = Array.BinarySearch(flightNumbers, flight);
     if(x >= 0)
      {
        Validation = $"Flight #{flight} {codes[x]} {names[x]}  Scheduled at: {times[x]}";
      }
     else
      {
        Validation = $"Flight #{flight} was not found";
      }
      return Validation;
   }   
   public static string GetFlightInfo(string code, int[] flightNumbers, string[] codes, string[] names, string[] times)
   {
     string Validation = "";
     int x = Array.BinarySearch(codes, code);
     if(x >= 0)
      {
        Validation = $"Flight #{flightNumbers[x]} {codes[x]} {names[x]}  Scheduled at: {times[x]}";
      }
     else
      {
        Validation = $"Flight to {code} was not found";
      }
      return Validation;
   }

}
