using System;
using System.Collections.Generic;
using System.Linq;

List<Vehicle> vehicles = new List<Vehicle>();

string command;
while ((command = Console.ReadLine()) != "End")
{
    string[] arguments = command.Split();

    if (arguments.Length != 4)
    {
        continue;
    }

    string type = arguments[0];
    string model = arguments[1];
    string color = arguments[2];

    if (!int.TryParse(arguments[3], out int horsepower))
    {
        continue;
    }

    string formattedType = char.ToUpper(type[0]) + type.Substring(1);

    vehicles.Add(new Vehicle(formattedType, model, color, horsepower));
}

string input;
while ((input = Console.ReadLine()) != "Close the Catalogue")
{
    Vehicle match = vehicles.FirstOrDefault(v => v.Model == input);
    if (match != null)
    {
        Console.WriteLine(match);
    }
}

PrintAverageHorsepower(vehicles, "Car");
PrintAverageHorsepower(vehicles, "Truck");

void PrintAverageHorsepower(List<Vehicle> allVehicles, string type)
{
    var filtered = allVehicles.Where(v => v.Type == type).ToList();
    double average = filtered.Any() ? filtered.Average(v => v.Horsepower) : 0;
    Console.WriteLine($"{type}s have average horsepower of: {average:F2}.");
}

public class Vehicle
{
    public Vehicle(string type, string model, string color, int horsepower)
    {
        Type = type;
        Model = model;
        Color = color;
        Horsepower = horsepower;
    }

    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Horsepower { get; set; }

    public override string ToString()
    {
        return $"Type: {Type}\nModel: {Model}\nColor: {Color}\nHorsepower: {Horsepower}";
    }
}
