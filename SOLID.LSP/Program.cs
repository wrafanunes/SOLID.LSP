// See https://aka.ms/new-console-template for more information
using DemoLibrary;
IManager accountingVp = new CEO();
accountingVp.FirstName = "Eugene";
accountingVp.LastName = "Krabs";
accountingVp.CalculatePerHourRate(4);

/*o objeto BaseEmployee pode ser substituído por um objeto do tipo Manager, Employee ou CEO, sem que isso cause
 * qualquer problema na apliação, portanto o LSP está sendo respeitado*/
IManaged emp = new Manager();
emp.FirstName = "Sponge";
emp.LastName = "Bob";
emp.AssingManager(accountingVp);
emp.CalculatePerHourRate(2);

Console.WriteLine($"{emp.FirstName} {emp.LastName}'s salary is ${emp.Salary}/hour");

Console.ReadLine();
