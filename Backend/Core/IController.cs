using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Core
{
    public interface IController
    {
        T GetComponent<T>() where T : class;
        void Init();
    }
}
