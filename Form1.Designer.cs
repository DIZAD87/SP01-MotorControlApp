namespace MOTOR_INTERFACE
{
    partial class Motor_Interface_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Motor_Interface_Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.But_Reverse = new System.Windows.Forms.Button();
            this.But_Forward = new System.Windows.Forms.Button();
            this.LRPM = new System.Windows.Forms.Label();
            this.LMotorSpeed = new System.Windows.Forms.Label();
            this.LBaude = new System.Windows.Forms.Label();
            this.SBox_Ports = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SBox_Baude = new System.Windows.Forms.ComboBox();
            this.EBox_RPM = new System.Windows.Forms.TextBox();
            this.PBar_Connection = new System.Windows.Forms.ProgressBar();
            this.L_Connection = new System.Windows.Forms.Label();
            this.But_Connect = new System.Windows.Forms.Button();
            this.But_Close = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Direction = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.L_Limit_MAX = new System.Windows.Forms.Label();
            this.L_RPM_MIN = new System.Windows.Forms.Label();
            this.L_Limit_MIN = new System.Windows.Forms.Label();
            this.LTorqueLimit = new System.Windows.Forms.Label();
            this.L_RPM_MAX = new System.Windows.Forms.Label();
            this.EBox_Torque_Limit = new System.Windows.Forms.TextBox();
            this.TBar_RPM = new System.Windows.Forms.TrackBar();
            this.LInLb = new System.Windows.Forms.Label();
            this.TBar_Torque_Limit = new System.Windows.Forms.TrackBar();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.But_Start = new System.Windows.Forms.Button();
            this.But_Stop = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.But_CalTorque = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EBox_CalTorque_O = new System.Windows.Forms.TextBox();
            this.EBox_CalTorque_S = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.L_BitReadout = new System.Windows.Forms.Label();
            this.PBar_Torque = new System.Windows.Forms.ProgressBar();
            this.RBox_Torque = new System.Windows.Forms.TextBox();
            this.RBox_Bit = new System.Windows.Forms.TextBox();
            this.NBox_Control = new System.Windows.Forms.GroupBox();
            this.But_Start_Data = new System.Windows.Forms.Button();
            this.But_Stop_Data = new System.Windows.Forms.Button();
            this.But_Save_Data = new System.Windows.Forms.Button();
            this.RBox_Data = new System.Windows.Forms.TextBox();
            this.I_Motor = new System.Windows.Forms.PictureBox();
            this.Chart_Torque = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.Direction.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBar_RPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBar_Torque_Limit)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.NBox_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.I_Motor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Torque)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // But_Reverse
            // 
            this.But_Reverse.Location = new System.Drawing.Point(113, 21);
            this.But_Reverse.Name = "But_Reverse";
            this.But_Reverse.Size = new System.Drawing.Size(85, 35);
            this.But_Reverse.TabIndex = 0;
            this.But_Reverse.Text = "Reverse";
            this.But_Reverse.UseVisualStyleBackColor = true;
            this.But_Reverse.Click += new System.EventHandler(this.BReverse_Click);
            // 
            // But_Forward
            // 
            this.But_Forward.Location = new System.Drawing.Point(9, 21);
            this.But_Forward.Name = "But_Forward";
            this.But_Forward.Size = new System.Drawing.Size(85, 35);
            this.But_Forward.TabIndex = 1;
            this.But_Forward.Text = "Forward";
            this.But_Forward.UseVisualStyleBackColor = true;
            this.But_Forward.Click += new System.EventHandler(this.BForward_Click);
            // 
            // LRPM
            // 
            this.LRPM.AutoSize = true;
            this.LRPM.Location = new System.Drawing.Point(139, 22);
            this.LRPM.Name = "LRPM";
            this.LRPM.Size = new System.Drawing.Size(65, 13);
            this.LRPM.TabIndex = 4;
            this.LRPM.Text = "X10^2 RPM";
            // 
            // LMotorSpeed
            // 
            this.LMotorSpeed.AutoSize = true;
            this.LMotorSpeed.Location = new System.Drawing.Point(16, 22);
            this.LMotorSpeed.Name = "LMotorSpeed";
            this.LMotorSpeed.Size = new System.Drawing.Size(71, 13);
            this.LMotorSpeed.TabIndex = 5;
            this.LMotorSpeed.Text = "Motor Speed:";
            // 
            // LBaude
            // 
            this.LBaude.AutoSize = true;
            this.LBaude.Location = new System.Drawing.Point(12, 29);
            this.LBaude.Name = "LBaude";
            this.LBaude.Size = new System.Drawing.Size(67, 13);
            this.LBaude.TabIndex = 7;
            this.LBaude.Text = "Baude Rate:";
            // 
            // SBox_Ports
            // 
            this.SBox_Ports.FormattingEnabled = true;
            this.SBox_Ports.Location = new System.Drawing.Point(111, 55);
            this.SBox_Ports.Name = "SBox_Ports";
            this.SBox_Ports.Size = new System.Drawing.Size(100, 21);
            this.SBox_Ports.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port Name:";
            // 
            // SBox_Baude
            // 
            this.SBox_Baude.FormattingEnabled = true;
            this.SBox_Baude.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "35400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000"});
            this.SBox_Baude.Location = new System.Drawing.Point(111, 26);
            this.SBox_Baude.Name = "SBox_Baude";
            this.SBox_Baude.Size = new System.Drawing.Size(100, 21);
            this.SBox_Baude.TabIndex = 10;
            // 
            // EBox_RPM
            // 
            this.EBox_RPM.Location = new System.Drawing.Point(90, 19);
            this.EBox_RPM.Name = "EBox_RPM";
            this.EBox_RPM.Size = new System.Drawing.Size(50, 20);
            this.EBox_RPM.TabIndex = 11;
            this.EBox_RPM.Text = "2";
            this.EBox_RPM.TextChanged += new System.EventHandler(this.EBox_RPM_TextChanged);
            // 
            // PBar_Connection
            // 
            this.PBar_Connection.Location = new System.Drawing.Point(111, 82);
            this.PBar_Connection.Name = "PBar_Connection";
            this.PBar_Connection.Size = new System.Drawing.Size(100, 23);
            this.PBar_Connection.TabIndex = 12;
            // 
            // L_Connection
            // 
            this.L_Connection.AutoSize = true;
            this.L_Connection.Location = new System.Drawing.Point(13, 87);
            this.L_Connection.Name = "L_Connection";
            this.L_Connection.Size = new System.Drawing.Size(97, 13);
            this.L_Connection.TabIndex = 13;
            this.L_Connection.Text = "Connection Status:";
            // 
            // But_Connect
            // 
            this.But_Connect.Location = new System.Drawing.Point(15, 118);
            this.But_Connect.Name = "But_Connect";
            this.But_Connect.Size = new System.Drawing.Size(85, 35);
            this.But_Connect.TabIndex = 14;
            this.But_Connect.Text = "Open Port";
            this.But_Connect.UseVisualStyleBackColor = true;
            this.But_Connect.Click += new System.EventHandler(this.But_Connect_Click);
            // 
            // But_Close
            // 
            this.But_Close.Location = new System.Drawing.Point(119, 119);
            this.But_Close.Name = "But_Close";
            this.But_Close.Size = new System.Drawing.Size(85, 35);
            this.But_Close.TabIndex = 16;
            this.But_Close.Text = "Close Port";
            this.But_Close.UseVisualStyleBackColor = true;
            this.But_Close.Click += new System.EventHandler(this.But_Close_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Direction);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Location = new System.Drawing.Point(8, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 286);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motor Control:";
            // 
            // Direction
            // 
            this.Direction.Controls.Add(this.But_Forward);
            this.Direction.Controls.Add(this.But_Reverse);
            this.Direction.Location = new System.Drawing.Point(6, 20);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(205, 65);
            this.Direction.TabIndex = 27;
            this.Direction.TabStop = false;
            this.Direction.Text = "Direction:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.L_Limit_MAX);
            this.groupBox9.Controls.Add(this.L_RPM_MIN);
            this.groupBox9.Controls.Add(this.L_Limit_MIN);
            this.groupBox9.Controls.Add(this.EBox_RPM);
            this.groupBox9.Controls.Add(this.LTorqueLimit);
            this.groupBox9.Controls.Add(this.L_RPM_MAX);
            this.groupBox9.Controls.Add(this.EBox_Torque_Limit);
            this.groupBox9.Controls.Add(this.TBar_RPM);
            this.groupBox9.Controls.Add(this.LInLb);
            this.groupBox9.Controls.Add(this.LRPM);
            this.groupBox9.Controls.Add(this.LMotorSpeed);
            this.groupBox9.Controls.Add(this.TBar_Torque_Limit);
            this.groupBox9.Location = new System.Drawing.Point(6, 89);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(211, 191);
            this.groupBox9.TabIndex = 25;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Motor Initiation:";
            // 
            // L_Limit_MAX
            // 
            this.L_Limit_MAX.AutoSize = true;
            this.L_Limit_MAX.Location = new System.Drawing.Point(179, 160);
            this.L_Limit_MAX.Name = "L_Limit_MAX";
            this.L_Limit_MAX.Size = new System.Drawing.Size(13, 13);
            this.L_Limit_MAX.TabIndex = 28;
            this.L_Limit_MAX.Text = "5";
            // 
            // L_RPM_MIN
            // 
            this.L_RPM_MIN.AutoSize = true;
            this.L_RPM_MIN.Location = new System.Drawing.Point(6, 77);
            this.L_RPM_MIN.Name = "L_RPM_MIN";
            this.L_RPM_MIN.Size = new System.Drawing.Size(13, 13);
            this.L_RPM_MIN.TabIndex = 24;
            this.L_RPM_MIN.Text = "0";
            // 
            // L_Limit_MIN
            // 
            this.L_Limit_MIN.AutoSize = true;
            this.L_Limit_MIN.Location = new System.Drawing.Point(6, 161);
            this.L_Limit_MIN.Name = "L_Limit_MIN";
            this.L_Limit_MIN.Size = new System.Drawing.Size(13, 13);
            this.L_Limit_MIN.TabIndex = 26;
            this.L_Limit_MIN.Text = "1";
            // 
            // LTorqueLimit
            // 
            this.LTorqueLimit.AutoSize = true;
            this.LTorqueLimit.Location = new System.Drawing.Point(16, 105);
            this.LTorqueLimit.Name = "LTorqueLimit";
            this.LTorqueLimit.Size = new System.Drawing.Size(68, 13);
            this.LTorqueLimit.TabIndex = 25;
            this.LTorqueLimit.Text = "Torque Limit:";
            // 
            // L_RPM_MAX
            // 
            this.L_RPM_MAX.AutoSize = true;
            this.L_RPM_MAX.Location = new System.Drawing.Point(179, 77);
            this.L_RPM_MAX.Name = "L_RPM_MAX";
            this.L_RPM_MAX.Size = new System.Drawing.Size(13, 13);
            this.L_RPM_MAX.TabIndex = 23;
            this.L_RPM_MAX.Text = "3";
            // 
            // EBox_Torque_Limit
            // 
            this.EBox_Torque_Limit.Location = new System.Drawing.Point(90, 102);
            this.EBox_Torque_Limit.Name = "EBox_Torque_Limit";
            this.EBox_Torque_Limit.Size = new System.Drawing.Size(50, 20);
            this.EBox_Torque_Limit.TabIndex = 26;
            this.EBox_Torque_Limit.Text = "5";
            this.EBox_Torque_Limit.TextChanged += new System.EventHandler(this.EBox_Torque_Limit_TextChanged);
            // 
            // TBar_RPM
            // 
            this.TBar_RPM.BackColor = System.Drawing.Color.White;
            this.TBar_RPM.Location = new System.Drawing.Point(9, 45);
            this.TBar_RPM.Maximum = 3;
            this.TBar_RPM.Name = "TBar_RPM";
            this.TBar_RPM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBar_RPM.Size = new System.Drawing.Size(189, 45);
            this.TBar_RPM.TabIndex = 21;
            this.TBar_RPM.Value = 3;
            this.TBar_RPM.Scroll += new System.EventHandler(this.TBar_RPM_Scroll);
            // 
            // LInLb
            // 
            this.LInLb.AutoSize = true;
            this.LInLb.Location = new System.Drawing.Point(144, 105);
            this.LInLb.Name = "LInLb";
            this.LInLb.Size = new System.Drawing.Size(27, 13);
            this.LInLb.TabIndex = 23;
            this.LInLb.Text = "In-lb";
            // 
            // TBar_Torque_Limit
            // 
            this.TBar_Torque_Limit.BackColor = System.Drawing.Color.White;
            this.TBar_Torque_Limit.Location = new System.Drawing.Point(9, 128);
            this.TBar_Torque_Limit.Maximum = 5;
            this.TBar_Torque_Limit.Minimum = 1;
            this.TBar_Torque_Limit.Name = "TBar_Torque_Limit";
            this.TBar_Torque_Limit.Size = new System.Drawing.Size(189, 45);
            this.TBar_Torque_Limit.TabIndex = 24;
            this.TBar_Torque_Limit.Value = 5;
            this.TBar_Torque_Limit.Scroll += new System.EventHandler(this.TBar_Torque_Limit_Scroll);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.But_Start);
            this.groupBox8.Controls.Add(this.But_Stop);
            this.groupBox8.Location = new System.Drawing.Point(8, 560);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(221, 65);
            this.groupBox8.TabIndex = 25;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Power:";
            // 
            // But_Start
            // 
            this.But_Start.Location = new System.Drawing.Point(11, 19);
            this.But_Start.Name = "But_Start";
            this.But_Start.Size = new System.Drawing.Size(85, 35);
            this.But_Start.TabIndex = 21;
            this.But_Start.Text = "Start Motor";
            this.But_Start.UseVisualStyleBackColor = true;
            this.But_Start.Click += new System.EventHandler(this.But_Start_Click);
            // 
            // But_Stop
            // 
            this.But_Stop.Location = new System.Drawing.Point(117, 19);
            this.But_Stop.Name = "But_Stop";
            this.But_Stop.Size = new System.Drawing.Size(85, 35);
            this.But_Stop.TabIndex = 22;
            this.But_Stop.Text = "Stop Motor";
            this.But_Stop.UseVisualStyleBackColor = true;
            this.But_Stop.Click += new System.EventHandler(this.But_Stop_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.But_CalTorque);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.EBox_CalTorque_O);
            this.groupBox3.Controls.Add(this.EBox_CalTorque_S);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(242, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 55);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calibration:";
            // 
            // But_CalTorque
            // 
            this.But_CalTorque.Location = new System.Drawing.Point(284, 12);
            this.But_CalTorque.Name = "But_CalTorque";
            this.But_CalTorque.Size = new System.Drawing.Size(85, 35);
            this.But_CalTorque.TabIndex = 40;
            this.But_CalTorque.Text = "Reset Default";
            this.But_CalTorque.UseVisualStyleBackColor = true;
            this.But_CalTorque.Click += new System.EventHandler(this.But_CalTorque_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "X Bit  + ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Torque = ";
            // 
            // EBox_CalTorque_O
            // 
            this.EBox_CalTorque_O.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EBox_CalTorque_O.Location = new System.Drawing.Point(189, 27);
            this.EBox_CalTorque_O.Name = "EBox_CalTorque_O";
            this.EBox_CalTorque_O.Size = new System.Drawing.Size(50, 20);
            this.EBox_CalTorque_O.TabIndex = 32;
            this.EBox_CalTorque_O.Text = "-7.076";
            // 
            // EBox_CalTorque_S
            // 
            this.EBox_CalTorque_S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EBox_CalTorque_S.Location = new System.Drawing.Point(90, 27);
            this.EBox_CalTorque_S.Name = "EBox_CalTorque_S";
            this.EBox_CalTorque_S.Size = new System.Drawing.Size(50, 20);
            this.EBox_CalTorque_S.TabIndex = 31;
            this.EBox_CalTorque_S.Text = "0.020";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Offset:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Slope:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.I_Motor);
            this.groupBox4.Controls.Add(this.Chart_Torque);
            this.groupBox4.Location = new System.Drawing.Point(242, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 545);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Acquisition:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.L_BitReadout);
            this.groupBox6.Controls.Add(this.PBar_Torque);
            this.groupBox6.Controls.Add(this.RBox_Torque);
            this.groupBox6.Controls.Add(this.RBox_Bit);
            this.groupBox6.Controls.Add(this.NBox_Control);
            this.groupBox6.Controls.Add(this.RBox_Data);
            this.groupBox6.Location = new System.Drawing.Point(6, 341);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(383, 198);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data Log:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Torque Readout:";
            // 
            // L_BitReadout
            // 
            this.L_BitReadout.AutoSize = true;
            this.L_BitReadout.Location = new System.Drawing.Point(193, 41);
            this.L_BitReadout.Name = "L_BitReadout";
            this.L_BitReadout.Size = new System.Drawing.Size(66, 13);
            this.L_BitReadout.TabIndex = 31;
            this.L_BitReadout.Text = "Bit Readout:";
            // 
            // PBar_Torque
            // 
            this.PBar_Torque.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PBar_Torque.Location = new System.Drawing.Point(11, 178);
            this.PBar_Torque.Maximum = 1023;
            this.PBar_Torque.Name = "PBar_Torque";
            this.PBar_Torque.Size = new System.Drawing.Size(360, 14);
            this.PBar_Torque.Step = 1;
            this.PBar_Torque.TabIndex = 27;
            this.PBar_Torque.Value = 2;
            // 
            // RBox_Torque
            // 
            this.RBox_Torque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RBox_Torque.ForeColor = System.Drawing.Color.Black;
            this.RBox_Torque.Location = new System.Drawing.Point(192, 133);
            this.RBox_Torque.Name = "RBox_Torque";
            this.RBox_Torque.Size = new System.Drawing.Size(73, 20);
            this.RBox_Torque.TabIndex = 25;
            // 
            // RBox_Bit
            // 
            this.RBox_Bit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RBox_Bit.ForeColor = System.Drawing.Color.Black;
            this.RBox_Bit.Location = new System.Drawing.Point(190, 57);
            this.RBox_Bit.Name = "RBox_Bit";
            this.RBox_Bit.Size = new System.Drawing.Size(75, 20);
            this.RBox_Bit.TabIndex = 32;
            // 
            // NBox_Control
            // 
            this.NBox_Control.Controls.Add(this.But_Start_Data);
            this.NBox_Control.Controls.Add(this.But_Stop_Data);
            this.NBox_Control.Controls.Add(this.But_Save_Data);
            this.NBox_Control.Location = new System.Drawing.Point(271, 24);
            this.NBox_Control.Name = "NBox_Control";
            this.NBox_Control.Size = new System.Drawing.Size(101, 142);
            this.NBox_Control.TabIndex = 28;
            this.NBox_Control.TabStop = false;
            this.NBox_Control.Text = "Control:";
            // 
            // But_Start_Data
            // 
            this.But_Start_Data.Location = new System.Drawing.Point(7, 19);
            this.But_Start_Data.Name = "But_Start_Data";
            this.But_Start_Data.Size = new System.Drawing.Size(85, 35);
            this.But_Start_Data.TabIndex = 25;
            this.But_Start_Data.Text = "Start Data";
            this.But_Start_Data.UseVisualStyleBackColor = true;
            this.But_Start_Data.Click += new System.EventHandler(this.But_Start_Data_Click);
            // 
            // But_Stop_Data
            // 
            this.But_Stop_Data.Location = new System.Drawing.Point(7, 60);
            this.But_Stop_Data.Name = "But_Stop_Data";
            this.But_Stop_Data.Size = new System.Drawing.Size(85, 35);
            this.But_Stop_Data.TabIndex = 28;
            this.But_Stop_Data.Text = "Stop Data";
            this.But_Stop_Data.UseVisualStyleBackColor = true;
            this.But_Stop_Data.Click += new System.EventHandler(this.But_Stop_Data_Click);
            // 
            // But_Save_Data
            // 
            this.But_Save_Data.Location = new System.Drawing.Point(7, 101);
            this.But_Save_Data.Name = "But_Save_Data";
            this.But_Save_Data.Size = new System.Drawing.Size(85, 35);
            this.But_Save_Data.TabIndex = 24;
            this.But_Save_Data.Text = "Save Data";
            this.But_Save_Data.UseVisualStyleBackColor = true;
            this.But_Save_Data.Click += new System.EventHandler(this.But_Save_Data_Click);
            // 
            // RBox_Data
            // 
            this.RBox_Data.Location = new System.Drawing.Point(11, 19);
            this.RBox_Data.Multiline = true;
            this.RBox_Data.Name = "RBox_Data";
            this.RBox_Data.Size = new System.Drawing.Size(171, 153);
            this.RBox_Data.TabIndex = 25;
            // 
            // I_Motor
            // 
            this.I_Motor.Image = ((System.Drawing.Image)(resources.GetObject("I_Motor.Image")));
            this.I_Motor.Location = new System.Drawing.Point(6, 19);
            this.I_Motor.Name = "I_Motor";
            this.I_Motor.Size = new System.Drawing.Size(73, 71);
            this.I_Motor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.I_Motor.TabIndex = 30;
            this.I_Motor.TabStop = false;
            // 
            // Chart_Torque
            // 
            this.Chart_Torque.AccessibleDescription = "";
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 84.31498F;
            chartArea1.InnerPlotPosition.Width = 86.65233F;
            chartArea1.InnerPlotPosition.X = 9F;
            chartArea1.InnerPlotPosition.Y = 4F;
            chartArea1.Name = "ChartArea1";
            this.Chart_Torque.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BorderColor = System.Drawing.Color.Gray;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend";
            legend1.TitleBackColor = System.Drawing.Color.White;
            this.Chart_Torque.Legends.Add(legend1);
            this.Chart_Torque.Location = new System.Drawing.Point(8, 19);
            this.Chart_Torque.Name = "Chart_Torque";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend";
            series1.Name = "Torque Readout";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend";
            series2.Name = "Torque Limit";
            this.Chart_Torque.Series.Add(series1);
            this.Chart_Torque.Series.Add(series2);
            this.Chart_Torque.Size = new System.Drawing.Size(379, 316);
            this.Chart_Torque.TabIndex = 23;
            this.Chart_Torque.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title1.Name = "Title";
            title1.Text = "Motor Torque Readout";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title2.Name = "Y-Axis";
            title2.Text = "Torque (in*lb)";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Name = "X-Axis";
            title3.Text = "Time (Milliseconds)";
            this.Chart_Torque.Titles.Add(title1);
            this.Chart_Torque.Titles.Add(title2);
            this.Chart_Torque.Titles.Add(title3);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(649, 633);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Motor Interface (DIZAD 11/10/16)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PBar_Connection);
            this.groupBox1.Controls.Add(this.L_Connection);
            this.groupBox1.Controls.Add(this.SBox_Ports);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SBox_Baude);
            this.groupBox1.Controls.Add(this.LBaude);
            this.groupBox1.Controls.Add(this.But_Connect);
            this.groupBox1.Controls.Add(this.But_Close);
            this.groupBox1.Location = new System.Drawing.Point(8, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 160);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Location = new System.Drawing.Point(8, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(223, 77);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Logo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Motor_Interface_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 648);
            this.Controls.Add(this.groupBox5);
            this.Name = "Motor_Interface_Form";
            this.Text = "Motor Control";
            this.groupBox2.ResumeLayout(false);
            this.Direction.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBar_RPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBar_Torque_Limit)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.NBox_Control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.I_Motor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Torque)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button But_Reverse;
        private System.Windows.Forms.Button But_Forward;
        private System.Windows.Forms.Label LRPM;
        private System.Windows.Forms.Label LMotorSpeed;
        private System.Windows.Forms.Label LBaude;
        private System.Windows.Forms.ComboBox SBox_Ports;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SBox_Baude;
        private System.Windows.Forms.TextBox EBox_RPM;
        private System.Windows.Forms.ProgressBar PBar_Connection;
        private System.Windows.Forms.Label L_Connection;
        private System.Windows.Forms.Button But_Connect;
        private System.Windows.Forms.Button But_Close;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button But_Start;
        private System.Windows.Forms.Button But_Stop;
        private System.Windows.Forms.TrackBar TBar_RPM;
        private System.Windows.Forms.Label L_RPM_MAX;
        private System.Windows.Forms.Label LInLb;
        private System.Windows.Forms.TextBox EBox_Torque_Limit;
        private System.Windows.Forms.Label LTorqueLimit;
        private System.Windows.Forms.TrackBar TBar_Torque_Limit;
        private System.Windows.Forms.Label L_Limit_MIN;
        private System.Windows.Forms.Label L_RPM_MIN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button But_Save_Data;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Torque;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox RBox_Torque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button But_Start_Data;
        private System.Windows.Forms.GroupBox Direction;
        private System.Windows.Forms.Button But_Stop_Data;
        private System.Windows.Forms.GroupBox NBox_Control;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label L_Limit_MAX;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox RBox_Data;
        private System.Windows.Forms.TextBox EBox_CalTorque_O;
        private System.Windows.Forms.TextBox EBox_CalTorque_S;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button But_CalTorque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar PBar_Torque;
        private System.Windows.Forms.PictureBox I_Motor;
        private System.Windows.Forms.Label L_BitReadout;
        private System.Windows.Forms.TextBox RBox_Bit;
    }
}

