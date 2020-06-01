using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using System.Net.Sockets;

namespace NetzwerkLib
{
   public  class Client
    {
        Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public void Reset()
        {
            sock.Close();
            sock.Dispose();
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        }

        public void Connect (IPEndPoint Endpoint)
        {
            sock.Connect(Endpoint);
        }
        public void Disconnect(bool reuse)
        {
            sock.Disconnect(reuse);
        }
    }
}
