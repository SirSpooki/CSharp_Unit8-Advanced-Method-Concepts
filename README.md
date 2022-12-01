# CSharp_Unit8-Advanced-Method-Concepts

SlayTeam

# Exercise Instructions
8-1
-
Create a program named IntegerFacts whose Main() method declares an array of 10 integers. Call a method to interactively fill the array with any number of values up to 10 or until a sentinel value is entered. If an entry is not an integer, reprompt the user. Call a second method that accepts out parameters for the highest value in the array, lowest value in the array, sum of the values in the array, and arithmetic average. In the Main() method, display all the statistics.

8-1A & B
-
Create a program named Reverse3 whose Main() method declares three integers named firstInt, middleInt, and lastInt. Assign values to the variables, display them, and then pass them to a method that accepts them as reference variables, places the first value in the lastInt variable, and places the last value in the firstInt variable. In the Main() method, display the three variables again, demonstrating that their positions have been reversed.

Create a new program named Reverse4, which contains a method that reverses the positions of four variables. Write a Main() method that demonstrates the method works correctly.

8-2
--
Create a program for Smalltown Regional Airport Flights that accepts either an integer flight number or string airport code from the options in Figure 8-33. Pass the user’s entry to one of two overloaded GetFlightInfo() methods, and then display a returned string with all the flight details. The method version that accepts an integer looks up the airport code, name, and time of flight; the version that accepts a string description looks up the flight number, airport name, and time. The methods return an appropriate message if the flight is not found.

8-3
--
Create a program named Auction that allows a user to enter an amount bid on an online auction item. Include three overloaded methods that accept an int, double, or string bid. Each method should display the bid and indicate whether it is over the minimum acceptable bid of $10. If the bid is a string, accept it only if one of the following is true: it is numeric and preceded with a dollar sign, or it is numeric and followed by the word dollars. Otherwise, display a message that indicates the format was incorrect.

8-4
--
Create a program named TipCalculation that includes two overloaded methods—one that accepts a meal price and a tip as doubles (for example, 30.00 and 0.20, where 0.20 represents a 20 percent tip), and one that accepts a meal price as a double and a tip amount as an integer (for example, 30.00 and 5, where 5 represents a $5 tip). Each method displays the meal price, the tip as a percentage of the meal price, the tip in dollars, and the total of the meal plus the tip. Include a Main() method that demonstrates each method.

8-5
--
Write a program named InputMethodDemo2 that eliminates the repetitive code in the InputMethod() in the InputMethodDemo program in Figure 8-5. Rewrite the program so the InputMethod() contains only two statements:

![image](https://user-images.githubusercontent.com/114715053/205137136-da891bfa-3b73-4912-ba69-38a1485ec38f.png)

8-6
--
Write a program named Averages that includes a method that accepts any number of numeric parameters, displays them, and displays their average. Demonstrate that the method works correctly when passed one, two, or three numbers, or an array of numbers.

8-7
--
Write a program named SortWords that includes a method that accepts any number of words and sorts them in alphabetical order. Demonstrate that the program works correctly when the method is called with one, two, five, and ten words.

8-8
--
Write a program named Movie that contains a method that accepts and displays two parameters: a string name of a movie and an integer running time in minutes. Provide a default value for the minutes so that if you call the method without an integer argument, minutes is set to 90. Write a Main() method that proves you can call the movie method with only a string argument as well as with a string and an integer.

# Case Problems

1. In Chapter 7, you modified the GreenvilleRevenue program to include a number of methods. Now modify every data entry statement to use a TryParse() method to ensure that each piece of data is the correct type. Any invalid user entries should generate an appropriate message, and the user should be required to reenter the data.



2. In Chapter 7, you modified the MarshallsRevenue program to include a number of methods. Now modify every data entry statement to use a TryParse() method to ensure that each piece of data is the correct type. Any invalid user entries should generate an appropriate message, and the user should be required to reenter the data.
