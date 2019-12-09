﻿using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.api.Dtos
{
    public class UserForRegisterDto
    {

        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength =4,ErrorMessage ="You must specify password between 4 to 8 characters")]
        public string Password { get; set; }
    }
}