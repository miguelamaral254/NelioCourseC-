
namespace Rent
{
   
    public class RentRoom
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}";
        }
    }
}