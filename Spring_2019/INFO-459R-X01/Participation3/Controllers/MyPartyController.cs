using Participation3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Participation3.Controllers
{
    public class MyPartyController : Controller
    {
        // GET: MyParty
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyGift()
        {
            var partygiftlist = new List<Gift>
            {
                new Gift { Name = "Steam Gift Card", Price = 50.00M, StoreLocation = "Walmart" },
                new Gift { Name = "A New Car", Price = 30000.99M, StoreLocation = "Ken Garff" },
                new Gift { Name = "AKG K7XX", Price = 200.00M, StoreLocation = "Massdrop" }
            };
            return View(partygiftlist);
        }

        public ActionResult MyFriends()
        {
            var friends = new List<Friend>
                {
                  new Friend { FirstName = "Kodey", LastName = "Crandall", BirthDate = new DateTime(1984, 01, 09), Gender = "Male", PhoneNumber = "801-830-9575" },
                  new Friend { FirstName = "Sami", LastName = "Oscarson", BirthDate = new DateTime(1991, 02, 21), Gender = "Female", PhoneNumber = "801-555-1234" },
                  new Friend { FirstName = "Gemma", LastName = "Oscarson", BirthDate = new DateTime(2014, 08, 05), Gender = "Female", PhoneNumber = "801-345-6734" },
                  new Friend { FirstName = "Cece", LastName = "Oscarson", BirthDate = new DateTime(2018, 05, 10), Gender = "Female", PhoneNumber = "801-545-4534" }
                };
            return View(friends);
        }

        public ActionResult Details()
        {
            FriendGiftViewModel model = new FriendGiftViewModel();

            var gifts = new List<Gift>
                {
                new Gift { Name = "Steam Gift Card", Price = 50.00M, StoreLocation = "Walmart" },
                new Gift { Name = "A New Car", Price = 30000.99M, StoreLocation = "Ken Garff" },
                new Gift { Name = "AKG K7XX", Price = 200.00M, StoreLocation = "Massdrop" }
                };

            var friends = new List<Friend>
                {
                  new Friend { FirstName = "Kodey", LastName = "Crandall", BirthDate = new DateTime(1984, 01, 09), Gender = "Male", PhoneNumber = "801-830-9575" },
                  new Friend { FirstName = "Sami", LastName = "Oscarson", BirthDate = new DateTime(1991, 02, 21), Gender = "Female", PhoneNumber = "801-555-1234" },
                  new Friend { FirstName = "Gemma", LastName = "Oscarson", BirthDate = new DateTime(2014, 08, 05), Gender = "Female", PhoneNumber = "801-555-1234" }
                };
            model.Gifts = gifts;
            model.Friends = friends;
            return View(model);
        }
        public ActionResult PartyGifts()
        {
            return PartialView();
        }

        public ActionResult PartyFriends()
        {
            return PartialView();
        }

    }
}