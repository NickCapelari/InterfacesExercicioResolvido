using System.Globalization;
using InterfacesExercicioResolvido.Entities;
using InterfacesExercicioResolvido.Services;

Console.WriteLine("Enter rental data");

Console.Write("Car Model: ");
string model = Console.ReadLine();
Console.Write("Pickup (dd/MM/yyyy hh:ss): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Return (dd/MM/yyyy hh:ss): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Enter price per hour: ");
double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter price per Day: ");
double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rentalService = new RentalService(hour, day);

rentalService.ProcessInvoice(carRental);

Console.WriteLine("Invoice:");
Console.WriteLine(carRental.Invoice);
