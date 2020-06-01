using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace NetzwerkLib
{
    public enum Commands : uint
    {
        SendMsg = 1,
        SendPMsg,
        GetName,
        SetName,
        Disconnect,
    }
}
