using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Components.CRUD
{
    public interface ICreateEntry
    {
        string CreateNewEntry(string url, int groupid, string name, string username, string password, string note);
        void CreateEntryFromObject(); 
    }
}
