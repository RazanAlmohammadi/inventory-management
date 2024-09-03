// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
var chocolateBar = new Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
Console.WriteLine($"Item Name: {waterBottle.Name}, Quantity: {waterBottle.Quantity}, Created Date: {waterBottle.CreatedDate}");
Console.WriteLine($"Item Name: {chocolateBar.Name}, Quantity: {chocolateBar.Quantity}, Created Date: {chocolateBar.CreatedDate}");
var coffee = new Item("Coffee", 20);
Console.WriteLine($"Item Name: {chocolateBar.Name}, Quantity: {chocolateBar.Quantity}");