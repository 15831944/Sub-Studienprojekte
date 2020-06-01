using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


public interface MovieTicketInterface
{
    string GetTicketStatus(string stringToPrint);
}

namespace server
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TicketServer();
        }

        private static void TicketServer()
        {
            Console.WriteLine("Ticket Server started...");

            TcpChannel tcpChannel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(tcpChannel);

            Type commonInterfaceType = Type.GetType("server.MovieTicket");

            RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType,
                "MovieTicketBooking", WellKnownObjectMode.SingleCall);

            System.Console.WriteLine("Press ENTER to quit");
            System.Console.ReadLine();

        }

    }

   
    public class MovieTicket : MarshalByRefObject, MovieTicketInterface
    {
        public string GetTicketStatus(string stringToPrint)
        {
            string returnStatus = "Ticket Confirmed";
            Console.WriteLine("Enquiry for {0}", stringToPrint);
            Console.WriteLine("Sending back status: {0}", returnStatus);

            return returnStatus;
        }
    }
}