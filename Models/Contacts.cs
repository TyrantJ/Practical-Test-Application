using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practical_Test_Application.Models;

public record Contacts
{
    public Contacts(string firstName, string lastName, string email, int nrOfLinkedClients, int contactId, string clientCode)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.nrOfLinkedClients = nrOfLinkedClients;
        this.contactId = contactId;
        this.clientCode = clientCode;
    }
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int contactId { get; set; }

    public string firstName { get; set; }
    
    public string lastName { get; set; }
    
    public string email { get; set; }
    
    public int nrOfLinkedClients { get; set; }
    
    public string clientCode { get; set; }
    
}