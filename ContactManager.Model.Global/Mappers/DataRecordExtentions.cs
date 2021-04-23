using ContactManager.Model.Global.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model.Global.Mappers
{
    internal static class DataRecordExtentions
    {
        internal static G_User ToUtilisateur(this IDataRecord record)
        {
            return new G_User()
            {
                Id = (int)record["Id"],
                LastName = (string)record["LastName"],
                FirstName = (string)record["FirstName"],
                Email = (string)record["Email"],
                Genre = (char)record["Genre"],
                IsAdmin = (bool)record["IsAdmin"],
                IsValid = (bool)record["IsValid"],
                CreationDate = (DateTime)record["CreationDate"]
            };
        }
    }
}
