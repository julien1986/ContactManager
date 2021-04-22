using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Repository
{
    public interface IAuthRepository<TUtilisateur>
    {
        bool Register(TUtilisateur utilisateur);
        TUtilisateur Login(string email, string passwd);
    }
}
