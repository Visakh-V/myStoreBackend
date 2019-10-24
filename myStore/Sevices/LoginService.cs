using myStore.Entities;
using myStore.Interfaces;
using myStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myStore.Sevices
{
    public class LoginService : ILoginService
    {
        private myStoreContext _myStoreContext;

        public LoginService(myStoreContext myStoreContext)
        {
            _myStoreContext = myStoreContext;
        }
        public UserModel Login(string username, string password)
        {
            try
            {
                var user = _myStoreContext.Registration.Where(x => x.UserName == username &&
                                                        x.Password == password).FirstOrDefault();
                if (user == null)
                    return null;
                return new UserModel()
                {
                    UserName = user.UserName,
                    Id = user.Id,
                    Mobile = user.Mobile
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
