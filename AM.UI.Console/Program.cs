// See https://aka.ms/new-console-template for more information


using AM.Core.Domain;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");
Plane p1 = new Plane();
p1.Capacity = 100;
p1.ManufactureDate = new DateTime(2000, 1, 1);
p1.Planeid = 101;
p1.MyPlaneType = PlaneType.Boing;

Plane p2 = new Plane(PlaneType.Boing, 100, new DateTime(2000, 1, 1));

Plane p3 = new Plane()
{
    Capacity = 100,
    ManufactureDate = new DateTime(2000, 1, 1),
    Planeid = 101,
    MyPlaneType = PlaneType.Boing
};
Passenger passenger1 = new Passenger();
Staff staff1 = new Staff();
Traveller traveller1 = new Traveller();


Console.WriteLine(passenger1.GetPassengerType());
Console.WriteLine(staff1.GetPassengerType());
Console.WriteLine(traveller1.GetPassengerType());

passenger1.BirthDate = new DateTime(1995, 5, 15);
int age = new int();
passenger1.GetAge(passenger1.BirthDate, age);
passenger1.GetAge(passenger1);
Console.WriteLine(passenger1.age);

