using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.GeneratedClasses;
using Backend.GeneratedClasses.Requests;

namespace Backend.Components.Entry
{
    class EntriesCrud : BaseComponent, IEntriesCrud
    {
        public GeneralResponse CreateEntry(object[] arguments)
        {
            int groupIdParam;
            bool result = Int32.TryParse (arguments[0].ToString(), out groupIdParam);
            if(!result)
            {
                throw new Exception("Cannot parse value for Group id parameter, it must be an integer");
            }

            string nameParam = arguments[1].ToString();
            string locationParam = arguments[2].ToString();
            string usernameParam = arguments[3].ToString();
            string passwordParam = arguments[4].ToString();  
            string noteParam = arguments[5].ToString();

            string currentToken = LoginComponent.GetToken();

            CreateEntryRequest ceRequest = new CreateEntryRequest()
            {
                groupId = groupIdParam,
                name = nameParam,
                location = locationParam,
                username = usernameParam,
                password = passwordParam,
                note = noteParam,
                token = currentToken
            };


            return CallWsFunction(WsFunctions.CreateEntry, ceRequest, WsMethod.Post);

        }

        public GeneralResponse ViewAllGroupsAndEntries(object[] arguments)
        {
            ViewEntriesRequest veRequest = new ViewEntriesRequest();  
            return CallWsFunction(WsFunctions.ViewAllGroupsAndEntries, veRequest, WsMethod.Get);
        }

        public GeneralResponse DeleteEntry(object[] arguments)
        {
            int idParam;
            bool result = int.TryParse(arguments[0].ToString(), out idParam);
            if (!result)
            {
                throw new Exception("Cannot parse value for Entry id parameter, it must be an integer");
            }
            string currentToken = LoginComponent.GetToken();

            DeleteEntryRequest deRequest = new DeleteEntryRequest
            {
                id = idParam,
                token = currentToken
            };

           return CallWsFunction(WsFunctions.DeleteEntry, deRequest, WsMethod.Delete);
        }

        public GeneralResponse EditEntry(object[] arguments)
        {
            
            string currentToken = LoginComponent.GetToken();
            int idParam;
            bool result = Int32.TryParse(arguments[0].ToString(), out idParam);
            if (!result)
            {
                throw new Exception("Cannot parse value for Entry id parameter, it must be an integer"); 
            }
            EditEntryRequest eeRequest = new EditEntryRequest
            {
                id = idParam,
                name = arguments[1].ToString(),
                location = arguments[2].ToString(),
                username = arguments[3].ToString(),
                password = arguments[4].ToString(),
                note = arguments[5].ToString(),
                token = currentToken
            };
            return CallWsFunction(WsFunctions.EditEntry, eeRequest, WsMethod.Put);
        }
        public GeneralResponse DecryptPassword(object[] arguments)
        {

            string currentToken = LoginComponent.GetToken();
            int idParam;
            bool result = Int32.TryParse(arguments[0].ToString(), out idParam);
            if (!result)
            {
                throw new Exception("Cannot parse value for id parameter, it must be an integer");
            }
            string masterPasswordParam = arguments[1].ToString();

            DecryptPasswordRequest DecryptPassReq = new DecryptPasswordRequest
            {
                id = idParam,
                masterPassword  = masterPasswordParam
            };
            GeneralResponse gr = new GeneralResponse();
            
            gr = CallWsFunction(WsFunctions.DecryptPassword, DecryptPassReq, WsMethod.Post);
            if (gr == null)
            {
                throw new Exception("Wrong master");
            }
           
            return gr;
        }
    }
}
