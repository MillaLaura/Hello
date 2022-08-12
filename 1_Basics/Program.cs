#region Assignment; Write your own story
/* Todays assignment
*   Run this program
*   Read and understand this programs source code
*   Write a short story using the Console for input and output
*   Try to make use of as many of the below techniques as possible
*/

//Console.WriteLine("...");
//Console.ReadLine();
//int.Parse("123");
//if, elseif, else

//bool ExampleBool = true;
//int ExampleInt = 123;
//float ExampleFloat = 123.21f;
//string ExampleString = "Example 123";
#endregion


#region Variables
Console.WriteLine("What is your name?");

//<Type> <Name> = <Value> ;
string myString = "This is how to define a string variable!";

//Reading a string from the console
myString = Console.ReadLine();

//Writing it back to the console
Console.WriteLine("Aaah, Hello " + myString + ", good to see you :)");
#endregion

#region Data types
Console.WriteLine("Do you want a cup of tea?");
/*
* The four main basic types we we will work with in the beginning are:
* bool, Int, Float and String   
* bool or boolean, can only be 'true' or 'false'
* Int, or integer, is a whole number; 1, 2, 3
* Float is a decimal number; 3.14 or 7.777
* Strings is just text found between quotationmarks "This is a string, easy right?"
*
* Programmers use these different types to better communicate their thoughts and optimize the program
* C# have, at the time of writing; 10 different types of numbers, choosing the right ones can be key to your objective.
*
* There are many different data types which can be explored in the Microsoft C# documentation, see link below.
* https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
*/

string answer = Console.ReadLine();

bool LearnAboutDataTypes = false;
if(answer == "no"){
    LearnAboutDataTypes = true;
}

if(LearnAboutDataTypes == true){
    Console.WriteLine("Ah well, it was poisoned anyway");
    
}
#endregion
Console.WriteLine("...The end...");
Console.ReadLine(); //Stops program from exiting until we press a key


/* Teachers corner

* Operators; +, -, /, *, %, ++, --

* Casting
int.Parse()
Convert.ToInt32()
(int)
*/