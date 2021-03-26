using System;
using System.Net;
using System.Net.Sockets;

namespace kobo360app
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Get the local computer host name.
                String hostName = Dns.GetHostName();
                Console.WriteLine("I'm on :" + hostName);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException caught!!!");
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("Message : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught!!!");
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("Message : " + e.Message);
            }
        }
    }
}


