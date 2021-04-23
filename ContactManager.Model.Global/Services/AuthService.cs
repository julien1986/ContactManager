using _00ConnectionTools.DataBase;
using ContactManager.Model.Global.Entities;
using ContactManager.Model.Global.Mappers;
using ContactManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model.Global.Services
{
    public class AuthService : IAuthRepository<G_User>
    {
        private IConnection _connexion;

        public AuthService(IConnection connexion)
        {
            _connexion = connexion;
        }
        public G_User Login(string email, string passwd)
        {
            Commands cmd = new Commands("TSP_AuthUser", true);
            cmd.AddParameter("@Email", email);
            cmd.AddParameter("@Passwd", passwd);

            return _connexion.ExecuteReader(cmd, dr => dr.ToUtilisateur()).SingleOrDefault();
        }

        public bool Register(G_User user)
        {
            Commands cmd = new Commands("TSP_register", true);
            cmd.AddParameter("@LastName", user.LastName);
            cmd.AddParameter("@FirstName", user.FirstName);
            cmd.AddParameter("@Email", user.Email);
            cmd.AddParameter("@Passwd", user.Passwd);
            cmd.AddParameter("@Genre", user.Genre);

            int rows = _connexion.ExecuteNonQuery(cmd);
            user.Passwd = null;
            return rows == 1;

        }
    }
}
