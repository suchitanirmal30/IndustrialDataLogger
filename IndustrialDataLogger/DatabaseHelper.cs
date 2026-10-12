using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialDataLogger
{
    internal class DatabaseHelper
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["ADBConnection"].ConnectionString;

        public bool TestConnection(out string message)
        {
            try
            {
                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    connection.Open();

                    message = "Connected to database successfully!";

                    return true;
                }
            }
            catch (Exception ex)
            {
                message = "Database connection failed: " + ex.Message;

                return false;
            }
        }


        public bool InsertMachineData(
    string barcode,
    double temperature,
    double torque,
    int status,
    double angle,
    int cyclesStop,
    out string message)
        {
            try
            {
                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    string query = @"
                INSERT INTO MachineData
                (Barcode, Temperature, Torque, Status, Angle, CyclesStop)
                VALUES
                (@Barcode, @Temperature, @Torque, @Status, @Angle, @CyclesStop)";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Barcode", barcode);
                        command.Parameters.AddWithValue("@Temperature", temperature);
                        command.Parameters.AddWithValue("@Torque", torque);
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@Angle", angle);
                        command.Parameters.AddWithValue("@CyclesStop", cyclesStop);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            message = "Machine data saved successfully!";
                            return true;
                        }
                        else
                        {
                            message = "No data was inserted.";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Error saving machine data: " + ex.Message;
                return false;
            }
        }


        public DataTable GetMachineHistory()
        {
            DataTable dataTable = new DataTable();

            string query = @"
        SELECT TOP 100
            Id,
            Barcode,
            Temperature,
            Torque,
            Status,
            Angle,
            CyclesStop,
            CreatedAt
        FROM dbo.MachineData
        ORDER BY Id DESC;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading machine history: " + ex.Message);
            }

            return dataTable;
        }
    }
}
