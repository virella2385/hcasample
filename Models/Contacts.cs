using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HcaProj.Models
{
    public class Contacts
    {
        public int ContactsId { get; set; }
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name="Last Name")]
        public string LastName { get; set; }
        [Display(Name="Email")]
        public string EmailAddress { get; set; }
        public DateTime Birthdate { get; set; }
        [Display(Name="# of Computers")]
        public int NumberOfComputers { get; set; }

        public List<Addresses> Addresses { get; set; }
    }
}