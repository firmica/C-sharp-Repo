using Backend.Components;
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
