using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.GeneratedClasses;
using Backend.GeneratedClasses.Requests;

namespace Backend.Components.Entry
{
    public class GroupsCrud : BaseComponent, IGroupsCrud
    {
        
        
        public GeneralResponse CreateGroup(object[] arguments)
        {
            string groupName = arguments[0].ToString();
            string currentToken = LoginComponent.GetToken();
            CreateGroupRequest cgr = new CreateGroupRequest()
            {
                name = groupName,
                token = currentToken
            };
            GeneralResponse gr = new GeneralResponse();
            gr = CallWsFunction(WsFunctions.CreateGroup, cgr, WsMethod.Post);
            //int id = int.Parse(gr.Data["original"].ToString());

            return gr;
        }
        //public GeneralResponse ViewAllGroups(object[] arguments)
        //{
        //    ViewGroupResponse vgResponse = new ViewGroupResponse();     

        //    return CallWsFunction(WsFunctions.ViewAllGroups, vgResponse, WsMethod.Get);;
        //}

        public GeneralResponse DeleteGroup(object[] arguments)
        {
            int idParam = Int32.Parse(arguments[0].ToString());

            string currentToken = LoginComponent.GetToken();

            DeleteGroupRequest dgRequest = new DeleteGroupRequest()
            {
                id = idParam,
                token = currentToken
            };
            return CallWsFunction(WsFunctions.DeleteGroup, dgRequest, WsMethod.Delete);
        }

        public GeneralResponse EditGroup(object[] arguments)
        {
            int idParam = Int32.Parse(arguments[0].ToString());
            string nameParam = arguments[1].ToString();
            string currentToken = LoginComponent.GetToken();

            EditGroupRequest egRequest = new EditGroupRequest()
            {
                
                id = idParam, 
                name = nameParam,
                token = currentToken
            };

            return CallWsFunction(WsFunctions.EditGroup, egRequest, WsMethod.Put);
        }
        
    }
}
