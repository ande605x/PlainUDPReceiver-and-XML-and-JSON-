using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PlainUDPReceiver__and_XML_and_JSON_
{
    public class UDPReceiver
    {
        private int Port;

        public UDPReceiver(int port)
        {
            Port = port;
        }

        public void Start()
        {
            using (UdpClient client = new UdpClient(Port))
            {
                IPEndPoint senderEP = new IPEndPoint(IPAddress.Any, Port);

                byte[] buffer = client.Receive(ref senderEP);
                string incommingstr = Encoding.ASCII.GetString(buffer);

                Console.WriteLine("UDP length: "+buffer.Length);
                Console.WriteLine("Afsender er: "+senderEP.Address+" port "+senderEP.Port);
                Console.WriteLine(incommingstr);

            }
            
        }
    }
}
