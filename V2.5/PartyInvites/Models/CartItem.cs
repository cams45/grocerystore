using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class CartItem
    {
        public int ItemId { get; set; }

        //public string CartId { get; set; }

        // Class-level variable to hold cart items
        public static List<CartItem> cartItems = new List<CartItem>();

        public string ItemName { get; set; }
        public int Quantity { get; set; }

        public double Price { get; set; } // was int -- changed to double

        public System.DateTime DateCreated { get; set; }

        //public int ProductId { get; set; }
       
        public virtual Product Product { get; set; }


        //this can maybe use a random generator for cartNumber=receiptNumber?
        public int CartNum { get; set; }



        // Adds an items to the class level list of items
        public static void AddToCart(CartItem item)
        {
            cartItems.Add(item);
        }
        //Should clear all items in the cart

        public static void RemoveCart(CartItem item)
        {



            cartItems.Clear();
        }


        public static int orderNum()
        {
            System.Random random = new System.Random();
            return random.Next(0, 10000000);

        }

        internal static void AddToCart(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
