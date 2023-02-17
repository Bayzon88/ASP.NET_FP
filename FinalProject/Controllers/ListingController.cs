<<<<<<< HEAD
﻿using FinalProject.Models;
=======
﻿using FinalProject.Models;
>>>>>>> 6c6fb595adf731cf9be58b6ce71879742a6f4e27
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class ListingController : Controller
    {
<<<<<<< HEAD
        // GET: /<controller>/
        public IActionResult Index()
        {
            // create dummy listing data
            Listing listing1 = new Listing();
            listing1.ListingId = 1;
            listing1.LandlordId = 1;
            listing1.HouseType = "Condo";
            listing1.TotalArea = 68.5;
            listing1.AddressId = 100;
            listing1.BedroomNo = 3;
            listing1.WahroomNo = 2;
            listing1.ParkingNo = 1;
            listing1.Description = "30 minutes driving from Humber College";
            listing1.RentalPrice = 700;


            Listing listing2 = new Listing();
            listing2.ListingId = 2;
            listing2.LandlordId = 2;
            listing2.HouseType = "House";
            listing2.TotalArea = 128.5;
            listing2.AddressId = 101;
            listing2.BedroomNo = 2;
            listing2.WahroomNo = 1;
            listing2.ParkingNo = 1;
            listing2.Description = "40 minutes driving from Humber College";
            listing2.RentalPrice = 800;

            List<Listing> listings = new List<Listing>() { listing1, listing2 };

            return View(listings);
        }

        // GET: /<controller>/
        public IActionResult Details(Listing listing)
        {
            return View(listing);
=======
        // GET: /<controller>/
        public IActionResult Index()
        {
            // create dummy listing data
            Listing listing1 = new Listing();
            listing1.ListingId = 1;
            listing1.LandlordId = 1;
            listing1.HouseType = "Condo";
            listing1.TotalArea = 68.5;
            listing1.AddressId = 100;
            listing1.BedroomNo = 3;
            listing1.WahroomNo = 2;
            listing1.ParkingNo = 1;
            listing1.Description = "30 minutes driving from Humber College";
            listing1.RentalPrice = 700;


            Listing listing2 = new Listing();
            listing2.ListingId = 2;
            listing2.LandlordId = 2;
            listing2.HouseType = "House";
            listing2.TotalArea = 128.5;
            listing2.AddressId = 101;
            listing2.BedroomNo = 2;
            listing2.WahroomNo = 1;
            listing2.ParkingNo = 1;
            listing2.Description = "40 minutes driving from Humber College";
            listing2.RentalPrice = 800;

            List<Listing> listings = new List<Listing>() { listing1, listing2 };

            return View(listings);
        }

        // GET: /<controller>/
        public IActionResult Details(Listing listing)
        {
            return View(listing);
>>>>>>> 6c6fb595adf731cf9be58b6ce71879742a6f4e27
        }
    }
}
