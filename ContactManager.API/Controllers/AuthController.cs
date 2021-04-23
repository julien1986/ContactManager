using ContactManager.API.Models.Forms;
using ContactManager.API.Tools;
using ContactManager.Model.Client.Entities;
using ContactManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactManager.API.Controllers
{
    public class AuthController : ApiController
    {
        private readonly IAuthRepository<C_User> _authRepository;

        // L'injection de dépendences est disponible en .CORE mais pas en framework 4.8,
        // raison pour laquelle on passe par un ressource locator.
        // En .Net Core les controllers en règles générales sont inclus dans l'injection de dépendences
        // et peuvent recevoir les services en arguments du constructeurs.
        // Ces services doivent être définis dans la méthode 'configure services' du fichier 'startup.cs'
        public AuthController()
        {
            this._authRepository = RessourceLocator.Instance.AuthRepository;
        }


        //// GET: api/Auth
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Auth/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Auth
        public bool Post([FromBody] RegisterForm form)
        {
            C_User user = new C_User() 
            {
                LastName = form.LastName,
                FirstName = form.FirstName,
                Email = form.Email,
                Passwd = form.Passwd,
                Genre = form.Genre,
            };
            return _authRepository.Register(user);
           
        }

        //// PUT: api/Auth/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Auth/5
        //public void Delete(int id)
        //{
        //}
    }
}
