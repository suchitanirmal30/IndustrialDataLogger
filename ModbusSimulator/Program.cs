
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using NModbus;

class Program
{
    static void Main(string[] args)
    {
        int port = 502;
        byte unitId = 1;

        IPAddress ipAddress = IPAddress.Parse("127.0.0.1");

        TcpListener listener = new TcpListener(ipAddress, port);

        try
        {
            listener.Start();

            Console.WriteLine("==================================");
            Console.WriteLine("   INDUSTRIAL MACHINE SIMULATOR");
            Console.WriteLine("==================================");
            Console.WriteLine("Modbus TCP Server Started");
            Console.WriteLine("IP Address: 127.0.0.1");
            Console.WriteLine("Port: 502");
            Console.WriteLine("Unit ID: 1");
            Console.WriteLine("----------------------------------");

            ModbusFactory factory = new ModbusFactory();

            IModbusSlaveNetwork network =
                factory.CreateSlaveNetwork(listener);

            IModbusSlave slave = factory.CreateSlave(unitId);

            network.AddSlave(slave);

            // Initialize simulated holding registers.
            // These are zero-based addresses.

            ushort[] testRegisters =
            {
                100,  // Address 0
                200,  // Address 1
                0,    // Address 2
                300,  // Address 3
                400,  // Address 4
                0,    // Address 5
                500,  // Address 6
                600   // Address 7
            };

            slave.DataStore.HoldingRegisters.WritePoints(
                0,
                testRegisters
            );

            Console.WriteLine("Test registers initialized.");
            Console.WriteLine("Waiting for Data Logger connection...");
            Console.WriteLine("----------------------------------");

            network.ListenAsync().GetAwaiter().GetResult();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Simulator Error: " + ex.Message);
        }
        finally
        {
            listener.Stop();
        }
    }
}