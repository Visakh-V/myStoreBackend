using myStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myStore.Interfaces
{
    public interface ILoginService
    {
       UserModel Login(string username, string password);
    }
}
