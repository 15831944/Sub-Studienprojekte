using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.ObjectModel;

namespace NetzwerkLib
{
    public class Server
    {
        Socket ListenSocket;


    readonly static ReadOnlyCollection<Commands> Kommands = new ReadOnlyCollection<Commands>(new List<Commands>() { Commands.SendMsg, Commands.SendPMsg, Commands.SetName, Commands.Disconnect });
     static readonly   List<Commands> kk = new List<Commands>() { Commands.SendMsg, Commands.SendPMsg, Commands.SetName, Commands.Disconnect };
        Dictionary<string, Socket> Connected_Sockets = new Dictionary<string, Socket>();
        

        Dictionary<Commands, List<Action<byte[]>>> RegisteredCommands = new Dictionary<Commands, List<Action<byte[]>>>(); // Zum Registrieren von beliebig viele Funktionen
        IPEndPoint localEndpoint;
        // public Server() : this(new IPEndPoint(IPAddress.Any,12345))
        /*Hier heißt einfach dass ohne Angabe eines Übergabeparameters eins automatisch zugefügt wird*/
        //Demzufolge wird er zu dem anderen Konstruktor springen
        
        
        public Server(IPEndPoint endPoint  )
        { 
            localEndpoint = endPoint;
            ListenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start(int MaxClients ,IPEndPoint EndPoint = null)
        {
            if (EndPoint!=null)
            {
                localEndpoint = EndPoint;
            }
            ListenSocket.Bind(localEndpoint);
            ListenSocket.Listen(MaxClients);

        }
        public void Stop()
        {
            Socket[] Sockets = Connected_Sockets.Values.ToArray();
            Connected_Sockets.Clear();
            foreach (Socket socket in Sockets)
            {
                socket.Close();
                socket.Dispose();
            }
            ListenSocket.Close();
            ListenSocket.Dispose();
            ListenSocket = null;
        }

        public void Send(string ClientName ,Paket paket)
        {
            if (Connected_Sockets.ContainsKey(ClientName))
            {
                paket.Send(Connected_Sockets[ClientName]);
            }
            else
            {
                throw new Exception("Client nicht vorhanden");
            }

        }
        public Paket Receive (string ClientName)
        {
            if (Connected_Sockets.ContainsKey(ClientName))
            {
                return Paket.Receive(Connected_Sockets[ClientName]);
            }
            else
            {
                throw new Exception("Client nicht vorhanden");
            }

        }

        public void ParsePaket(Paket paket)

        {
            
            kk.Add(Commands.Disconnect);
            //switch(paket.Command)
            //{
            //    case Commands.SendMsg:
            //        if(RegisteredCommands.ContainsKey(Commands.SendMsg))
            //        {
            //            int Count = RegisteredCommands[Commands.SendMsg].Count;
            //            if (Count > 0)
            //            {
            //                for (int i = 0; i < Count; i++)
            //                {
            //                    RegisteredCommands[Commands.SendMsg][i](paket.Getdata());
            //                }
            //            }
            //        }
                    
                    
                   
            //        break;


            //    case Commands.SendPMsg:


            //        if (RegisteredCommands.ContainsKey(Commands.SendMsg))
            //        {
            //            int Count = RegisteredCommands[Commands.SendMsg].Count;
            //            if (Count > 0)
            //            {
            //                for (int i = 0; i < Count; i++)
            //                {
            //                    RegisteredCommands[Commands.SendMsg][i](paket.Getdata());
            //                }
            //            }
            //        }


            //        break;

            //    case Commands.SetName:



            //        if (RegisteredCommands.ContainsKey(Commands.SendMsg))
            //        {
            //            int Count = RegisteredCommands[Commands.SendMsg].Count;
            //            if (Count > 0)
            //            {
            //                for (int i = 0; i < Count; i++)
            //                {
            //                    RegisteredCommands[Commands.SendMsg][i](paket.Getdata());
            //                }
            //            }
            //        }


            //        break;

            //    case Commands.Disconnect:

            //        if (RegisteredCommands.ContainsKey(Commands.SendMsg))
            //        {
            //            int Count = RegisteredCommands[Commands.SendMsg].Count;
            //            if (Count > 0)
            //            {
            //                for (int i = 0; i < Count; i++)
            //                {
            //                    RegisteredCommands[Commands.SendMsg][i](paket.Getdata());
            //                }
            //            }
            //        }


            //        break;
            //}
        }

        public void RegisterForCommand(Commands cmd, Action<byte[]>FuncPointer /* Action ist wie Event der zeigt auf Funktionen*/ /* byte[] weil wir die Daten übergeben möchten*/)
        {
            if (!RegisteredCommands.ContainsKey(cmd))
            {
                RegisteredCommands.Add(cmd, new List<Action<byte[]>>());
                RegisteredCommands[cmd].Add(FuncPointer);
            }
        }
        public void unregisteForCommand(Commands cmd, Action<byte[]> FunctPointer)
        {
            if (!RegisteredCommands.ContainsKey(cmd))
            {
                RegisteredCommands[cmd].Remove(FunctPointer);
            }
        }


    }
}
