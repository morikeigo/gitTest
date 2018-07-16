using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using webapp2.Models;


public class HelloController : Controller
{
    //GET: /<controller>/
    public String Index()
    {
        ViewData["Message"] = "Let's study ASP.NET MVC";
        return "Hello MVC Return literal";
    }
}

