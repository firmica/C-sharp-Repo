using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Components.CRUD
{
    public class DeleteEntry : BaseCRUD, IDeleteEntry
    {
        public void DeleteEntryById(string url, int id)
        {
          
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/" + id);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";
            
            HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse();
        }
        
    }
}
