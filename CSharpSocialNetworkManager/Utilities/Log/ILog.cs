using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSocialNetworkManager.Utilities.Log
{
    public interface ILog<T>
    {
        void SaveLog(T action);
    }
}
