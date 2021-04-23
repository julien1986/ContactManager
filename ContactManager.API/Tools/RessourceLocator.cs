using _00ConnectionTools.DataBase;
using ContactManager.Model.Global.Entities;
using ContactManager.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ContactManager.Model.Client.Entities;
using CS = ContactManager.Model.Client.Services;
using GS = ContactManager.Model.Global.Services;

namespace ContactManager.API.Tools
{
    public class RessourceLocator : LocatorBase
    {
        private static RessourceLocator _instance;
        public static RessourceLocator Instance 
        {
            get
            {
                return _instance ?? (_instance = new RessourceLocator());
            }
        }

        private RessourceLocator() { }
        /// <summary>
        /// Mets en relation les différents services entre eux
        /// </summary>
        /// <param name="services"></param>
        protected override void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(sp => new Connection(SqlClientFactory.Instance, @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContactManager;Integrated Security=True"));
            services.AddSingleton<IAuthRepository<G_User>, GS.AuthService>();
            services.AddSingleton < IAuthRepository<C_User>, CS.AuthService > ();
        }
       
        public IAuthRepository<C_User> AuthRepository
        {
            get
            {
                return Container.GetService<IAuthRepository<C_User>>();
            }
        }
    }
}