﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruiterLogin

{
    public class recruiterlogin
    {
        [Key] 
        public string companyname { get; set; }
        public string password { get; set; }
    }
}
