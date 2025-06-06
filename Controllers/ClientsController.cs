using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NuGet.Protocol;
using Practical_Test_Application.Data;
using Practical_Test_Application.Models;

namespace Practical_Test_Application.Controllers;

public class ClientsController : Controller
{
    
    private readonly ApplicationDbContext _context;

    public ClientsController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult ShowClients()
    {
        var clients = _context.Clients.OrderBy(c => c.fullName).ToList();

        if (clients.IsNullOrEmpty())
        {
            return View ("EmptyPage");
        }
        return View(clients);
    }

    public async Task<IActionResult> ClientForm(Clients client)
    {
        ViewBag.ClientsList = _context.Clients.OrderBy(c => c.fullName).ToList();
        
        
        if (ModelState.IsValid)
        {
            _context.Add(client);
            await _context.SaveChangesAsync();
        }
        
        return View(client);
    }
    
    public async Task<IActionResult> EditClients (Clients client)
    {
        
        ViewBag.ClientsList = _context.Clients.OrderBy(c => c.fullName).ToList();
        if (ModelState.IsValid)
        {
            _context.Update(client);
            await _context.SaveChangesAsync();
        }
        
        return View(client);
    }
    
    

    public async Task<IActionResult> CreateClients(Clients client)
    {
        if (ModelState.IsValid)
        {
            _context.Add(client);
            await _context.SaveChangesAsync();
        }

        return View();
    }
    
}