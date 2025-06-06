using System.ComponentModel.DataAnnotations;

namespace Practical_Test_Application.Models;

public class Contacts
{
    public Contacts(string firstName, string lastName, string email, int phone, int contactId)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.phone = phone;
        this.contactId = contactId;
    }
    
    [Key]
    public int contactId { get; set; }

    public string firstName { get; set; }
    
    public String lastName { get; set; }
    
    public string email { get; set; }
    
    public int phone { get; set; }
    
}