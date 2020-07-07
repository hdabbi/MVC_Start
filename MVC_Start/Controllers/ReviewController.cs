using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Start.Models;

namespace MVC_Start.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult Reviews()
        {
            Reviews Review = new Reviews();
            Review.ItemName = "Emotional Intelligence By Daniel Golemen";
            Review.Rating = "Excellent";
            Review.Reviewer = "Hemu";

            return View(Review);
        }
    }
}
