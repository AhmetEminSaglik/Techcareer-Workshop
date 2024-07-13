using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Entity_Homework.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "Must includes minimum 1 characters.")]
        [DisplayName("Name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Address")]
        [MinLength(10, ErrorMessage = "Must includes minimum 10 characters.")] 
        public string Address { get; set; }
        [Required]
        [DisplayName("City")]
        [MinLength(1, ErrorMessage = "Must includes minimum 1 characters.")]
        public string City { get; set; }
        [Required]
        [DisplayName("Region")]
        [MinLength(1, ErrorMessage = "Must includes minimum 1 characters.")]
        public string Region { get; set; }
        [Required]
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [DisplayName("Email")]
        [EmailAddress]
        public string Email { get; set; }
    }
}