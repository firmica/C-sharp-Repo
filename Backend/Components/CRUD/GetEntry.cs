using Backend.GeneratedClasses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Backend.Components.CRUD
{
     public class GetEntry : BaseCRUD, IGetEntry
    {

        public T GetAllEntries<T>() where T : class
        {
            using (WebClient wc = new WebClient())
            {
               
                var json = wc.DownloadString(@"http://passwordmanager.app/api/v1/Entry");
                T entry = JsonConvert.DeserializeObject(json) as T;
                return entry;
            }
        }
        public string GetAllEntriesAsString()
        {
            using (WebClient wc = new WebClient())
            {

                var json = wc.DownloadString(@"http://passwordmanager.app/api/v1/Entry");
                return json.ToString();
            }
           
        }
        

        public string GetAllEntriesAsObject() //probaj ovde da napravis promenljivu koja ce da primi ovaj objekat ili bar neke njegove property
        {
            using (WebClient wc = new WebClient())
            {

                StringBuilder record = new StringBuilder();
                var json = wc.DownloadString(@"http://passwordmanager.app/api/v1/Entry");
                var allEntries  = JsonConvert.DeserializeObject <List<EntryTest>>(json);
                foreach(EntryTest entry in allEntries)
                {
                    record.Append(entry.Name + Environment.NewLine);
                }
                string message = record.ToString();
                return message;
            }
        }
           
    }
}
