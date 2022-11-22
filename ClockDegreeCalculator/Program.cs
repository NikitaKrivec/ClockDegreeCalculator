// See https://aka.ms/new-console-template for more information


using ClockDegreeCalculator;

Console.Write("Please enter clock face hours: ");

int hours = int.Parse(Console.ReadLine());

Console.Write("Please enter clock face minutes: ");

int minutes = int.Parse(Console.ReadLine());

var angleCalculator = new AngleCalculator();

double degreeAngle = angleCalculator.GetAngleCalculator(hours, minutes);

Console.WriteLine($"There is {degreeAngle} angle between hours and minutes");

