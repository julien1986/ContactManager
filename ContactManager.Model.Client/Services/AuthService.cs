using ContactManager.Model.Global.Entities;
using ContactManager.Model.Client.Entities;
using ContactManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactManager.Model.Client.Mappers;

namespace ContactManager.Model.Client.Services
{
    public class AuthService : IAuthRepository<C_User>
    {
        public IAuthRepository<G_User> _globalAuthRepository;
        public AuthService(IAuthRepository<G_User> globalAuthRepository)
        {
            _globalAuthRepository = globalAuthRepository;
        }
        public C_User Login(string email, string passwd)
        {
            return _globalAuthRepository.Login(email, passwd)?.ToClient();
        }

        public bool Register(C_User user)
        {
            bool result = _globalAuthRepository.Register(user.ToGlobal());
            user.Passwd = null;
            return result;
            
        }
    }
}
