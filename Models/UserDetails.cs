using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class UserDetails
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide the username")]

        [Display(Name ="UserName")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please provide the password")]

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string   Password { get; set; }
    }
}
