

using System;
using Microsoft.AspNetCore.Mvc;
using webapp2.Models;

public class WebController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
