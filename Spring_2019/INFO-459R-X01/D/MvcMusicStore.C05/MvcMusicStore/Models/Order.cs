using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Order
    {
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }
        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        [Required]
        [Display(Name = "User Name")]
        [StringLength(100, MinimumLength = 1)]
        public string Username { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [StringLength(100, MinimumLength = 1)]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(100, MinimumLength = 1)]
        public string LastName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Address { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string City { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string State { get; set; }
        [Display(Name = "Postal Code")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        public string Country { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
    }
}