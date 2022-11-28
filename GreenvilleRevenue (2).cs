using System; using static System.Console; using System.Globalization;

//Implementation of GreenvilleRevenue class

class GreenvilleRevenue

{

//Implementation of Main method

static void Main()

{

//Declare ENTRANCE_FEE as type of integer constant

const int ENTRANCE_FEE = 25;

//Declare MIN_CONTESTANTS as type of integer constant

const int MIN_CONTESTANTS = 0;

//Declare MAX_CONTESTANTS as type of integer constant

const int MAX_CONTESTANTS = 30;

//Declare numThisYear as type of integer

int numThisYear;

//Declare numLastYear as type of integer

int numLastYear;

//Declare revenue as type of integer

int revenue;

//Declare names as type of array of strings

string[] names = new string[MAX_CONTESTANTS];

//Declare talents as type of array of characters

char[] talents = new char[MAX_CONTESTANTS];

//Declare talentCodes as type of array of characters

char[] talentCodes = { 'S', 'D', 'M', 'O' };

//Declare talentCodesStrings as type of array of strings

string[] talentCodesStrings = { "Singing", "Dancing", "Musical instrument", "Other" };

//Declare counts as type of array of integers

int[] counts = { 0, 0, 0, 0 };

//numLastYear which contains the return value of GetContestantNumber method

numLastYear = getContestantNumber("last", MIN_CONTESTANTS, MAX_CONTESTANTS);

//numThisYear which contains the return value of GetContestantNumber method

numThisYear = getContestantNumber("this", MIN_CONTESTANTS, MAX_CONTESTANTS);

//calcualte revenue , which is product of numThisYear and ENTRANCE_FEE

revenue = numThisYear * ENTRANCE_FEE;

//Display statement for Last year's competition

WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants",

numLastYear, numThisYear);

//Display statement for Revenue expected this year

WriteLine("Revenue expected this year is {0}", revenue.ToString("C"));

//call DisplayRelationship method with parameters

DisplayRelationship(numThisYear, numLastYear);

//call GetContestantData method with parameters

getContestantData(numThisYear, names, talents, talentCodes, talentCodesStrings, counts);

//call GetLists method with parameters

getLists(numThisYear, talentCodes, talentCodesStrings, names, talents, counts);

}

//Implementation of GetContestantNumber method with parameters

public static int getContestantNumber(string when, int min, int max)

{

//Declare entryString as type of String

string entryString;

//Declare num as type of integer

int num;

//Iterate the loop

while (true)

{

//Display statement

Write("Enter the number of contestants {0} year >> ", when);

//call ReadLine method

entryString = ReadLine();

//check with TryParse whether entryString

//is valid or Invalid

if (!int.TryParse(entryString, out num))

{

//Display statement

WriteLine("Number is InValid Contestant.Please Enter Valid Contestant Number");

continue;

}

else

{

//otherwise break the loop

break;

}

}

//Iterate the loop

while (num < min || num > max)

{

//Display statement

WriteLine("Number must be between {0} and {1}", min, max);

//Display statement

Write("Enter number of contestants {0} year >> ", when);

//call ReadLine method

entryString = ReadLine();

//convert entryString into Integer

num = Convert.ToInt32(entryString);

}

return num;

}

//Implementation of DisplayRelationship method with parameters numThisYear ,numLastYear

//as type of integer

public static void DisplayRelationship(int numThisYear, int numLastYear)

{

//check numThisYear is greater than 2 * numLastYear or not

if (numThisYear > 2 * numLastYear)

{

//Display statement

WriteLine("The competition is more than twice as big this year!");

}

//check numThisYear is greater than numLastYear

else if (numThisYear > numLastYear)

{

//Display statement

WriteLine("The competition is bigger than ever!");

}

else if (numThisYear < numLastYear)

{

//Display statement

WriteLine("A tighter race this year! Come out and cast your vote!");

}

}

//Implementation of GetContestantData method

public static void getContestantData(int numThisYear, string[] names, char[] talents,

char[] talentCodes, string[] talentCodesStrings, int[] counts)

{

//Declare x as type of integer

int x = 0;

//Declare isValid as type of integer

bool isValid;

//Iterate the loop

while (x < numThisYear)

{

//Display statement

Write("Enter contestant name >> ");

//call ReadLine method

names[x] = ReadLine();

//Display statement

WriteLine("Talent codes are:");

//Iterate the loop

for (int y = 0; y < talentCodes.Length; ++y)

{

//Display statement

WriteLine(" {0} {1}", talentCodes[y], talentCodesStrings[y]);

}

//Assign false to isValid

isValid = false;

//Iterate the loop

while (!isValid)

{

//Display statement

Write(" Enter talent code >> ");

//convert Char using TryParse method

isValid = Char.TryParse(ReadLine(), out talents[x]);

//check isValid or not

if (!isValid)

{

//Display statement

WriteLine("InValid code.Please enter Valid code");

continue;

}

//Assign false to isValid

isValid = false;

//Iterate the loop

for (int z = 0; z < talentCodes.Length; ++z)

{

//check talents[x] is equal to talentCodes[z] or npot

if (talents[x] == talentCodes[z])

{

//Assign true to isValid

isValid = true;

//increment ++counts[z]

++counts[z];

}

}

//check isValid or not

if (!isValid)

{

//Display statement

WriteLine("{0} is not a valid code", talents[x]);

continue;

}

}

//increment the x

++x;

}

}

//Implementation of GetLists method with appropriate parameters

public static void getLists(int numThisYear, char[] talentCodes, string[] talentCodesStrings,

string[] names, char[] talents, int[] counts)

{

//Decalre x as type of integer

int x;

//Declare QUIT as type of char aand

//Assign Z to QUIT

char QUIT = 'Z';

//Declare option as type of character

char option;

//Declare isValid as type of boolean

bool isValid;

//Declare pos as type of integer

int pos = 0;

//Declare found as type of integer

bool found;

//Display statement for the types of talent

WriteLine("\nThe types of talent are:");

//Iterate the loop

for (x = 0; x < counts.Length; ++x)

{

//Display statement

WriteLine("{0, -20} {1, 5}", talentCodesStrings[x], counts[x]);

}

//Assign 'c' to option

option = 'c';

//Iterate the loop up to option is not equal to QUIT

while (option != QUIT)

{

//Display statement for Enter a talent type

Write("\nEnter a talent type or {0} to quit >> ", QUIT);

//check with TryParse method with value is converted or not

if (!Char.TryParse(ReadLine(), out option))

{

//Display statement for Invalid

WriteLine("It is Invalid.Please Enter valid code");

//continue the loop

continue;

}

//Assign false to isValid

isValid = false;

//Iterate the loop

for (int z = 0; z < talentCodes.Length; ++z)

{

//check option is equal to talentCodes[z] or not

if (option == talentCodes[z])

{

//Assign true to isValid

isValid = true;

//Assign z to pos

pos = z;

}

}

if (!isValid)

{

//Display statement

WriteLine("{0} is not a valid code", option);

}

else

{

//Display statement

WriteLine("\nContestants with talent {0} are:", talentCodesStrings[pos]);

//Assign false to found

found = false;

//Iterate the loop

for (x = 0; x < numThisYear; ++x)

{

//check talents[x] is equal to option

if (talents[x] == option)

{

//call WriteLine method with parameter names[x]

WriteLine(names[x]);

//Assign true to found

found = true;

}

}

//check found exist or not

if (!found)

{

//Display statement

WriteLine("No contestants had talent {0}", talentCodesStrings[pos]);

}

}

}

}

}
