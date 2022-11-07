using static System.Console;
class DebugEight2 {
    static void Main() {
        int numericScore = 82;
        string letterScore = "B";
        Write("\"Score was {0}. ",numericScore);
        GiveBonus(ref numericScore);
        Write("Now it is {0}.\" ",numericScore);
        Write("\"Grade was {0}. ",letterScore);
        GiveBonus(ref letterScore);
        Write("Now it is {0}.\"",letterScore);
    }

    public static void GiveBonus(ref int numericScore)
    {
        const int BONUS = 5;
        numericScore +=BONUS;
    }
    
    public static void GiveBonus(ref string letterScore)
    {
        const string BONUS = "+";
        letterScore += BONUS;
    }
}
