using myStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myStore.Interfaces
{
   public interface ISignupService
    {
        int Signup(SignupModel user);
    }
}
