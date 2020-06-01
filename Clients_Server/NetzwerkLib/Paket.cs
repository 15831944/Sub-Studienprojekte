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
    public class Paket
    {
        uint size;
        
        public uint Size { get { return  4 /* Die 4 byte vom Commando denn Uint32*/ + (uint)data.Length; } }
        uint Commando;
        public Commands Command
        {
            get { return (Commands)Commando; }
        }
        byte[] data;
        public  byte[] Data
        {
            get { return data; }
        }
        public byte[] Getdata()
        {
            return data;
        }

       

        public void setCommand (Commands cmd)
        {
            Commando = (uint)cmd;
        }

       

       

        public void setData(string ToSet)
        {
            data = ASCIIEncoding.ASCII.GetBytes(ToSet);
        }

           
        public void Send(Socket socket)
        {
            
            byte[] sizeArray = BitConverter.GetBytes(Size);
            byte[] commandArray = BitConverter.GetBytes(Commando);
            byte[] ToSend = new byte[sizeArray.Length + commandArray.Length + Data.Length];

            sizeArray.CopyTo(ToSend, 0);
            commandArray.CopyTo(ToSend, sizeArray.Length);
            Data.CopyTo(ToSend, sizeArray.Length + commandArray.Length);
            socket.Send(ToSend);

        }

        public static Paket Receive(Socket socket)
        {
            byte[] sizeBuffer = new byte[4];
            int recBytes = 0;

            while ((recBytes += socket.Receive(sizeBuffer,recBytes,sizeBuffer.Length-recBytes,SocketFlags.None)) != 4)
            {

            }
            Paket newPaket = new Paket();
          uint   newSize = BitConverter.ToUInt32(sizeBuffer, 0);
            byte[] buffer = new byte[newSize];
            recBytes = 0;

            while ((recBytes += socket.Receive(buffer, recBytes, buffer.Length - recBytes, SocketFlags.None))  < newSize)
            {

            }
            newPaket.Commando = BitConverter.ToUInt32(buffer, 0);
            byte[] tempbuffer = new byte[buffer.Length - 4];
            for (int i = 4; i < buffer.Length-4; i++)
            {
                tempbuffer[i - 4] = buffer[i];  
            }
            newPaket.data = tempbuffer;
            return newPaket;
        }
    }
}
