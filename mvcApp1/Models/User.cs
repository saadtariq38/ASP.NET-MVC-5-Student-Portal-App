﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcApp1.Models
{
    public class User
    {
       
        public int userId { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "User Name")]
        [StringLength(50)]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]

        [StringLength(50)]
        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
        
    }
}