using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.GeneratedClasses;

namespace Backend.Components.Entry
{
    public interface IEntriesCrud
    {
        GeneralResponse CreateEntry(object[] arguments);
        GeneralResponse ViewAllGroupsAndEntries(object[] arguments);
        GeneralResponse DeleteEntry(object[] arguments); 
        GeneralResponse EditEntry(object[] arguments);
        GeneralResponse DecryptPassword(object[] arguments);
    }
}
