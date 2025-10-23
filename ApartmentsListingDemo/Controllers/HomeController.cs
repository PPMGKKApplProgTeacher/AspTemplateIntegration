using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ApartmentsListingDemo.Models;
using ApartmentsListingDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApartmentsListingDemo.Data;
using ApartmentsListingDemo.Models;

namespace ApartmentsListingDemo.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    private readonly ILogger<HomeController> _logger;

    //public HomeController(ILogger<HomeController> logger)
    //{
    //    _logger = logger;
    //}

    public async Task<IActionResult> Index()
    {
        List<Category> cats = await _context.Category.ToListAsync();
        List<Listing> listings = await _context.Listing.ToListAsync();
        ViewBag.cats = cats;
        ViewBag.listings = listings;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
