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
            int groupIdParam = Int32.Parse(arguments[0].ToString());
            string nameParam = (string)arguments[1];
            string locationParam = (string)arguments[2];
            string usernameParam = (string) arguments[3];
            string passwordParam = (string)arguments[4];  
            string noteParam = (string)arguments[5];

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
            int idParam = int.Parse(arguments[0].ToString());

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

            EditEntryRequest eeRequest = new EditEntryRequest
            {
                id = Int32.Parse(arguments[0].ToString()),
                name = (string)arguments[1],
                location = (string)arguments[2],
                username = (string)arguments[3],
                password = (string)arguments[4],
                note = (string)arguments[5],
                token = currentToken
            };
            return CallWsFunction(WsFunctions.EditEntry, eeRequest, WsMethod.Put);
        }
        public GeneralResponse DecryptPassword(object[] arguments)
        {

            string currentToken = LoginComponent.GetToken();
            int idParam = Int32.Parse(arguments[0].ToString());
            string masterPasswordParam = (string)arguments[1];

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
            //return gr.Data["original"].ToString();
            
            return gr;
        }
    }
}
