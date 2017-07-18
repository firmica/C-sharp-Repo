using Backend.GeneratedClasses;
using Backend.GeneratedClasses.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Components
{
    public interface ILoginComponent
    {
        //void Login(string username, string password, out int userId);
        GeneralResponse Login(object[] arguments);
        //string GetToken();
        
    }
}



