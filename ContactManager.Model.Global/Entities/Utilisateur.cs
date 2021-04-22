using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model.Global.Entities
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public bool IsValid { get; set; }
        public bool IsAdmin { get; set; }
        public char Genre { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
