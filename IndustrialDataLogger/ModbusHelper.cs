
using NModbus;
using System;
using System.Configuration;
using System.Net.Sockets;

namespace IndustrialDataLogger
{
    internal class ModbusHelper
    {
        private TcpClient tcpClient;
        private IModbusMaster modbusMaster;

        private string ipAddress;
        private int port;
        private byte unitId;

        public ModbusHelper()
        {
            ipAddress = ConfigurationManager.AppSettings["ModbusIP"];

            port = int.Parse(
                ConfigurationManager.AppSettings["ModbusPort"]
            );

            unitId = byte.Parse(
                ConfigurationManager.AppSettings["ModbusUnitId"]
            );
        }

        // Check connection status
        public bool IsConnected
        {
            get
            {
                return tcpClient != null &&
                       tcpClient.Connected &&
                       modbusMaster != null;
            }
        }

        // Establish Modbus TCP connection
        public bool Connect(out string message)
        {
            try
            {
                Disconnect();

                tcpClient = new TcpClient();

                tcpClient.Connect(ipAddress, port);

                ModbusFactory factory = new ModbusFactory();

                modbusMaster = factory.CreateMaster(tcpClient);

                message = "Modbus TCP connection established successfully!";

                return true;
            }
            catch (Exception ex)
            {
                Disconnect();

                message = "Modbus connection failed: " + ex.Message;

                return false;
            }
        }

        // Disconnect from Modbus device
        public void Disconnect()
        {
            try
            {
                if (modbusMaster != null)
                {
                    modbusMaster.Dispose();
                    modbusMaster = null;
                }
            }
            catch
            {
                // Ignore disposal errors
            }

            try
            {
                if (tcpClient != null)
                {
                    tcpClient.Close();
                    tcpClient = null;
                }
            }
            catch
            {
                // Ignore closing errors
            }
        }

        // Check whether Modbus is ready for communication
        private void EnsureConnected()
        {
            if (!IsConnected)
            {
                throw new InvalidOperationException(
                    "Modbus device is not connected."
                );
            }
        }


        // ==========================================
        // READ METHODS
        // ==========================================

        // 1. Read Coils (Digital Outputs)
        public bool[] ReadCoils(
            ushort startAddress,
            ushort numberOfPoints)
        {
            EnsureConnected();

            return modbusMaster.ReadCoils(
                unitId,
                startAddress,
                numberOfPoints
            );
        }

        // 2. Read Discrete Inputs
        public bool[] ReadDiscreteInputs(
            ushort startAddress,
            ushort numberOfPoints)
        {
            EnsureConnected();

            return modbusMaster.ReadInputs(
                unitId,
                startAddress,
                numberOfPoints
            );
        }

        // 3. Read Holding Registers
        public ushort[] ReadHoldingRegisters(
            ushort startAddress,
            ushort numberOfRegisters)
        {
            EnsureConnected();

            return modbusMaster.ReadHoldingRegisters(
                unitId,
                startAddress,
                numberOfRegisters
            );
        }

        // 4. Read Input Registers
        public ushort[] ReadInputRegisters(
            ushort startAddress,
            ushort numberOfRegisters)
        {
            EnsureConnected();

            return modbusMaster.ReadInputRegisters(
                unitId,
                startAddress,
                numberOfRegisters
            );
        }


        // ==========================================
        // WRITE METHODS
        // ==========================================

        // 5. Write Single Coil
        public void WriteSingleCoil(
            ushort address,
            bool value)
        {
            EnsureConnected();

            modbusMaster.WriteSingleCoil(
                unitId,
                address,
                value
            );
        }

        // 6. Write Multiple Coils
        public void WriteMultipleCoils(
            ushort startAddress,
            bool[] values)
        {
            EnsureConnected();

            if (values == null || values.Length == 0)
            {
                throw new ArgumentException(
                    "Coil values cannot be empty."
                );
            }

            modbusMaster.WriteMultipleCoils(
                unitId,
                startAddress,
                values
            );
        }

        // 7. Write Single Holding Register
        public void WriteSingleRegister(
            ushort address,
            ushort value)
        {
            EnsureConnected();

            modbusMaster.WriteSingleRegister(
                unitId,
                address,
                value
            );
        }

        // 8. Write Multiple Holding Registers
        public void WriteMultipleRegisters(
            ushort startAddress,
            ushort[] values)
        {
            EnsureConnected();

            if (values == null || values.Length == 0)
            {
                throw new ArgumentException(
                    "Register values cannot be empty."
                );
            }

            modbusMaster.WriteMultipleRegisters(
                unitId,
                startAddress,
                values
            );
        }

        // 9. Read and Write Multiple Registers
        public ushort[] ReadWriteMultipleRegisters(
            ushort readStartAddress,
            ushort readNumberOfRegisters,
            ushort writeStartAddress,
            ushort[] writeValues)
        {
            EnsureConnected();

            if (writeValues == null || writeValues.Length == 0)
            {
                throw new ArgumentException(
                    "Write values cannot be empty."
                );
            }

            return modbusMaster.ReadWriteMultipleRegisters(
                unitId,
                readStartAddress,
                readNumberOfRegisters,
                writeStartAddress,
                writeValues
            );
        }
    }
}