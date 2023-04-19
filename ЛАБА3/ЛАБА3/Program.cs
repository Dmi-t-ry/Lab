using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

public class Auto
{
    public string carModel, color;
    public int weight;
}

public class PassengerCar:Auto
{
    public int maxSpeed,numberOfSeats;
    public PassengerCar(string carModel, string color, int weight, int maxSpeed, int numberOfSeats)
    {
        this.carModel = carModel;
        this.color = color;
        this.weight = weight;
        this.maxSpeed = maxSpeed;
        this.numberOfSeats = numberOfSeats;
    }
}
public class Truck:Auto
{
    public int loadCapacity;
    public Truck(string carModel, string color, int weight, int loadCapacity)
    {
        this.carModel = carModel;
        this.color = color;
        this.weight = weight;
        this.loadCapacity = loadCapacity;
    }
}

public static class Program
{

    public static void PassengerCarDataChange()
    {
        Console.WriteLine("Enter car model, color, weight, max speed and number of seats:");
        string carModel = Console.ReadLine();
        string color = Console.ReadLine();
        int weight = int.Parse(Console.ReadLine());
        int maxSpeed = int.Parse(Console.ReadLine());
        int numberOfSeats = int.Parse(Console.ReadLine());
        var newCar = new PassengerCar(carModel, color, weight, maxSpeed, numberOfSeats);
        Console.WriteLine("Data changed to:");
        OutputCarData(newCar);
    }
    public static void TruckDataChange()
    {
        Console.WriteLine("Enter car model, color, weight, load capacity:");
        string carModel = Console.ReadLine();
        string color = Console.ReadLine();
        int weight = int.Parse(Console.ReadLine());
        int loadCapacity = int.Parse(Console.ReadLine());
        var newTruck = new Truck(carModel, color, weight, loadCapacity);
        Console.WriteLine("Data changed to:");
        OutputTruckData(newTruck);
    }
    public static void ChangeDataRequestProcessing(string type)
    {
        if (type == "passenger")
            PassengerCarDataChange();
        else if (type == "truck")
            TruckDataChange();
        else
        { 
            Console.WriteLine("invalid answer, try again");
            ChangeDataRequest();
        }

    }
    public static void ChangeDataRequest()
    {
        Console.WriteLine("Do you want to change data?(true/false)");
        bool answer=false;
        answer=bool.Parse(Console.ReadLine());
        string userChoice="";
        if(answer)
        {
            Console.WriteLine("Which car data do you want to change?(passenger/truck)");
            userChoice=Console.ReadLine();
            ChangeDataRequestProcessing(userChoice);
        }
    }
    public static void OutputCarData(PassengerCar passengerCar)
    {
        Console.WriteLine($"{passengerCar.color} car {passengerCar.carModel} \nweight = {passengerCar.weight}kg \nmax speed = {passengerCar.maxSpeed}km/h \nnumber of seats = {passengerCar.numberOfSeats} \n\n ");
    }
    public static void OutputTruckData(Truck truck)
    {
        Console.WriteLine($"{truck.color} truck {truck.carModel} \nweight = {truck.weight}kg \nload capacity = {truck.loadCapacity}kg \n");
    }
    public static void Main()
    {
        PassengerCar passengerCar = new PassengerCar("BMW", "red", 2000, 250, 4);
        Truck truck = new Truck("Renault", "orange", 4500, 5000);
        OutputCarData(passengerCar);
        OutputTruckData(truck);
         ChangeDataRequest();
    }
}