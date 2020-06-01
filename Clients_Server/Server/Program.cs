using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // Socket ist wie ein Endpunkt  jedoch können mit der Socket Klasse Daten senden und empfangen werden
            //ZB  IPEndPoint endp = new IPEndPoint(IPAddress.Any, 1212);
            // IP = 127.0.0.1 für den lokalen Computer
            IPEndPoint IPendp = new IPEndPoint(IPAddress.Parse("127.0.0.1") /*Konvertiert den String in IPAdress*/, 12345);

            sock.Bind(IPendp); //  Socket wird an dem erzeugte Endpunkt gebunden
                               // Nun wartet der Socket auf alle Verbindungen die reinkommen , egal von wem sie gesendet werden
            Console.WriteLine("Server ist an Endpunkt gebunden");
 
            sock.Listen(2); /* maximale Anzahl der Klienten, die sich verbinden können*/
            Console.WriteLine("Server wartet auf Klienten");

            Socket Client_Socket = sock.Accept(); // Die eingenommenen Verbindungen werden angenommen
            Console.WriteLine("Klient verbunden");

            byte[] buffer = new byte[10000]; // Zum Empfangen von gesendeten Daten
            int recBytes = Client_Socket.Receive(buffer);
            Console.WriteLine("Es wurden {0} Bytes empfangen", recBytes);
            // Auslesen von empfangenen Daten
            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer, 0, recBytes)/*Dekodierung von gesendeten Daten*/);
            Client_Socket.Close();
            Console.Read();

        }
    }
}
