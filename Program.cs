using System;

namespace LiskovSubstitution
{
    public class Vehicle
    {
        public int speed { get; set; }
        public readonly int maxSpeed;
        public Vehicle(int speed, int maxSpeed) 
        {
            if (speed < 0 || maxSpeed < 0)
            {
                throw new ArgumentException("Speed and maxSpeed cannot be negative.");
            }
            this.speed = speed; 
            this.maxSpeed= maxSpeed; 
        }

        public virtual int Acceleration()
        {
            return speed;
        }
    }
    public class Car : Vehicle
    {
        public Car(int speed)  : base(speed, 100)
        {
        }
        public override int Acceleration()
        {
            speed += 10;
            if (speed < maxSpeed)
            {
                Console.WriteLine("Take it easy, you haven’t even turned on the turbo yet!");
            }
            else if (speed >= maxSpeed)
            {
                speed = maxSpeed;
                Console.WriteLine("You've reached the maximum speed! Slow down or take a break.");
            }
            return speed;
        }
    }
    public class Truck : Vehicle
        {
        public Truck(int speed) : base(speed,80)
        {
        }

        public override int Acceleration()
            {
            speed += 5;
            if (speed < maxSpeed)
            {
                Console.WriteLine("Come on, speed up a little!");
            }
            else if (speed >= maxSpeed)
            {
                speed = maxSpeed;
                Console.WriteLine("You've reached the maximum speed! Slow down or take a break.");
            }
            return speed;
        }
        }
    public class Program
    {
        static void Main(string[] args)
        {
            Car car =new Car(50);

            Console.WriteLine($"My Car before speeding: {car.speed}");
            Console.WriteLine($"My Car after speeding: {car.Acceleration()}");

            Console.WriteLine();

            Truck truck = new Truck(40);
            Console.WriteLine($"My Truck before speeding: {truck.speed}");
            Console.WriteLine($"My Truck after speeding: {truck.Acceleration()}");
        }
    }
}