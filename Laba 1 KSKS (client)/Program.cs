using System;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Text;

class Client
{
    static void Main(string[] args)
    {
        UdpClient udpClient = new UdpClient();
        string serverIP = "127.0.0.1";
        int serverPort = 12345;

        IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Any, 0);

        Console.WriteLine("Введите комманду: ");

        string command = Console.ReadLine();

        byte[] data = Encoding.ASCII.GetBytes(command);
        udpClient.Send(data, data.Length, serverIP, serverPort);

        Console.WriteLine("Полученный ответ: ");

        byte[] respondBytes = udpClient.Receive(ref serverEndPoint);
        string receivedCommand = Encoding.ASCII.GetString(respondBytes);

        Console.WriteLine(receivedCommand);

        int kolvo = Convert.ToInt32(receivedCommand);

        string[] strings = new string[kolvo];

        for (int i = 0; i < kolvo; i++) 
        {
            Console.WriteLine("Введите параметр: ");
            strings[i] = Console.ReadLine();
        }

        Console.WriteLine("Введенные параметры: ");
        var str = string.Join(" ", strings);
        Console.WriteLine(str);

        for (int i = 0; i < kolvo; i++) 
        {
            byte[] parames = Encoding.ASCII.GetBytes(strings[i]);
            udpClient.Send(parames, parames.Length, serverIP, serverPort);
        }

        byte[] finalrespBytes = udpClient.Receive(ref serverEndPoint);
        string finalresp = Encoding.ASCII.GetString(finalrespBytes);

        Console.WriteLine();
        Console.WriteLine("Финальная команда: ");
        Console.WriteLine(finalresp);
    }
}