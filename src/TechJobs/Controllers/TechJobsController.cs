﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TechJobs.Controllers
{
    public class TechJobsController : Controller
    {

        internal static Dictionary<string, string> actionChoices = new Dictionary<string, string>();

        static TechJobsController()
        {
            actionChoices.Add("search", "Search");
            actionChoices.Add("list", "List");
        }

        public override ViewResult View()
        {
            ViewBag.actionChoices = actionChoices;
            return base.View();
        }

        // This does not seem to work in new version with 'Access violation'
        public override ViewResult View(string viewName)
        {
            ViewBag.actionChoices = actionChoices;
            return base.View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}