// .NET 5.x supports the use of a "top-level program" - that is, one file that is considered the "top"
// 0) Using statements
using System;
using static System.Console;
using System.IO; // This allows us access to the File and Directory and other classes
using System.Text.Json; // This contains classes for working with JSON
using System.Text.Json.Serialization; // contains classes/types for serializing (load/save) JSON

// 1) Body of the Main method
WriteLine("Hello World!");
Write("Enter a product name: ");
string name = ReadLine();
Write("Enter a price: ");
double price = double.Parse(ReadLine());
Write("Enter the inventory quantity: ");
int qty = int.Parse(ReadLine());
Product item = new Product(name, price, qty);
Display(item);

const string fileName = "Inventory.txt"; // Where this file will exist??
if (File.Exists(fileName)) // Add to the existing file
    File.AppendAllText(fileName, $"\n{item}");
else // Create a new file
    File.WriteAllText(fileName, item.ToString());
OutputToJSON(item);

// 2) Local methods/properties/fields
void OutputToJSON(object data) // This makes it more "general purpose" to output any kind of object
{
    const string fileName = "Inventory.json";
    string jsonString = JsonSerializer.Serialize(data);
    File.WriteAllText(fileName, jsonString);
}


void Display(object data)
{
    WriteLine(data);
}

// 3) Other declaration types - recognizes that all the code above is inside the default Program class
// .NET 5 introduces the record keyword that is used for a special kind of class
// A record is a data type that can be defined by just indicating the signature of the constructor
// where the names of the parameters also become the names of properties on the data type.
public record Product(string Name, double Price, int QuantityOnHand);
