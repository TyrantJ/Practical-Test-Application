using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Practical_Test_Application.Models;

public record Clients {
    
    public Clients(string clientCode, string fullName, string contact, int ContactId, int NrOfContacts)
    {
        this.clientCode = clientCode;
        this.fullName = fullName;
        this.contact = contact;
        this.ContactId = ContactId;
        this.NrOfContacts = NrOfContacts;

    }
    
    [Key]
    public string clientCode { get; set; }
    public string fullName { get; set; }
    public string? contact { get; set; }
    public int NrOfContacts { get; set; }
    public int ContactId { get; set; }

    
}