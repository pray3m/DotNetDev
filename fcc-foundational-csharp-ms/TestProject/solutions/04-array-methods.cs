// ! Perform Operations on Arrays Using Helper Methods in C#

// string[] pallets = { "B14", "A11", "B12", "A13" };

// Sort
// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// Console.WriteLine();

// Reverse
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0]}");
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

//* Exercise - Complete a challenge to reverse words in a sentence

// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] message = pangram.Split(' ');

// string[] newMessage = new string[message.Length];
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);


// }

// string result = String.Join(" ", newMessage);
// System.Console.WriteLine(result);


// * Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] orders = orderStream.Split(",");
// Array.Sort(orders);

// for (int i = 0; i < orders.Length; i++)
// {
//     string order = new string(orders[i]);
//     if (order.Length != 4)
//     {
//         System.Console.WriteLine($"{order} --- Error");
//     }
//     else
//     {
//         System.Console.WriteLine(order);
//     }
// }
