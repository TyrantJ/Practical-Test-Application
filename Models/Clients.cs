using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Practical_Test_Application.Models;

public record Clients {
    
    public Clients(string clientCode, String fullName, int contact, int ContactId, int NrOfContacts)
    {
        this.clientCode = clientCode;
        this.fullName = fullName;
        this.contact = contact;
        this.ContactId = ContactId;
        this.NrOfContacts = NrOfContacts;

    }
    
    [Key]
    public String clientCode { get; set; }
    public String fullName { get; set; }
    public int contact { get; set; }
    public int NrOfContacts { get; set; }
    public int ContactId { get; set; }

    
}