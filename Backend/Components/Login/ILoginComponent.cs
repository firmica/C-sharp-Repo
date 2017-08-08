using Backend.GeneratedClasses;
using System;

namespace Backend.Components
{
    public interface ILoginComponent
    {
        //void Login(string username, string password, out int userId);
        GeneralResponse Login(object[] arguments);
        //string GetToken();
        
    }
}



