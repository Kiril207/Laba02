using System;
class Vehicle
{
    protected int price;
    protected int speed;
    protected int year;
    public Vehicle(int price, int speed, int year)
    {
        this.price = price;
        this.speed = speed;
        this.year = year;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Цена: {price}");
        Console.WriteLine($"Скорость: {speed}");
        Console.WriteLine($"Год: {year}");
    }

}
class Plane : Vehicle
{
    private int height;
    private int capacity;
    public Plane(int height, int capacity, int price, int speed, int year):base(price,speed,year)  
        {
        this.height = height;
        this.capacity = capacity;
        
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Высота: {height}");
        Console.WriteLine($"Вместимость: {capacity}");
        Console.WriteLine();
    }
}
class Car : Vehicle
{
    public Car(int price, int speed, int year) : base(price, speed, year)
    {
        {

        }
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine();
    }
}
class Ship : Vehicle
{
    private int capacity;
    private string port = "";
    public Ship(int capacity, string port, int price, int speed, int year) : base(price, speed, year)
    {
        this.capacity = capacity;
        this.port = port;
        this.capacity = capacity;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Вместимость: {capacity}");
        Console.WriteLine($"Порт приписки: {port}");
        Console.WriteLine();
    }

}

class Program
{
    static void Main()
    {
        Plane pln = new Plane(20, 250, 20000000, 950, 2025);
        Ship shp = new Ship(1500, "St. Petersburg", 50000000, 150, 2010);
        Car cr = new Car(1500, 190, 2019);
        pln.ShowInfo();
        shp.ShowInfo();
        cr.ShowInfo();
    }
    
}

