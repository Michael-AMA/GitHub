﻿using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Message
        // Send down the form to the user
        [HttpGet()]
        public ActionResult Message()
        {
            // Need to specify the name of the view, because it's not Message
            return View("CreateMessage");
        }

        // POST: Home/Message
        // Accept the data from the user
        // Data binding will automatically take the form data and create the object
        [HttpPost()]
        public ActionResult Message(Message message)
        {
            return View(message);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}