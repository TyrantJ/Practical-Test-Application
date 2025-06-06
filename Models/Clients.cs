using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Practical_Test_Application.Models;

public record Clients {
    
    public Clients(string clientCode, String firstName, String lastName, int contact)
    {
        this.clientCode = clientCode;
        this.firstName = firstName;
        this.lastName = lastName;
        this.contact = contact;
        
    }
    
    [Key]
    public String clientCode { get; set; }
    public String firstName { get; set; }
    public String lastName { get; set; }
    public int contact { get; set; }

    
}