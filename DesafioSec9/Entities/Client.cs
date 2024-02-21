using System.Text;

namespace DesafioSec9.Entities;
 class Client
{

    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; } 
    
    public Client()
    {
        
    }

    public Client(string name, string email, DateTime birthDate)
    {
        Name = name;
        Email = email;
        BirthDate = birthDate;
    }
    public string GetClientInformation()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append("Client: ")
               .Append(Name)
               .Append(" (").Append(BirthDate.ToString("dd/MM/yyyy")).Append(") ")
               .Append("- ").Append(Email);

        return builder.ToString();
    }
}
