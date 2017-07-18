using Backend.Components;
using Backend.Components.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Components.Entry;

namespace Backend.Core.Loaders
{
    class ComponentLoader : IComponentLoader
    {
        public Dictionary<string, BaseComponent> LoadComponents()
        {
            Dictionary<string, BaseComponent> components = new Dictionary<string, BaseComponent>();

            CreateEntry CreateEntryComponent = new CreateEntry();
            CreateEntryComponent.Init();
            components.Add(typeof(CreateEntry).Name, CreateEntryComponent);

            GetEntry GetEntryComponent = new GetEntry();
            GetEntryComponent.Init();
            components.Add(typeof(GetEntry).Name, GetEntryComponent);

            DeleteEntry DeleteEntryComponent = new DeleteEntry();
            DeleteEntryComponent.Init();
            components.Add(typeof(DeleteEntry).Name, DeleteEntryComponent);

            GroupsCrud groupsCroudComponent = new GroupsCrud();
            groupsCroudComponent.Init();
            components.Add(typeof(GroupsCrud).Name, groupsCroudComponent);

            EntriesCrud entriesCrudComponet = new EntriesCrud();
            entriesCrudComponet.Init();
            components.Add(typeof(EntriesCrud).Name, entriesCrudComponet);

            LoginComponent loginComponent = new LoginComponent();
            loginComponent.Init();
            components.Add(typeof(LoginComponent).Name, loginComponent);

            

            return components;
        }
    }
}
