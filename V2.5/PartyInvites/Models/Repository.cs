
using System.Collections.Generic; 
namespace PartyInvites.Models
{ 
    public static class Repository
    {
       
        private static List<GuestResponse> responses = new List<GuestResponse>(); 
        public static IEnumerable<GuestResponse> Responses
        { 
            get
            { 
                return responses; 
            } 
        } 

        public static void AddResponse(GuestResponse response)
        {
             responses.Add(response); 
        }

        private static List<CartItem> cartInstance = new List<CartItem>();
        public static IEnumerable<CartItem> cartInstances
        {
            get
            { 
                return cartInstance;
            }
        }
        public static void AddCartInstance()
        {
            ;
        }

        private static List<Product> products = new List<Product>();

        
        

    } 
}

