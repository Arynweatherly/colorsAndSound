using System;
using System.Collections.Generic;

namespace ColorsAndSound
{
    class Program
    {
        static void Main(string[] args)
        {
            var zero = new Zero();
            var tesla = new Tesla();
            var cessna = new Cessna();
            var ram = new Ram();

            zero.MainColor = "White";
            tesla.MainColor = "red";
            cessna.MainColor = "black";
            ram.MainColor = "blue";

            tesla.MaximumOccupancy = 5;

            zero.Drive();
            tesla.Drive();
            cessna.Drive();
            ram.Drive();

            zero.Turn();
            tesla.Turn();
            cessna.Turn();
            ram.Turn();

            zero.Stop();
            tesla.Stop();
            cessna.Stop();
            ram.Stop();

        }
    }
}