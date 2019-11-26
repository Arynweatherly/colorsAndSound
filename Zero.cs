using System;
using System.Collections.Generic;

public class Zero : Vehicle
{
    public double BatteryKwh { get; set; }

    public void ChargeBattery() { }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero zoomed past. Zoom!");
    }
    public virtual void Stop()
    {
        Console.WriteLine($"The {MainColor} stopped to show off to some ppl");
    }
}