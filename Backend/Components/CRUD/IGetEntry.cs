
using Backend.GeneratedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Components.CRUD
{
    public interface IGetEntry
    {
        T GetAllEntries<T>() where T : class;
        string GetAllEntriesAsString();
        string GetAllEntriesAsObject();
    }
}
