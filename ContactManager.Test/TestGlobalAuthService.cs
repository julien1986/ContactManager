using _00ConnectionTools.DataBase;
using ContactManager.Model.Global.Entities;
using ContactManager.Model.Global.Services;
using ContactManager.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace ContactManager.Test
{
    [TestClass]
    public class TestGlobalAuthService
    {
        private Connection _connection;

        [TestInitialize]
        public void TestInitialize()
        {
            _connection = new Connection(SqlClientFactory.Instance, @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContactManager;Integrated Security=True;");
        }
        [TestMethod]
        public void TestRegister()
        {
            IAuthRepository<G_User> authRepository = new AuthService(_connection);
            G_User user = new G_User()
            {
                LastName = "Jackson",
                FirstName = "Michael",
                Email = "Michael.Jackson@paradis.com",
                Passwd = "Test1234=",
                Genre = 'M'
            };

            bool result = authRepository.Register(user);

            Assert.IsTrue(result);
            Assert.IsNull(user.Passwd); //vérifie si le mot de passe qui revient de la DB a été mis sur null.
        }
    }
}
