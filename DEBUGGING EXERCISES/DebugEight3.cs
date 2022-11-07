using static System.Console;
class DebugEight3
{
static void Main()
  {
    WriteLine("Tuition is {0}", CalculateTuition(15));
    WriteLine("Tuition is {0}",CalculateTuition(15, 'O'));
    WriteLine("Tuition is {0}",CalculateTuition(15, 'O', true));
  }
public static double CalculateTuition(double credits, char code = 'I', bool scholarship = false)
  {
    double tuition;
    const double RATE=80.00;
    const double OUT_DISTRICT_FEE=300.00;
    tuition = credits * RATE; //compute the tuition fees
    if(code != 'I') //condition for student is not in_district
    tuition += OUT_DISTRICT_FEE; //add out of district fees
    if(scholarship) //check for scholarship
    tuition = 0; //if true then set 0 to tuition fees
    return tuition;
  }
}
