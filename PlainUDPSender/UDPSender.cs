using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ModelLib;

namespace PlainUDPSender
{
    public class UDPSender
    {
        private readonly int Port;

        public UDPSender(int port)
        {
            Port = port;
        }

        public void Start()
        {
            Car car = new Car("Tesla","Red","EL23400");

            using (UdpClient client = new UdpClient())
            {
                IPEndPoint ReceiverEP = new IPEndPoint(IPAddress.Loopback, Port);
                byte[] buffer = Encoding.ASCII.GetBytes(car.ToString());
                client.Send(buffer, buffer.Length, ReceiverEP);
            }
            
        }
    }
}
