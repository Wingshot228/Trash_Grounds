﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrashGrounds.Services.Middlewares;

namespace TrashGrounds.Controllers;

public class MainController : Controller
{
    private readonly ILogger<MainController> _logger;

    public MainController(ILogger<MainController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("~/Views/Pages/Main.cshtml", this.GetUser());
    }
}
