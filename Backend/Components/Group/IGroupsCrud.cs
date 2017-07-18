using Backend.GeneratedClasses;
using Backend.GeneratedClasses.Responses;

namespace Backend.Components.Entry
{
    public interface IGroupsCrud
    {
        GeneralResponse CreateGroup(object[] arguments);
        GeneralResponse ViewAllGroups(object[] arguments);
        GeneralResponse DeleteGroup(object[] arguments); //this parameter should be an integer
        GeneralResponse EditGroup(object[] arguments); //add id parameter
        //void SubscribeToGetAllDataEvent(GroupsCrud.GetAllDataDelegate functionToSubscribe);

    }
}
