using Backend.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Core.Loaders
{
    interface IComponentLoader
    {
        Dictionary<string, BaseComponent> LoadComponents();
    }
}
