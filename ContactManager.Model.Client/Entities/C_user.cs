using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model.Client.Entities
{
    public class C_user
    {
        public int Id { get; private set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public bool IsValid { get; set; }
        public char Genre { get; set; }
        public string Passwd { get; set; }

        public C_user(string lastname, string firstname, string email, bool isvalid, char genre, string passwd)
        {
            LastName = lastname;
            FirstName = firstname;
            Email = email;
            IsValid = isvalid;
            Genre = genre;
            Passwd = passwd;
                
        }
        internal C_user(int id, string lastname, string firstname, string email, bool isvalid, char genre)
            : this(lastname, firstname, email, isvalid, genre, null)
        {
            Id = id;
        }
    }
}
