// ! Convert data types using casting and conversion techniques in C#

// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// string value = "102p";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

//* Exercise - Complete a challenge to combine string array values as strings and as integers
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// string message = "";
// decimal total = 0m;

// for (int i = 0; i < values.Length; i++)
// {
//     decimal num;
//     if (decimal.TryParse(values[i], out num))
//     {
//         total += num;
//     }
//     else
//     {
//         message += values[i];
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"total  : {total}");

//* Exercise - Complete a challenge to output math operations as specific number types
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32(value1 / value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");