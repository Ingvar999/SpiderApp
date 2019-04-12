using System;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace SpiderApp
{
    class Program
    {
        const int bufferSize = 100; 
        static byte[] buffer = new byte[bufferSize];

        static void Main(string[] args)
        {
            String host = "192.168.88.1";
            IPAddress ipAddr = new IPAddress(new byte[4] {192, 168, 88, 1});
            bool connected = false;
            while (true)
            {
                Console.WriteLine($"Wait for connect to {host} ...");
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 80);
                Socket client = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                while (!connected)
                {
                    try
                    {
                        client.Connect(ipEndPoint);
                        client.BeginReceive(buffer, 0, bufferSize, SocketFlags.None, ReceiveCallBack, client);
                        connected = true;
                    }
                    catch
                    {
                        Thread.Sleep(500);
                    }
                }
                Console.WriteLine("Connected");
                try
                {
                    while (true)
                    {
                        client.Send(Encoding.UTF8.GetBytes(Console.ReadLine() + "\n"));
                    }
                }
                catch
                {
                    connected = false;
                    Console.WriteLine("Disconnectd");
                }
            }
        }

        public static void ReceiveCallBack(IAsyncResult state)
        {
            Socket client = (Socket)state.AsyncState;
            try
            {
                int count = client.EndReceive(state);
                string msg = Encoding.UTF8.GetString(buffer, 0, count);
                Console.WriteLine(msg);
                client.BeginReceive(buffer, 0, bufferSize, SocketFlags.None, ReceiveCallBack, client);
            }
            catch
            {

            }
        }
    }
}
