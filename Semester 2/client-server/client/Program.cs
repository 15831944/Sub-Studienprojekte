using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

public interface MovieTicketInterface
{
    string GetTicketStatus(string stringToPrint);
}

namespace client
{
    class MyClient
    {
        public static void Main()
        {
            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel);

            Type requiredType = typeof(MovieTicketInterface);

            MovieTicketInterface remoteObject = (MovieTicketInterface) Activator.GetObject(requiredType,
            "tcp://localhost:8080/MovieTicketBooking");

            Console.WriteLine(remoteObject.GetTicketStatus("Ticket No: 3344"));
            Console.ReadLine();
        }
    }
}