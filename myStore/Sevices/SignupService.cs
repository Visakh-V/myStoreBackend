using myStore.Entities;
using myStore.Interfaces;
using myStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myStore.Sevices
{
    public class SignupService:ISignupService
    {
        private myStoreContext _myStoreContext;

        public SignupService(myStoreContext myStoreContext)
        {
            _myStoreContext = myStoreContext;
        }
        public int Signup(SignupModel user)
        {
            if(user == null)
            {
                return 0;
            }
            try
            {
                var newUser = new Registration()
                {
                    UserName = user.UserName,
                    Mobile = user.Mobile,
                    Password = user.Password
                };
                _myStoreContext.Registration.Add(newUser);
                _myStoreContext.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
            
        }
    }
}
