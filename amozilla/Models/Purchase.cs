using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace amozilla.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }
        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter an address")]
        public string AddressLine1 { get; set; }
        
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter state")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter zip code")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter country")]
        public string Country { get; set; }

        
        public bool Anonymous { get; set; }
        




    }
}
