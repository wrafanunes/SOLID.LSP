// See https://aka.ms/new-console-template for more information
using DemoLibrary;
Manager accountingVp = new();
accountingVp.FirstName = "Eugene";
accountingVp.LastName = "Krabs";
accountingVp.CalculatePerHourRate(4);

//se o objeto abaixo for substituído pelos tipos Manager ou CEO, a aplicação cairá em uma exceção, isso viola o LSP.
Employee emp = new();
emp.FirstName = "Sponge";
emp.LastName = "Bob";
emp.AssingManager(accountingVp);
emp.CalculatePerHourRate(-1);

Console.WriteLine($"{emp.FirstName} {emp.LastName}'s salary is ${emp.Salary}/hour");

Console.ReadLine();
