// .NET 5.x supports the use of a "top-level program" - that is, one file that is considered the "top"
// For a top-level program, the VS compiler will assume that the context of the code you are writing is
// that of the Main(string[] args) method

// 0) Using statements for the libraries that you are working with
using System;
using static System.Console;

// 1) Body of the Main method
// WriteLine is a public static method of the Console class
WriteLine("Hello World!");
Write("Enter a product name: ");
string name = ReadLine();
Write("Enter a price: ");
decimal price = decimal.Parse(ReadLine());
Product item = new Product(name, price);
Display(item);

// 2) Declare other members of the class that is wrapping this Main method - like methods/properties
void Display(object thing)
{
    WriteLine(thing);
}

// 3) Declare other data types
// .NET 5 introduces the record keyword that is used for a special type of class
public record Product(string Name, decimal Price);