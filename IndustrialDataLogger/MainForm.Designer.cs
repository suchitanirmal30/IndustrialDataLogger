namespace IndustrialDataLogger
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHeading = new System.Windows.Forms.Label();
            this.grpParameters = new System.Windows.Forms.GroupBox();
            this.pnlTorque = new System.Windows.Forms.Panel();
            this.lblTorque = new System.Windows.Forms.Label();
            this.lblTorqueValue = new System.Windows.Forms.Label();
            this.lblTemperatureValue = new System.Windows.Forms.Label();
            this.pnlTemperature = new System.Windows.Forms.Panel();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.grpBarcode = new System.Windows.Forms.GroupBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAngleValue = new System.Windows.Forms.Label();
            this.lblCyclesStop = new System.Windows.Forms.Label();
            this.lblCyclesStopValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.btnTestMqtt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.btnReadRegisters = new System.Windows.Forms.Button();
            this.btnTestModbus = new System.Windows.Forms.Button();
            this.btnSaveMachineData = new System.Windows.Forms.Button();
            this.lblDatabaseStatus = new System.Windows.Forms.Label();
            this.btnTestDatabase = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvMachineHistory = new System.Windows.Forms.DataGridView();
            this.btnRefreshHistory = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSystemStatus = new System.Windows.Forms.Label();
            this.lblApplicationSubtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDiagnostics = new System.Windows.Forms.Panel();
            this.lblDiagnosticsTitle = new System.Windows.Forms.Label();
            this.grpParameters.SuspendLayout();
            this.pnlTorque.SuspendLayout();
            this.pnlTemperature.SuspendLayout();
            this.grpBarcode.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineHistory)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlDiagnostics.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(24, 0);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(481, 48);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "INDUSTRIAL DATA LOGGER";
            // 
            // grpParameters
            // 
            this.grpParameters.AutoSize = true;
            this.grpParameters.Controls.Add(this.pnlTorque);
            this.grpParameters.Controls.Add(this.lblTemperatureValue);
            this.grpParameters.Controls.Add(this.pnlTemperature);
            this.grpParameters.Controls.Add(this.grpBarcode);
            this.grpParameters.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpParameters.ForeColor = System.Drawing.Color.Black;
            this.grpParameters.Location = new System.Drawing.Point(5, 126);
            this.grpParameters.Margin = new System.Windows.Forms.Padding(4);
            this.grpParameters.Name = "grpParameters";
            this.grpParameters.Padding = new System.Windows.Forms.Padding(4);
            this.grpParameters.Size = new System.Drawing.Size(698, 289);
            this.grpParameters.TabIndex = 1;
            this.grpParameters.TabStop = false;
            this.grpParameters.Text = "Parameters";
            this.grpParameters.Enter += new System.EventHandler(this.grpParameters_Enter);
            // 
            // pnlTorque
            // 
            this.pnlTorque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTorque.Controls.Add(this.lblTorque);
            this.pnlTorque.Controls.Add(this.lblTorqueValue);
            this.pnlTorque.Location = new System.Drawing.Point(170, 0);
            this.pnlTorque.Name = "pnlTorque";
            this.pnlTorque.Size = new System.Drawing.Size(154, 118);
            this.pnlTorque.TabIndex = 11;
            // 
            // lblTorque
            // 
            this.lblTorque.AutoSize = true;
            this.lblTorque.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorque.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTorque.Location = new System.Drawing.Point(4, 4);
            this.lblTorque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTorque.Name = "lblTorque";
            this.lblTorque.Size = new System.Drawing.Size(82, 28);
            this.lblTorque.TabIndex = 2;
            this.lblTorque.Text = "Torque:";
            // 
            // lblTorqueValue
            // 
            this.lblTorqueValue.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorqueValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTorqueValue.Location = new System.Drawing.Point(4, 39);
            this.lblTorqueValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTorqueValue.Name = "lblTorqueValue";
            this.lblTorqueValue.Size = new System.Drawing.Size(146, 65);
            this.lblTorqueValue.TabIndex = 3;
            this.lblTorqueValue.Text = "-- Nm";
            this.lblTorqueValue.Click += new System.EventHandler(this.lblTorqueValue_Click);
            // 
            // lblTemperatureValue
            // 
            this.lblTemperatureValue.AutoSize = true;
            this.lblTemperatureValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatureValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTemperatureValue.Location = new System.Drawing.Point(24, 34);
            this.lblTemperatureValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperatureValue.Name = "lblTemperatureValue";
            this.lblTemperatureValue.Size = new System.Drawing.Size(127, 65);
            this.lblTemperatureValue.TabIndex = 1;
            this.lblTemperatureValue.Text = "-- °C";
            this.lblTemperatureValue.Click += new System.EventHandler(this.lblTemperatureValue_Click);
            // 
            // pnlTemperature
            // 
            this.pnlTemperature.AutoSize = true;
            this.pnlTemperature.BackColor = System.Drawing.Color.White;
            this.pnlTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTemperature.Controls.Add(this.lblTemperature);
            this.pnlTemperature.Location = new System.Drawing.Point(10, 0);
            this.pnlTemperature.Name = "pnlTemperature";
            this.pnlTemperature.Size = new System.Drawing.Size(154, 118);
            this.pnlTemperature.TabIndex = 10;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTemperature.Location = new System.Drawing.Point(3, 0);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(137, 28);
            this.lblTemperature.TabIndex = 0;
            this.lblTemperature.Text = "Temperature:";
            // 
            // grpBarcode
            // 
            this.grpBarcode.Controls.Add(this.txtBarcode);
            this.grpBarcode.Controls.Add(this.lblBarcode);
            this.grpBarcode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBarcode.Location = new System.Drawing.Point(13, 140);
            this.grpBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.grpBarcode.Name = "grpBarcode";
            this.grpBarcode.Padding = new System.Windows.Forms.Padding(4);
            this.grpBarcode.Size = new System.Drawing.Size(638, 111);
            this.grpBarcode.TabIndex = 2;
            this.grpBarcode.TabStop = false;
            this.grpBarcode.Text = "Barcode Information";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBarcode.Location = new System.Drawing.Point(210, 43);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(421, 39);
            this.txtBarcode.TabIndex = 9;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcode.ForeColor = System.Drawing.Color.Black;
            this.lblBarcode.Location = new System.Drawing.Point(6, 49);
            this.lblBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(196, 28);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "Enter / Scan Barcode:";
            this.lblBarcode.Click += new System.EventHandler(this.lblBarcode_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Controls.Add(this.lblAngleValue);
            this.pnlStatus.Controls.Add(this.lblCyclesStop);
            this.pnlStatus.Controls.Add(this.lblCyclesStopValue);
            this.pnlStatus.Location = new System.Drawing.Point(495, 125);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(154, 118);
            this.pnlStatus.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGray;
            this.lblStatus.Location = new System.Drawing.Point(4, 6);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 30);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // lblAngleValue
            // 
            this.lblAngleValue.AutoSize = true;
            this.lblAngleValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAngleValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngleValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAngleValue.Location = new System.Drawing.Point(90, 12);
            this.lblAngleValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAngleValue.Name = "lblAngleValue";
            this.lblAngleValue.Size = new System.Drawing.Size(50, 32);
            this.lblAngleValue.TabIndex = 7;
            this.lblAngleValue.Text = "-- °";
            this.lblAngleValue.Click += new System.EventHandler(this.lblAngleValue_Click);
            // 
            // lblCyclesStop
            // 
            this.lblCyclesStop.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCyclesStop.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCyclesStop.Location = new System.Drawing.Point(4, 43);
            this.lblCyclesStop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCyclesStop.Name = "lblCyclesStop";
            this.lblCyclesStop.Size = new System.Drawing.Size(78, 62);
            this.lblCyclesStop.TabIndex = 8;
            this.lblCyclesStop.Text = "Cycles Stop:";
            // 
            // lblCyclesStopValue
            // 
            this.lblCyclesStopValue.AutoSize = true;
            this.lblCyclesStopValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCyclesStopValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCyclesStopValue.Location = new System.Drawing.Point(90, 67);
            this.lblCyclesStopValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCyclesStopValue.Name = "lblCyclesStopValue";
            this.lblCyclesStopValue.Size = new System.Drawing.Size(34, 32);
            this.lblCyclesStopValue.TabIndex = 9;
            this.lblCyclesStopValue.Text = "--";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblAngle);
            this.panel1.Controls.Add(this.lblStatusValue);
            this.panel1.Location = new System.Drawing.Point(335, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 118);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAngle.Location = new System.Drawing.Point(4, 5);
            this.lblAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(72, 28);
            this.lblAngle.TabIndex = 6;
            this.lblAngle.Text = "Angle:";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusValue.Location = new System.Drawing.Point(4, 32);
            this.lblStatusValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(132, 81);
            this.lblStatusValue.TabIndex = 5;
            this.lblStatusValue.Text = "Not Available";
            // 
            // btnTestMqtt
            // 
            this.btnTestMqtt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestMqtt.Location = new System.Drawing.Point(551, 6);
            this.btnTestMqtt.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestMqtt.Name = "btnTestMqtt";
            this.btnTestMqtt.Size = new System.Drawing.Size(131, 38);
            this.btnTestMqtt.TabIndex = 12;
            this.btnTestMqtt.Text = "Test MQTT";
            this.btnTestMqtt.UseVisualStyleBackColor = true;
            this.btnTestMqtt.Click += new System.EventHandler(this.btnTestMqtt_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(514, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Set CyclesStop = 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(319, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Set CyclesStop = 0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.ForeColor = System.Drawing.Color.LightGray;
            this.lblLastUpdated.Location = new System.Drawing.Point(1091, 48);
            this.lblLastUpdated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(114, 28);
            this.lblLastUpdated.TabIndex = 8;
            this.lblLastUpdated.Text = "Updated: --";
            // 
            // btnReadRegisters
            // 
            this.btnReadRegisters.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadRegisters.Location = new System.Drawing.Point(322, 55);
            this.btnReadRegisters.Margin = new System.Windows.Forms.Padding(4);
            this.btnReadRegisters.Name = "btnReadRegisters";
            this.btnReadRegisters.Size = new System.Drawing.Size(189, 40);
            this.btnReadRegisters.TabIndex = 7;
            this.btnReadRegisters.Text = "Read Machine Data";
            this.btnReadRegisters.UseVisualStyleBackColor = true;
            this.btnReadRegisters.Click += new System.EventHandler(this.btnReadRegisters_Click);
            // 
            // btnTestModbus
            // 
            this.btnTestModbus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestModbus.Location = new System.Drawing.Point(4, 89);
            this.btnTestModbus.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestModbus.Name = "btnTestModbus";
            this.btnTestModbus.Size = new System.Drawing.Size(164, 71);
            this.btnTestModbus.TabIndex = 6;
            this.btnTestModbus.Text = "Test Modbus Connection";
            this.btnTestModbus.UseVisualStyleBackColor = true;
            this.btnTestModbus.Click += new System.EventHandler(this.btnTestModbus_Click);
            // 
            // btnSaveMachineData
            // 
            this.btnSaveMachineData.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMachineData.Location = new System.Drawing.Point(513, 55);
            this.btnSaveMachineData.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveMachineData.Name = "btnSaveMachineData";
            this.btnSaveMachineData.Size = new System.Drawing.Size(189, 41);
            this.btnSaveMachineData.TabIndex = 5;
            this.btnSaveMachineData.Text = "Save Machine Data";
            this.btnSaveMachineData.UseVisualStyleBackColor = true;
            this.btnSaveMachineData.Click += new System.EventHandler(this.btnSaveTestData_Click);
            // 
            // lblDatabaseStatus
            // 
            this.lblDatabaseStatus.AutoSize = true;
            this.lblDatabaseStatus.ForeColor = System.Drawing.Color.Red;
            this.lblDatabaseStatus.Location = new System.Drawing.Point(169, 55);
            this.lblDatabaseStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatabaseStatus.Name = "lblDatabaseStatus";
            this.lblDatabaseStatus.Size = new System.Drawing.Size(145, 28);
            this.lblDatabaseStatus.TabIndex = 4;
            this.lblDatabaseStatus.Text = "Not Connected";
            // 
            // btnTestDatabase
            // 
            this.btnTestDatabase.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestDatabase.Location = new System.Drawing.Point(4, 46);
            this.btnTestDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestDatabase.Name = "btnTestDatabase";
            this.btnTestDatabase.Size = new System.Drawing.Size(164, 39);
            this.btnTestDatabase.TabIndex = 3;
            this.btnTestDatabase.Text = "Test Database Connection";
            this.btnTestDatabase.UseVisualStyleBackColor = true;
            this.btnTestDatabase.Click += new System.EventHandler(this.btnTestDatabase_Click);
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(169, 103);
            this.lblConnectionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(145, 28);
            this.lblConnectionStatus.TabIndex = 2;
            this.lblConnectionStatus.Text = "Not Connected";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvMachineHistory
            // 
            this.dgvMachineHistory.AllowUserToAddRows = false;
            this.dgvMachineHistory.AllowUserToDeleteRows = false;
            this.dgvMachineHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMachineHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMachineHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachineHistory.Location = new System.Drawing.Point(710, 125);
            this.dgvMachineHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMachineHistory.MultiSelect = false;
            this.dgvMachineHistory.Name = "dgvMachineHistory";
            this.dgvMachineHistory.ReadOnly = true;
            this.dgvMachineHistory.RowHeadersWidth = 62;
            this.dgvMachineHistory.RowTemplate.Height = 28;
            this.dgvMachineHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMachineHistory.Size = new System.Drawing.Size(825, 492);
            this.dgvMachineHistory.TabIndex = 3;
            // 
            // btnRefreshHistory
            // 
            this.btnRefreshHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshHistory.Location = new System.Drawing.Point(710, 82);
            this.btnRefreshHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshHistory.Name = "btnRefreshHistory";
            this.btnRefreshHistory.Size = new System.Drawing.Size(231, 40);
            this.btnRefreshHistory.TabIndex = 4;
            this.btnRefreshHistory.Text = "Refresh History";
            this.btnRefreshHistory.UseVisualStyleBackColor = true;
            this.btnRefreshHistory.Click += new System.EventHandler(this.btnRefreshHistory_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.pnlHeader.Controls.Add(this.lblSystemStatus);
            this.pnlHeader.Controls.Add(this.lblApplicationSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeading);
            this.pnlHeader.Controls.Add(this.lblLastUpdated);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1548, 83);
            this.pnlHeader.TabIndex = 5;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblSystemStatus
            // 
            this.lblSystemStatus.AutoSize = true;
            this.lblSystemStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemStatus.ForeColor = System.Drawing.Color.White;
            this.lblSystemStatus.Location = new System.Drawing.Point(1091, 9);
            this.lblSystemStatus.Name = "lblSystemStatus";
            this.lblSystemStatus.Size = new System.Drawing.Size(186, 28);
            this.lblSystemStatus.TabIndex = 2;
            this.lblSystemStatus.Text = "● SYSTEM ONLINE";
            // 
            // lblApplicationSubtitle
            // 
            this.lblApplicationSubtitle.AutoSize = true;
            this.lblApplicationSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblApplicationSubtitle.Location = new System.Drawing.Point(24, 48);
            this.lblApplicationSubtitle.Name = "lblApplicationSubtitle";
            this.lblApplicationSubtitle.Size = new System.Drawing.Size(445, 28);
            this.lblApplicationSubtitle.TabIndex = 1;
            this.lblApplicationSubtitle.Text = "Machine Monitoring and Data Acquisition System";
            this.lblApplicationSubtitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "LIVE MACHINE PARAMETERS";
            // 
            // pnlDiagnostics
            // 
            this.pnlDiagnostics.BackColor = System.Drawing.Color.White;
            this.pnlDiagnostics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDiagnostics.Controls.Add(this.lblDiagnosticsTitle);
            this.pnlDiagnostics.Controls.Add(this.btnTestMqtt);
            this.pnlDiagnostics.Controls.Add(this.btnReadRegisters);
            this.pnlDiagnostics.Controls.Add(this.button2);
            this.pnlDiagnostics.Controls.Add(this.btnTestDatabase);
            this.pnlDiagnostics.Controls.Add(this.btnSaveMachineData);
            this.pnlDiagnostics.Controls.Add(this.lblDatabaseStatus);
            this.pnlDiagnostics.Controls.Add(this.btnTestModbus);
            this.pnlDiagnostics.Controls.Add(this.lblConnectionStatus);
            this.pnlDiagnostics.Controls.Add(this.button1);
            this.pnlDiagnostics.Location = new System.Drawing.Point(0, 422);
            this.pnlDiagnostics.Name = "pnlDiagnostics";
            this.pnlDiagnostics.Size = new System.Drawing.Size(703, 177);
            this.pnlDiagnostics.TabIndex = 13;
            // 
            // lblDiagnosticsTitle
            // 
            this.lblDiagnosticsTitle.AutoSize = true;
            this.lblDiagnosticsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosticsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblDiagnosticsTitle.Location = new System.Drawing.Point(6, 6);
            this.lblDiagnosticsTitle.Name = "lblDiagnosticsTitle";
            this.lblDiagnosticsTitle.Size = new System.Drawing.Size(272, 32);
            this.lblDiagnosticsTitle.TabIndex = 0;
            this.lblDiagnosticsTitle.Text = "SYSTEM DIAGNOSTICS";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1548, 643);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlDiagnostics);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnRefreshHistory);
            this.Controls.Add(this.dgvMachineHistory);
            this.Controls.Add(this.grpParameters);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Industrial Data Logger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpParameters.ResumeLayout(false);
            this.grpParameters.PerformLayout();
            this.pnlTorque.ResumeLayout(false);
            this.pnlTorque.PerformLayout();
            this.pnlTemperature.ResumeLayout(false);
            this.pnlTemperature.PerformLayout();
            this.grpBarcode.ResumeLayout(false);
            this.grpBarcode.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineHistory)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlDiagnostics.ResumeLayout(false);
            this.pnlDiagnostics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox grpParameters;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTorqueValue;
        private System.Windows.Forms.Label lblTorque;
        private System.Windows.Forms.Label lblTemperatureValue;
        private System.Windows.Forms.Label lblAngleValue;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblCyclesStopValue;
        private System.Windows.Forms.Label lblCyclesStop;
        private System.Windows.Forms.GroupBox grpBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTestDatabase;
        private System.Windows.Forms.Label lblDatabaseStatus;
        private System.Windows.Forms.Button btnSaveMachineData;
        private System.Windows.Forms.Button btnTestModbus;
        private System.Windows.Forms.Button btnReadRegisters;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.DataGridView dgvMachineHistory;
        private System.Windows.Forms.Button btnRefreshHistory;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTestMqtt;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblApplicationSubtitle;
        private System.Windows.Forms.Label lblSystemStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTemperature;
        private System.Windows.Forms.Panel pnlTorque;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel pnlDiagnostics;
        private System.Windows.Forms.Label lblDiagnosticsTitle;
    }
}