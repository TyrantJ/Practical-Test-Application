using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practical_Test_Application.Models;

public record Contacts
{
    public Contacts(string FirstName, string LastName, string Email, int nrOfLinkedClients, int ContactId, string ClientCode)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Email = Email;
        this.nrOfLinkedClients = nrOfLinkedClients;
        this.ContactId = ContactId;
        this.ClientCode = ClientCode;
    }
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ContactId { get; set; }

    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string Email { get; set; }
    
    public int nrOfLinkedClients { get; set; }
    
    public string? ClientCode { get; set; }
    
}