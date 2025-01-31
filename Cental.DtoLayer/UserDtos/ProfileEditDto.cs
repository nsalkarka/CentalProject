﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DtoLayer.UserDtos
{
    public class ProfileEditDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
       
        public string? InageUrl { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public IFormFile? ImageFile { get; set; }

        
        public string? CurrentPassword { get; set; }
       
    }
}
