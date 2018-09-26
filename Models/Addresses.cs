using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace HcaProj.Models
{
    public class Addresses
    {
        [HiddenInput(DisplayValue = false)]
        public int AddressesId { get; set; }
        [Display(Name="Address Line 1")]
        public string AddressLine1 { get; set; }
        [Display(Name="Address Line 2")]
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        [Display(Name="State Code")]
        public string StateCode { get; set; }
        [Display(Name="Zip Code")]
        public string Zip { get; set; }

[HiddenInput(DisplayValue = false)]
        public int ContactId { get; set; }
        public Contacts Contact { get; set; }
        
    }
}