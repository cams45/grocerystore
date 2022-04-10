using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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



        public string Index2()
        {
            return "hello world my name is cams";

        }

        public ViewResult Index()
        {

            int hour = DateTime.Now.Hour; ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View("Index");
        }


        //public ViewResult Login() { return View(); }


        public ViewResult AboutUs() { return View(); }
        public ViewResult FAQ() { return View(); }
        public ViewResult News() { return View(); }
        public ViewResult Catalog() { return View(); }
        //public ViewResult Cart() { return View(); }
        // public ViewResult OrderConfirm() { return View(); }
        //public ViewResult OrderRetrive() { return View(PurchaseConfirm.purchaseConfirm.Where(r => r.Purchased == true)); }
       
        
        
        public ViewResult OrderRetrive() {


            if (ModelState.IsValid)
                //if orderconfimation button is clicked, show order retrieve page
            {
                return View();
            }
                   
            else
            {

                return View("NoOrderMade");//empty no purchases made html file
            }
        


    }





        //public ViewResult OrderConfirmThanks() { return View(); }


        [HttpGet]
        public ViewResult Profile()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Profile(GuestResponse guestResponse)
        {
            Repository.AddResponse(guestResponse);
            return View("ProfileThanx", guestResponse);
        }


        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Login(GuestResponse guestResponse)
        {
            if (guestResponse is null)
            {
                throw new ArgumentNullException(nameof(guestResponse));
            }

            Debug.WriteLine("TEST");
            Debug.WriteLine(guestResponse.Email);
            Debug.WriteLine(guestResponse.Password);
            return View();
        }


        [HttpGet]
        public ViewResult Cart()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Cart(CartItem cartItem)
        {

            Debug.WriteLine("CART PAGE CALLED");
            Debug.WriteLine(cartItem.ItemName);
            Debug.WriteLine(cartItem.Quantity);
            Debug.WriteLine(cartItem.Price);

            // create a cart item from those variables
            //CartItem cartItem = new CartItem(name,quantity,price);

            // add the cart item to the cart list
            CartItem.AddToCart(cartItem);
            Debug.WriteLine(CartItem.cartItems.Count);

            

            // view the page
            return View();
        }



        [HttpGet]

        public  ViewResult EmptyCart(CartItem cartItem) {

            CartItem.RemoveCart(cartItem);

            return View();
        }



        [HttpGet]
        public ViewResult OrderConfirm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult OrderConfirm(PurchaseConfirm purchaseConfirm)
        {
            if (ModelState.IsValid)
            {
                PurchaseConfirm.AddToConfirmation(purchaseConfirm);
                return View();
            }
            else
            {
                return View();

            }
        }
        public ViewResult OrderConfirmThanks()
            {
                return View();
            }

        
    
    

    
    
    }
    
}

