using ContactManager.Model.Global.Entities;
using ContactManager.Model.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model.Client.Mappers
{
    internal static class Mappers
    {   
        public static G_User ToGlobal(this C_user user)
        {
            return new G_User()
            {
                Id = user.Id,
                LastName = user.LastName,
                FirstName = user.FirstName,
                Email = user.Email,
                IsValid = user.IsValid,
                Genre = user.Genre,
                Passwd = user.Passwd
            };
        }
        public static C_user ToClient(this G_User user)
        {
            return new C_user(user.Id, user.LastName, user.FirstName, user.Email, user.IsValid, user.Genre);
        }
    }
}
