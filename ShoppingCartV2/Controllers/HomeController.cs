/*
 * Course: CS 3410
 * Section: W02
 * Name: Kevyn Lopez
 * Professor: Lingyan Wang
 * Assignment #: Module Assignment #8
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartV2.Models;

namespace ShoppingCartV2.Controllers
{
    public partial class HomeController : Controller
    {
        // Text for Site Heading
        string siteHeading = "CR7 Fan Club";

        // Text for Order View Heading
        string orderHeading = "The Home of Sports Fans!";

        // Text for View Heading for each Tab
        string[] tabHeadings = { "Home",  "Soccer", "NBA", "NFL",
                                         "Check-Out", "Admin", "About" };

        // View label displayed on each Tab
        string[] tabLabels = { "Home",  "Soccer", "NBA", "NFL",
                                       "Check-Out", "Admin", "About" };

        // View method name for each Tab
        string[] tabViews = { "Index",  "Soccer", "NBA", "NFL",
                                       "CheckOut", "Admin", "About" };

        // Text for View Heading of any Options columns
        string[] optionsColumnHeading = { "Customize", "Size", "Discounts" };

        // The tax rate is 5%
        decimal taxRate = 0.05M;

        // Action Method for Home page View
        public ActionResult Index()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "Welcome To " + siteHeading;
            ViewBag.Message2 = "<img src=\"/Images/Cr7FanClub.jpg\">";
            ViewBag.Message2 += "<br />This is the home of sports fans!";
            return View();
        }

        // Action Method for About page View
        public ActionResult About()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "About " + siteHeading;
            ViewBag.Message2 = "Hi! My name is Kevyn Lopez and I am the Webmaster of this site!";
            ViewBag.Message2 += "<br /><img src=\"/Images/webmaster.jpg\">";

            return View();
        }

        // Action Method for First Product View
        public ActionResult Soccer()
        {
            return GetTabView(1);
        }

        // Action Method to Process First Product View
        [HttpPost]
        public ActionResult Soccer(string button, FormCollection collection)
        {
            return ProcessTabView(1, button, collection);
        }
        public ActionResult NBA()
        {
            return GetTabView(2);
        }

        [HttpPost]
        public ActionResult NBA(string button, FormCollection collection)
        {
            return ProcessTabView(2, button, collection);
        }
        public ActionResult NFL()
        {
            return GetTabView(3);
        }

        [HttpPost]
        public ActionResult NFL(string button, FormCollection collection)
        {
            return ProcessTabView(3, button, collection);
        }

    }
}