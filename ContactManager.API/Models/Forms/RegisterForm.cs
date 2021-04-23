using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.API.Models.Forms
{
    public class RegisterForm
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Passwd { get; set; }
        public char Genre { get; set; }
    }
}