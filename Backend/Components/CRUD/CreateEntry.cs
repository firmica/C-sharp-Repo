using System.IO;
using System.Net;
using Newtonsoft.Json;
using Backend.GeneratedClasses;

namespace Backend.Components.CRUD
{
    class CreateEntry : BaseCRUD, ICreateEntry
    {
        public string CreateNewEntry(string url, int groupid, string name, string username, string password, string note)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                //bio je javascript serializer, moze i ovaj newtonsoft
                string json = JsonConvert.SerializeObject(new
                {
                    GroupId = groupid,
                    Name = name,
                    Username = username,
                    Password = password,
                    Note = note
                });

                streamWriter.Write(json);

            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result;
            }
            
        }
        public void CreateEntryFromObject() //ispitati koja od ove dve metode je prikladnija
        {
            EntryTest newEntry = new EntryTest
            {
                GroupId = 2,
                Name = "Mmail.com",
                Username = "john",
                Password = "223344",
                Note = "ovo je poruka"
            };
            newEntry.CreatedBy = newEntry.Username; //onaj koji se ulogovao
            
            string json = JsonConvert.SerializeObject(newEntry, Formatting.Indented);

            string url = @"http://passwordmanager.app/api/v1/Entry";

            string result = "";
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                result = client.UploadString(url, "POST", json);
            }
        }
    }
}
