using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.GeneratedClasses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Backend.Components
{
    public enum WsMethod
    {
        Post,
        Get,
        Delete,
        Put    
    }

    public enum WsFunctions
    {
        

        CreateGroup,
        ViewAllGroups,
        DeleteGroup,
        EditGroup,

        CreateEntry,
        ViewAllGroupsAndEntries,
        DeleteEntry,
        EditEntry,
        Login,
        DecryptPassword
    }

    public class BaseComponent
    {
        private string _url;

        internal void Init()
        {
            _url = "http://passwordmanager.app/api/v1/";
        }

        protected GeneralResponse CallWsFunction(WsFunctions functionName, object parameters, WsMethod wsMethod)
        {           
            string result = "";

            string functionNameString = Enum.GetName(typeof(WsFunctions), functionName);

            if (string.IsNullOrWhiteSpace(functionNameString))
                throw new Exception("Function name is empty.");

            string methodName = Enum.GetName(typeof(WsMethod), wsMethod);

            GeneralResponse gr = null;

            if (string.IsNullOrWhiteSpace(methodName))
                methodName = "GET";

           if (methodName.ToUpper() == "GET")
           {
                gr = new GeneralResponse();

                try
                {                   
                    using (var client = new WebClient())
                    {
                        //client.QueryString.Add("username", "admin");
                        //client.QueryString.Add("password", "12345");
                        client.Headers[HttpRequestHeader.ContentType] = "application/json";
                        result = client.DownloadString(_url + functionNameString);
                    }
                   
                    try
                    {
                        gr.Data = JObject.Parse(result);
                        gr.Success = true;
                        gr.ErrorMessage = "";
                    }
                    catch (Exception exception)
                    {
                        gr.Success = false;
                        gr.ErrorMessage = $"Error \"{exception}\" occured while converting response: {result}";
                    }                  
                }
                catch (Exception exception)
                {
                    gr.Success = false;
                    gr.ErrorMessage = exception.Message;
                    gr.Data = null;
                }

                return gr;
            }
           

           if (methodName.ToUpper() == "POST")
           {
               string parametersString = JsonConvert.SerializeObject(parameters);
               gr = new GeneralResponse();
               try
               {
                   using (var client = new WebClient())
                   {
                       client.Headers[HttpRequestHeader.ContentType] = "application/json";

                      result = client.UploadString(_url + functionName, methodName.ToUpper(), parametersString);
                   }
                   //gr = new GeneralResponse();

                   try
                   {
                       gr = JsonConvert.DeserializeObject<GeneralResponse>(result);
                   }
                   catch (Exception exception)
                   {
                       gr.Success = false;
                       gr.ErrorMessage = $"Error \"{exception}\" occured while converting response: {result}";
                   }
                   
               }
               catch (Exception exception)
               {
                   gr.Success = false;
                   gr.ErrorMessage = exception.Message;
               }
               return gr;
           }
           else if (methodName.ToUpper() == "DELETE")
           {
           gr = new GeneralResponse();
           string parametersString = JsonConvert.SerializeObject(parameters); 
               
               using (var client = new WebClient())
               {
                   client.Headers[HttpRequestHeader.ContentType] = "application/json";
                   result = client.UploadString(_url + functionName, methodName.ToUpper(), parametersString);
               

               }

               try
               {
                   gr = JsonConvert.DeserializeObject<GeneralResponse>(result);
               }
               catch (Exception exception)
               {
                   gr.Success = false;
                   gr.ErrorMessage = $"Error \"{exception}\" occured while converting response: {result}";
               }
               return gr;
           }
           else if (methodName.ToUpper() == "PUT")
           {
               gr = new GeneralResponse();
           string parametersString = JsonConvert.SerializeObject(parameters);
               using (var client = new WebClient())
               {
                   client.Headers[HttpRequestHeader.ContentType] = "application/json";
                   result = client.UploadString(_url + functionName, methodName.ToUpper(), parametersString);
               }
               try
               {
                   gr = JsonConvert.DeserializeObject<GeneralResponse>(result);
               }
               catch (Exception exception)
               {
                   gr.Success = false;
                   gr.ErrorMessage = $"Error \"{exception}\" occured while converting response: {result}";
               }
           return gr;
           }
           else
               {
                   return gr;
               }
           
           
            }
        

           

           
        
    }
}
