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
    
    public async Task<IActionResult> CreateContacts(Contacts contact)
    {
        
        if (ModelState.IsValid)
        {
            _context.Add(contact);
            await _context.SaveChangesAsync();
        }
        return View();
    }
    
    public async Task<IActionResult> EditContacts (Contacts contacts)
    {
        
        ViewBag.ContactList = _context.Contacts.OrderBy(c => c.firstName).ToList();
        if (ModelState.IsValid)
        {
            _context.Update(contacts);
            await _context.SaveChangesAsync();
        }
        
        return View(contacts);
    }
    
    public async Task<IActionResult> ContactForm(Clients client)
    {
        ViewBag.ContactList = _context.Contacts.OrderBy(c => c.firstName).ToList();
        
        
        if (ModelState.IsValid)
        {
            _context.Add(client);
            await _context.SaveChangesAsync();
        }
        
        return View(client);
    }
}