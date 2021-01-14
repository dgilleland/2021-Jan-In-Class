// .NET 5.x supports the use of a "top-level program" - that is, one file that is considered the "top"
// For a top-level program, the VS compiler will assume that the context of the code you are writing is
// that of the Main(string[] args) method

// 0) Using statements for the libraries that you are working with
using System;
using static System.Console;
using System.IO; // This allows us access to the File and Directory and other classes
using System.Text.Json; // This contains classes for working with JSON
using System.Text.Json.Serialization; // Contains classes/types/extensions for serializing JSON (load/save)

// 1) Body of the Main method
// WriteLine is a public static method of the Console class
WriteLine("Hello World!");
Write("Enter a product name: ");
string name = ReadLine();
Write("Enter a price: ");
decimal price = decimal.Parse(ReadLine());
Product item = new Product(name, price);
Display(item);

const string fileName = "Inventory.txt"; // Where will this file exist??
if (File.Exists(fileName)) // Add to the existing file
    File.AppendAllText(fileName, $"\n{item}");
else // Create a new file
    // Open/create the "Inventory.txt" file and write out all of the text from the item object
    File.WriteAllText(fileName, item.ToString());

// Now, let's output this as JSON
OutputToJSON(fileName, item);

// 2) Declare other members of the class that is wrapping this Main method - like methods/properties
void OutputToJSON(string filePath, Product data)
{
    if (filePath.EndsWith(".txt"))
        filePath = filePath.Replace(".txt", ".json");
    else if (!filePath.EndsWith(".json"))
        filePath = filePath + ".json";
    string jsonString = JsonSerializer.Serialize(data);
    File.WriteAllText(filePath, jsonString);
}

void Display(object thing)
{
    WriteLine(thing);
}

// 3) Declare other data types
// .NET 5 introduces the record keyword that is used for a special type of class
public record Product(string Name, decimal Price);