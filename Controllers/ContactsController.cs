using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Practical_Test_Application.Data;
using Practical_Test_Application.Models;

namespace Practical_Test_Application.Controllers;

public class ContactsController : Controller
{
    private readonly ApplicationDbContext _context;

    public ContactsController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public IActionResult ShowContacts()
    {
        var contacts = _context.Contacts.ToList();
        
        if (contacts.IsNullOrEmpty())
        {
            return View ("EmptyPage");
        }
        
        return View(contacts);
    }

    [HttpGet]
    public IActionResult CreateContacts()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateContacts(Contacts contact)
    { 
        _context.Add(contact);
        await _context.SaveChangesAsync();
        return RedirectToAction("ShowContacts");
    }

    [HttpGet]
    public async Task<IActionResult> EditContacts(int contactId)
    {
        var contact = await _context.Contacts.FindAsync(contactId);
        return View(contact);
    }
    
    [HttpPost]
    public async Task<IActionResult> EditContacts (Contacts contacts)
    {
        
        
        String newClient = contacts.ClientCode;
        if (newClient != null)
        {
            int newNrOfClients = _context.Contacts.Where(c => c.ContactId == contacts.ContactId).Count();
            contacts.nrOfLinkedClients = newNrOfClients;
        }
        
        _context.Update(contacts);
        await _context.SaveChangesAsync();
        return RedirectToAction("ShowContacts");
    }
    
    public async Task<IActionResult> ContactForm(Contacts contacts)
    {
        ViewBag.ContactList = _context.Contacts.OrderBy(c => c.FirstName).ToList();
        
        if (ModelState.IsValid)
        {
            _context.Add(contacts);
            await _context.SaveChangesAsync();
        }
        
        return View(contacts);
    }
}