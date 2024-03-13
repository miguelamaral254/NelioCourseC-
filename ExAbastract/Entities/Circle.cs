using System;
using ExAbastract.Entities.Enums;

namespace ExAbastract.Entities;
internal class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius, Color color) : base(color)
    {
        Radius = radius;
    }

    public override double Area() => Math.PI * (Radius * Radius);
}
