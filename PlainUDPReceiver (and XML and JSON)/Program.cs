﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainUDPReceiver__and_XML_and_JSON_
{
    class Program
    {
        private const int Port = 11001;

        static void Main(string[] args)
        {
            UDPReceiver udpRecieverService = new UDPReceiver(Port);
            udpRecieverService.Start();

            Console.ReadLine();


        }
    }
}
