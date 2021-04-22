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
    public class AuthService : IAuthRepository<Utilisateur>
    {
        private IConnection _connexion;

        public AuthService(IConnection connexion)
        {
            _connexion = connexion;
        }
        public Utilisateur Login(string email, string passwd)
        {
            Commands cmd = new Commands("TSP_AuthUser", true);
            cmd.AddParameter("@Email", email);
            cmd.AddParameter("@Passwd", passwd);

            return _connexion.ExecuteReader(cmd, dr => dr.ToUtilisateur()).SingleOrDefault();
        }

        public bool Register(Utilisateur utilisateur)
        {
            Commands cmd = NotFiniteNumberException command("TSP_register", true);
            cmd.AddParameter()
        }
    }
}
