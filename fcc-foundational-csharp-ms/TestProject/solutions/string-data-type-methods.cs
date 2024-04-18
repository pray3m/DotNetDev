// !Modify the Content of Strings Using Built-In String Data Type Methods in C#

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length+1));


// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }

//
// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData); 
// OUTPUT : 123455000  3



// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);
// OUTPUT : This is example data

// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// // Your work here

// // Extract the "quantity"
// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
// int quantityEnd = input.IndexOf(closeSpan);
// int quantityLength = quantityEnd - quantityStart;
// quantity = input.Substring(quantityStart, quantityLength);
// quantity = $"Quantity: {quantity}";

// // Set output to input, replacing the trademark symbol with the registered trademark symbol
// const string tradeSymbol = "&trade;";
// const string regSymbol = "&reg;";
// output = input.Replace(tradeSymbol, regSymbol);

// // Remove the opening <div> tag
// const string openDiv = "<div>";
// int divStart = output.IndexOf(openDiv);
// output = output.Remove(divStart, openDiv.Length);

// // Remove the closing </div> tag and add "Output:" to the beginning
// const string closeDiv = "</div>";
// int divCloseStart = output.IndexOf(closeDiv);
// output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

// Console.WriteLine(quantity);
// Console.WriteLine(output);

// OUTPUT:
// Quantity: 5000
// Output: < h2 > Widgets & reg;</ h2 >< span > 5000 </ span >