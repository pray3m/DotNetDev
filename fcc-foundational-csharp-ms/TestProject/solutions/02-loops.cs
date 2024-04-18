// ! Add Logic to C# Console Applications
// 4. Iterate Through a Code Block Using the for Statement in C#
// 5. Add looping logic to your code using the do-while and while statements in C#

//* FizzBuzz Challenge
// for (int num = 1; num <= 100; num++)
// {
//     if (num % 3 == 0 && num % 5 == 0)
//         Console.WriteLine($"{num} - FizzBuzz");
//     else if (num % 3 == 0)
//         Console.WriteLine($"{num} - Fizz");
//     else if (num % 5 == 0)
//         Console.WriteLine($"{num} - Buzz");
//     else
//         Console.WriteLine(num);
// }

// * Role playing game battle challenge
// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

//     if (hero <= 0) continue;

//     roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");
// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


//* Code project 1 - write code that validates integer input

// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validNumber = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//         valueEntered = readResult;

//     validNumber = int.TryParse(valueEntered, out numValue);

//     if (validNumber)
//     {
//         if (numValue <= 5 || numValue >= 10)
//         {
//             validNumber = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }

// } while (!validNumber);

// Console.WriteLine($"Your input value ({numValue}) has been accepted.");


//* Code project 2 - write code that validates string input

// string? readResult;
// string roleName = "";
// bool isValid = false;

// do
// {
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if (readResult == null)
//         continue;

//     roleName = readResult.Trim().ToLower();
//     if (roleName == "administrator" || roleName == "manager" || roleName == "user")
//         isValid = true;
//     else
//         Console.WriteLine($"The role name that you entered, \"{roleName}\" is not valid.");

// } while (!isValid);

// Console.WriteLine($"Your input value ({roleName}) has been accepted.");


// * Code project 3 - Write code that processes the contents of a string array

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int stringsCount = myStrings.Length;

// string myString = "";
// int periodLocation = 0;

// for (int i = 0; i < stringsCount; i++)
// {
//     myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");

//     string mySentence;

//     // extract sentences from each string and display them one at a time
//     while (periodLocation != -1)
//     {

//         // first sentence is the string value to the left of the period location
//         mySentence = myString.Remove(periodLocation);

//         // the remainder of myString is the string value to the right of the location
//         myString = myString.Substring(periodLocation + 1);

//         // remove any leading white-space from myString
//         myString = myString.TrimStart();

//         // update the comma location and increment the counter
//         periodLocation = myString.IndexOf(".");

//         Console.WriteLine(mySentence);
//     }

//     mySentence = myString.Trim();
//     Console.WriteLine(mySentence);
// }