using Backend.Components;
using Backend.Core.Loaders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Core
{
    public class Controller : IController
    {
        private readonly IComponentLoader _componentLoader;
        private Dictionary<string, BaseComponent> _ComponentContainer = new Dictionary<string, BaseComponent>();

        public Controller()
        {
            _componentLoader = new ComponentLoader();
        }
        public void Init()
        {
            _ComponentContainer = _componentLoader.LoadComponents();
        }
        public T GetComponent<T>() where T : class
        {
            string componentName = typeof(T).Name;

            if (componentName.StartsWith("I"))
                componentName = componentName.Remove(0, 1);

            if (!_ComponentContainer.ContainsKey(componentName))
                throw new Exception($"Component {componentName} does not exists.");

            T componentInstance = _ComponentContainer[componentName] as T;

            if (componentInstance == null)
                throw new Exception("Component is of the wrong type.");


            return componentInstance;
        }
    }
}
