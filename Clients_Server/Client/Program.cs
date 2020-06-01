using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPendp = new IPEndPoint(IPAddress.Parse("127.0.0.1"),12345);
            sock.Connect(IPendp);
            if (sock.Connected)
            {
                Console.WriteLine("Socket ist verbunden");
            }
            else
            {
                throw new Exception("Fehler beim Verbinden");

            }
            Console.WriteLine("Geben Sie die zu sendenden Daten ein");
            string To_Send = Console.ReadLine();
            byte[] BufferToSend = ASCIIEncoding.ASCII.GetBytes(To_Send);
            sock.Send(BufferToSend);
            Console.WriteLine("Daten wurden gesendet");
            sock.Close();
            Console.Read();
            
        }
    }
}
