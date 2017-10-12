using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainUDPSender
{
    class Program
    {
        private const int Port = 11001;

        static void Main(string[] args)
        {
            UDPSender udpSenderService = new UDPSender(Port);
            udpSenderService.Start();

            Console.ReadLine();
        }
    }
}
