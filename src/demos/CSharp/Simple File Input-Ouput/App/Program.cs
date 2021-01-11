// .NET 5.x supports the use of a "top-level program" - that is, one file that is considered the "top"
// 0) Using statements
using System;
using static System.Console;

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

// 2) Local methods/properties/fields
void Display(object data)
{
    WriteLine(data);
}


// 3) Other declaration types
// .NET 5 introduces the record keyword that is used for a special kind of class
public record Product(string Name, double Price, int QuantityOnHand);
