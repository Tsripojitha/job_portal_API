using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal
{
    public class emplogin
    {
        [Key] 
        public string username { get; set; }
        public string password { get; set; }
       
        public string phonenumber { get; set; }
        public string experience { get; set; }
        public string department { get; set; }

    }
}
