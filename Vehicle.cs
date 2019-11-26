using System;
using System.Collections.Generic;

public class Vehicle
{
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }

    //create an instance of each vehicle 
    public virtual void Drive()
    {
        Console.WriteLine("VROOM");
    }

    public virtual void Turn()
    {
        Console.WriteLine("To the left");

    }
    public virtual void Stop()

    {
        Console.WriteLine("Stopping");
    }
}