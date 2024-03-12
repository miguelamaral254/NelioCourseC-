namespace ExRevSec10.Entities;
internal class Employees
{
    public string Name { get; set; }
    public int Hour { get; set; }
    public double ValuePerHour { get; set; }

    public Employees() { }
    public Employees(string name, int hour, double valuePerHour)
    {
        Name = name;
        Hour = hour;
        ValuePerHour = valuePerHour;
    }


    public virtual double Payment()
    {
         
        return ValuePerHour * Hour;
    }
}
