using Microsoft.AspNetCore.Mvc;
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
        return View(contacts);
    }
    
    public IActionResult CreateContacts()
    {
        return View();
    }
}