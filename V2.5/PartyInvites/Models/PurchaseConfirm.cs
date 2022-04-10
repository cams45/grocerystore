using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class PurchaseConfirm
    {
        //user info for billing
        [Required(ErrorMessage = "Please enter your full name")]
        public string FullName { get; set; }
        [EmailAddress(ErrorMessage = "Please enter a valid e-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a street address ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter a city ")]

        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a state")]

        public string State { get; set; }

        [Required(ErrorMessage = "Zip is Required")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        public string Zip { get; set; }

        //user info for card payment

        [Required(ErrorMessage = "Please enter your full name as shown in the card")]
        public string CardName { get; set; }
        [Required(ErrorMessage = "Please enter your card number")]

        public string CardNumber { get; set; }
        [Required(ErrorMessage = "Please enter the month your card expires")]

        public string ExpMonth { get; set; }
        [Required(ErrorMessage = "Please enter the year your card expires")]

        public string ExpYear { get; set; }
        [Required(ErrorMessage = "Please enter the CVV code on the back of your card")]

        public string Cvv { get; set; }
        public bool? Purchased { get; set; }

        public static List<PurchaseConfirm> purchaseConfirm = new List<PurchaseConfirm>();
        public static void AddToConfirmation(PurchaseConfirm item)
        {
            purchaseConfirm.Add(item);
        }
    }
}
