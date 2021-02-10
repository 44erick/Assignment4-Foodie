using System;
using System.Collections.Generic;
//so we can see the validation errors
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Foodie.Models
{
    public class modelResponse
    {   
        //required
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please enter restaurant name")]
        public string Restaurant { get; set; }


        [Required(ErrorMessage = "Please enter favorite dish")]
        public string Favorite { get; set; }


        [Required(ErrorMessage = "Please enter restaurant phone #")]
        [Phone]
        public string Phone { get; set; }


        //public string Lent { get; set; }
        //[MaxLength (25, ErrorMessage ="No more than 25 characters allowed")]

    }
}
