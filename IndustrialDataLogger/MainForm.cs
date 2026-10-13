using NModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace IndustrialDataLogger
{
    public partial class MainForm : Form
    {
        private IModbusMaster modbusMaster;
        private ModbusHelper modbus;
        // Stores the previous CyclesStop value
        private MqttHelper mqtt;

        private int previousCyclesStop = 0;

        // Prevents duplicate saving while CyclesStop remains 1
        private bool cycleDataSaved = false;
        private string temperatureTopic;
        private string torqueTopic;
        private string statusTopic;
        private string angleTopic;
        private string cyclesStopTopic;
        public MainForm()
        {
            InitializeComponent();
            // Set application title and version
            this.Text = "Industrial Data Logger - v1.0.1";

            mqtt = new MqttHelper();

            temperatureTopic =
                ConfigurationManager.AppSettings["TemperatureTopic"];

            torqueTopic =
                ConfigurationManager.AppSettings["TorqueTopic"];

            statusTopic =
                ConfigurationManager.AppSettings["StatusTopic"];

            angleTopic =
                ConfigurationManager.AppSettings["AngleTopic"];

            cyclesStopTopic =
                ConfigurationManager.AppSettings["CyclesStopTopic"];
        }

        private void lblAngleValue_Click(object sender, EventArgs e)
        {

        }

        private void lblTemperatureValue_Click(object sender, EventArgs e)
        {

        }

        private void lblBarcode_Click(object sender, EventArgs e)
        {

        }

        private void txtBarcode_Click(object sender, EventArgs e)
        {

        }


        private void btnTestDatabase_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();

            string message;

            bool isConnected = db.TestConnection(out message);

            if (isConnected)
            {
                lblDatabaseStatus.Text = "Database: Connected";
                lblDatabaseStatus.ForeColor = Color.Green;

                MessageBox.Show(
                    message,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                lblDatabaseStatus.Text = "Database: Not Connected";
                lblDatabaseStatus.ForeColor = Color.Red;

                MessageBox.Show(
                    message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }



        private void btnSaveTestData_Click(object sender, EventArgs e)
        {
            // Step 1: Get barcode entered by operator
            string barcode = txtBarcode.Text.Trim();

            // Step 2: Validate barcode
            if (string.IsNullOrWhiteSpace(barcode))
            {
                MessageBox.Show(
                    "Please scan or enter a barcode.",
                    "Barcode Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtBarcode.Focus();
                return;
            }

            // Step 3: Check Modbus connection
            if (modbus == null || !modbus.IsConnected)
            {
                MessageBox.Show(
                    "Please connect to the machine first.",
                    "Modbus Not Connected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                // Step 4: Read latest machine values
                ushort[] registers = modbus.ReadHoldingRegisters(0, 8);

                double temperature = registers[0];
                double torque = registers[1];
                int status = registers[2];
                double angle = registers[3];
                int cyclesStop = registers[4];

                // Step 5: Create database helper object
                DatabaseHelper db = new DatabaseHelper();

                string message;

                // Step 6: Save barcode and machine readings
                bool isSaved = db.InsertMachineData(
                    barcode,
                    temperature,
                    torque,
                    status,
                    angle,
                    cyclesStop,
                    out message
                );

                // Step 7: Show result

                if (isSaved)
                {
                    // Automatically reload the history grid
                    btnRefreshHistory.PerformClick();

                    MessageBox.Show("Machine data saved successfully!\n\n" +
                        "Barcode: " + barcode, "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtBarcode.Clear();
                    txtBarcode.Focus();
                }
                else
                {
                    MessageBox.Show(
                        message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving machine data: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private async void btnTestModbus_Click(object sender, EventArgs e)
        {
            modbus = new ModbusHelper();

            string message;

            bool connected = modbus.Connect(out message);

            if (connected)
            {
                lblConnectionStatus.Text = "Modbus: Connected";
                lblConnectionStatus.ForeColor = Color.Green;

                bool mqttConnected = await mqtt.ConnectAsync();

                if (!mqttConnected)
                {
                    MessageBox.Show(
                        "Modbus connected, but MQTT connection failed.",
                        "MQTT Connection Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                timer1.Start();

                MessageBox.Show(
                    "Modbus and MQTT connected successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                lblConnectionStatus.Text = "Modbus: Not Connected";
                lblConnectionStatus.ForeColor = Color.Red;

                MessageBox.Show(
                    message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnReadRegisters_Click(object sender, EventArgs e)
        {
            UpdateMachineParameters();
            try
            {
                // Check whether Modbus is connected
                if (modbus == null || !modbus.IsConnected)
                {
                    MessageBox.Show(
                        "Please connect to the Modbus device first.",
                        "Not Connected",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // Read 8 holding registers starting from address 0
                ushort[] registers = modbus.ReadHoldingRegisters(0, 8);

                // Display the received values on the form
                lblTemperatureValue.Text = registers[0].ToString() + " °C";

                lblTorqueValue.Text = registers[1].ToString() + " Nm";

                lblStatusValue.Text = registers[2].ToString();

                lblAngleValue.Text = registers[3].ToString() + " °";

                lblCyclesStopValue.Text = registers[4].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error reading machine data: " + ex.Message,
                    "Read Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private async void UpdateMachineParameters()
        {
            try
            {
                if (modbus == null || !modbus.IsConnected)
                {
                    return;
                }

                // Read 8 holding registers
                ushort[] registers = modbus.ReadHoldingRegisters(0, 8);

                // Read machine values
                double temperature = registers[0];
                double torque = registers[1];
                int status = registers[2];
                double angle = registers[3];
                int cyclesStop = registers[4];

                // Publish machine parameters through MQTT
                await mqtt.PublishAsync(
                    temperatureTopic,
                    temperature.ToString()
                );

                await mqtt.PublishAsync(
                    torqueTopic,
                    torque.ToString()
                );

                await mqtt.PublishAsync(
                    statusTopic,
                    status.ToString()
                );

                await mqtt.PublishAsync(
                    angleTopic,
                    angle.ToString()
                );

                await mqtt.PublishAsync(
                    cyclesStopTopic,
                    cyclesStop.ToString()
                );

                // Update machine parameter labels
                lblTemperatureValue.Text = temperature + " °C";

                lblTorqueValue.Text = torque + " Nm";

                lblStatusValue.Text = status.ToString();

                lblAngleValue.Text = angle + " °";

                lblCyclesStopValue.Text = cyclesStop.ToString();

                // Update timestamp
                lblLastUpdated.Text =
                    "Last Updated: " + DateTime.Now.ToString("HH:mm:ss");


                // ==========================================
                // AUTOMATIC CYCLE DATA SAVING
                // ==========================================

                // CyclesStop has returned to 0.
                // This means a new cycle can be detected later.
                if (cyclesStop == 0)
                {
                    cycleDataSaved = false;
                }


                // CyclesStop is 1 and data has not yet been saved
                if (cyclesStop == 1 && !cycleDataSaved)
                {
                    string barcode = txtBarcode.Text.Trim();

                    // Check barcode
                    if (string.IsNullOrWhiteSpace(barcode))
                    {
                        lblLastUpdated.Text =
                            "CyclesStop = 1 - Please enter barcode";

                        return;
                    }


                    // Create database helper
                    DatabaseHelper db = new DatabaseHelper();

                    string message;

                    // Save machine data
                    bool isSaved = db.InsertMachineData(
                        barcode,
                        temperature,
                        torque,
                        status,
                        angle,
                        cyclesStop,
                        out message
                    );


                    if (isSaved)
                    {
                        // Mark this cycle as saved
                        cycleDataSaved = true;

                        // Refresh history grid
                        btnRefreshHistory.PerformClick();

                        // Clear barcode for next cycle
                        txtBarcode.Clear();

                        // Put cursor back into barcode field
                        txtBarcode.Focus();

                        // Show save status
                        lblLastUpdated.Text =
                            "Cycle saved successfully: " +
                            barcode +
                            " | " +
                            DateTime.Now.ToString("HH:mm:ss");
                    }
                    else
                    {
                        lblLastUpdated.Text =
                            "Error saving cycle data";
                    }
                }


                // Store current value for reference
                previousCyclesStop = cyclesStop;
            }
            catch (Exception ex)
            {
                timer1.Stop();

                MessageBox.Show(
                    "Error reading machine data: " + ex.Message,
                    "Read Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateMachineParameters();
        }


        private void btnRefreshHistory_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                DataTable history = db.GetMachineHistory();

                dgvMachineHistory.DataSource = history;

                dgvMachineHistory.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvMachineHistory.ReadOnly = true;

                dgvMachineHistory.AllowUserToAddRows = false;

                dgvMachineHistory.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "History Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (modbus == null || !modbus.IsConnected)
                {
                    MessageBox.Show(
                        "Please connect Modbus first.",
                        "Modbus",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // CyclesStop is register index 4 in our simulator
                modbus.WriteSingleRegister(4, 0);

                MessageBox.Show(
                    "CyclesStop set to 0",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error writing CyclesStop: " + ex.Message,
                    "Write Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (modbus == null || !modbus.IsConnected)
                {
                    MessageBox.Show(
                        "Please connect Modbus first.",
                        "Modbus",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // CyclesStop is register index 4 in our simulator
                modbus.WriteSingleRegister(4, 1);

                MessageBox.Show(
                    "CyclesStop set to 1",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error writing CyclesStop: " + ex.Message,
                    "Write Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private async void btnTestMqtt_Click(object sender, EventArgs e)
        {
            bool connected = await mqtt.ConnectAsync();

            if (connected)
            {
                await mqtt.PublishAsync("TempTopic", "100");

                MessageBox.Show(
                    "MQTT Connected and TempTopic = 100 published successfully."
                );
            }
            else
            {
                MessageBox.Show("MQTT connection failed.");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTorqueValue_Click(object sender, EventArgs e)
        {

        }

        private void grpParameters_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
