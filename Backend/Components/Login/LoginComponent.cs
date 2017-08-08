using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.GeneratedClasses;
using Backend.GeneratedClasses.Requests;

namespace Backend.Components
{
    class LoginComponent : BaseComponent, ILoginComponent
    {
        private static string token;
      
        public GeneralResponse Login(object[] arguments)
        {   
            LoginRequest loginRequest = new LoginRequest()
            {
                username = (string)arguments[0],
                password = (string)arguments[1]
            };

            GeneralResponse gr = new GeneralResponse();
            gr = CallWsFunction(WsFunctions.Login, loginRequest, WsMethod.Post);
                try
                {
                    token = gr.Data["original"].ToString();
               
                }
                catch (Exception)
                {
                    gr.Success = false;
                    gr.ErrorMessage = "Login failed, please check username and password!";
              
                }
          
            return gr;   
        }

        public static string GetToken()
        {
            return token;
        }
    }
}
