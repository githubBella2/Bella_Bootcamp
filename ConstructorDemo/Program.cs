// See https://aka.ms/new-console-template for more information
using Automotive;
using Vehicle;
using Kitchen;

class Program
{
    static void Main(string[] args)
    {
        Speed speed = new Speed(25.5f);
        Wheel wheel = new Wheel("Offroad",2023,"Dunlop");
        Engine engine= new Engine ("Supra",1200,"Toyota");
        Cake cake= new Cake("RoseBrand");
        char car= new Car("Black","Toyota",2,engine,wheel,speed);
        wheel.PrintAttribute();
        car.PrintAttribute(car.color, car.brand,car.numDoor);
    }
}
