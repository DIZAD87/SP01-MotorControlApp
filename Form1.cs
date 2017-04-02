//System namespaces
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.IO.Ports; // Added for reading arduino I/Os

//MAIN program
    namespace MOTOR_INTERFACE //Interface program
    {//MAIN start bracket
    //FORM program
    public partial class Motor_Interface_Form : Form
    {//FORM start bracket
    //Initiation
        private SerialPort myPort; //Added for serial port review
        private DateTime datetime; //Added for live analog read
        private string data_IN; //Added for specifying the incoming analog data
        private DateTime startTime; //Added for realtime chart
        public Motor_Interface_Form()

        {
            InitializeComponent();
            GetAvailablePorts(); //function to review the ports
            ///Enable/Disable buttons
                But_Connect.Enabled = true;
                But_Close.Enabled = false;
                But_Forward.Enabled = false;
                But_Reverse.Enabled = false;
                But_Start.Enabled = false;
                But_Stop.Enabled = false;
                But_CalTorque.Enabled = false;
                But_Start_Data.Enabled = false;
                But_Stop_Data.Enabled = false;
                But_Save_Data.Enabled = false;
            I_Motor.Enabled = false; //Stop the motor GIF
            startTime = DateTime.Now; //Added for realtime chart
        }

    //Review port availability
        void GetAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            SBox_Ports.Items.AddRange(ports);
        }

    //Receiving data 
    private void Myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
            {
                try
                {
                    data_IN = myPort.ReadLine(); //Read analog signal from port and write to data_IN
                    this.Invoke(new EventHandler(displaydata_event));
                }
                catch (Exception) { MessageBox.Show("Error"); }
            }

    //General and graphical interface commands 
        private void displaydata_event(object sender, EventArgs e)
        {
            //General items
                if (TBar_RPM.Value == 0) { I_Motor.Enabled = false; } //Turn off the motor GIF

            //Display data on the single readout boxes
                double torque_value = (Convert.ToDouble(EBox_CalTorque_S.Text)) * Convert.ToDouble(data_IN)
                + (Convert.ToDouble(EBox_CalTorque_O.Text)); //Convert bit to torque
                RBox_Bit.Text = data_IN;    //Display the bits on the readout box 
                RBox_Torque.Text = Convert.ToString(torque_value);

            //Display data on the central readout box
                datetime = DateTime.Now; //set the datetime variable to the current time
                string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second; //set time
                RBox_Data.AppendText(time + "\t\t" + data_IN + "\n"); //Display data and time on readout box

            //Display the data on the meter
                int integer_data_IN = Convert.ToInt32(data_IN); //Convert the data_IN to an integer
                if (integer_data_IN > PBar_Torque.Maximum)
                    { PBar_Torque.Value = PBar_Torque.Maximum; } //Set max readout limit on progress bar
                else if (integer_data_IN < PBar_Torque.Minimum)
                    { PBar_Torque.Value = PBar_Torque.Minimum; } //Set min readout limit on progress bar
                else { PBar_Torque.Value = integer_data_IN; } //Connect torque progress bar to torque readout
                   
            //Chart code
                TimeSpan sinceStart = DateTime.Now - startTime; //Define var between current and start time

            //Chart graphics
                this.Chart_Torque.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Silver; //Grid line color
                this.Chart_Torque.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot; //Grid line style
                this.Chart_Torque.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot; //Grid line style
                double Chart_XValue = sinceStart.TotalMilliseconds; // datetime.Millisecond

            //Chart XY visual limits
                this.Chart_Torque.ChartAreas[0].AxisY.Minimum = 0; //set the Y axis min values
                this.Chart_Torque.ChartAreas[0].AxisY.Maximum = 6; //set the Y axis max values
                this.Chart_Torque.ChartAreas[0].AxisX.Minimum = Math.Round(sinceStart.TotalMilliseconds - 5000); //set the X axis min values
                this.Chart_Torque.ChartAreas[0].AxisX.Maximum = Math.Round(sinceStart.TotalMilliseconds); //set the X axis max values
                string test = Convert.ToString(torque_value); //double works fine
                this.Chart_Torque.Series["Torque Readout"].Points.AddXY(Chart_XValue, test); //Set plot
                this.Chart_Torque.Series["Torque Readout"].Color = Color.Green; //Change the color of the line

            //Torque Limit Series
                double C_Limit = Convert.ToDouble(EBox_Torque_Limit.Text); //Redundant callout
                this.Chart_Torque.Series["Torque Limit"].Points.AddXY(Chart_XValue, C_Limit); //Set plot
                this.Chart_Torque.Series["Torque Limit"].Color = Color.Orange; //change the color of the line

            //Shut down motor if the torque limit is reached*****
                if (TBar_Torque_Limit.Value < Convert.ToInt32(torque_value))
                    { But_Stop.PerformClick();}//Turn off motor when torque limit is reached
        }

    //Setting default Calibration values
        private void SetDefaultCalibration()
        {
        //change the cal values:
            //0 RPM
                if (TBar_RPM.Value == 0 && TBar_Torque_Limit.Value == 1)
                    { EBox_CalTorque_S.Text = "0.000"; EBox_CalTorque_O.Text = "0.000";}
                if (TBar_RPM.Value == 0 && TBar_Torque_Limit.Value == 2)
                    { EBox_CalTorque_S.Text = "0.000"; EBox_CalTorque_O.Text = "0.000";}
                if (TBar_RPM.Value == 0 && TBar_Torque_Limit.Value == 3)
                    { EBox_CalTorque_S.Text = "0.000"; EBox_CalTorque_O.Text = "0.000";}
                if (TBar_RPM.Value == 0 && TBar_Torque_Limit.Value == 4)
                    { EBox_CalTorque_S.Text = "0.000"; EBox_CalTorque_O.Text = "0.000";}
                if (TBar_RPM.Value == 0 && TBar_Torque_Limit.Value == 5)
                    { EBox_CalTorque_S.Text = "0.000"; EBox_CalTorque_O.Text = "0.000";}
            //10 RPM
                if (TBar_RPM.Value == 1 && TBar_Torque_Limit.Value == 1)
                    { EBox_CalTorque_S.Text = "0.088"; EBox_CalTorque_O.Text = "-25.402";}
                if (TBar_RPM.Value == 1 && TBar_Torque_Limit.Value == 2)
                    { EBox_CalTorque_S.Text = "0.080"; EBox_CalTorque_O.Text = "-24.011";}
                if (TBar_RPM.Value == 1 && TBar_Torque_Limit.Value == 3)
                    { EBox_CalTorque_S.Text = "0.072"; EBox_CalTorque_O.Text = "-22.612";}
                if (TBar_RPM.Value == 1 && TBar_Torque_Limit.Value == 4)
                    { EBox_CalTorque_S.Text = "0.064"; EBox_CalTorque_O.Text = "-21.352";}
                if (TBar_RPM.Value == 1 && TBar_Torque_Limit.Value == 5)
                    { EBox_CalTorque_S.Text = "0.060"; EBox_CalTorque_O.Text = "-19.960";}
            //20 RPM
                if (TBar_RPM.Value == 2 && TBar_Torque_Limit.Value == 1)
                    { EBox_CalTorque_S.Text = "0.069"; EBox_CalTorque_O.Text = "-22.154";}
                if (TBar_RPM.Value == 2 && TBar_Torque_Limit.Value == 2)
                    { EBox_CalTorque_S.Text = "0.064"; EBox_CalTorque_O.Text = "-20.185";}
                if (TBar_RPM.Value == 2 && TBar_Torque_Limit.Value == 3)
                    { EBox_CalTorque_S.Text = "0.059"; EBox_CalTorque_O.Text = "-18.205";}
                if (TBar_RPM.Value == 2 && TBar_Torque_Limit.Value == 4)
                    { EBox_CalTorque_S.Text = "0.054"; EBox_CalTorque_O.Text = "-16.474";}
                if (TBar_RPM.Value == 2 && TBar_Torque_Limit.Value == 5)
                    { EBox_CalTorque_S.Text = "0.051"; EBox_CalTorque_O.Text = "-14.490";}
            //30 RPM
                if (TBar_RPM.Value == 3 && TBar_Torque_Limit.Value == 1)
                    { EBox_CalTorque_S.Text = "0.050"; EBox_CalTorque_O.Text = "-18.965";}
                if (TBar_RPM.Value == 3 && TBar_Torque_Limit.Value == 2)
                    { EBox_CalTorque_S.Text = "0.048"; EBox_CalTorque_O.Text = "-16.558";}
                if (TBar_RPM.Value == 3 && TBar_Torque_Limit.Value == 3)
                    { EBox_CalTorque_S.Text = "0.045"; EBox_CalTorque_O.Text = "-14.137";}
                if (TBar_RPM.Value == 3 && TBar_Torque_Limit.Value == 4)
                    { EBox_CalTorque_S.Text = "0.043"; EBox_CalTorque_O.Text = "-11.720";}
                if (TBar_RPM.Value == 3 && TBar_Torque_Limit.Value == 5)
                    { EBox_CalTorque_S.Text = "0.042"; EBox_CalTorque_O.Text = "-09.305";}
        }

    //Buttons
        //Data buttons
            //Start Data button
                private void But_Start_Data_Click(object sender, EventArgs e)
                    {
                        myPort.Parity = Parity.None; // Added for analog read
                        myPort.DataBits = 8; // Added for analog read
                        myPort.StopBits = StopBits.One; // Added for analog read
                        myPort.DataReceived += Myport_DataReceived; // Added for analog read
                        //Enable/Disable buttons
                            But_Start_Data.Enabled = false;
                            But_Stop_Data.Enabled = true;
                            But_Save_Data.Enabled = false;
                            But_Start.Enabled = true;
                    try
                        {
                            RBox_Data.Text = "";
                            myPort.Open();
                        }
                    catch (Exception) { }
                    }

            //Stop Data button
                private void But_Stop_Data_Click(object sender, EventArgs e)
                    {
                        try
                        {
                            myPort.Close();
                            But_Connect.Enabled = false;
                            But_Close.Enabled = false;
                            But_Forward.Enabled = false;
                            But_Reverse.Enabled = false;
                            But_CalTorque.Enabled = false;
                            But_Start_Data.Enabled = true;
                            But_Stop_Data.Enabled = false;
                            But_Save_Data.Enabled = true;
                        }
                        catch (Exception){MessageBox.Show("Error");}
                    }

            //Save Data button
                private void But_Save_Data_Click(object sender, EventArgs e)
                    {
                        try
                        {
                            string pathfile = @"C:\Users\DIZAD\Desktop\CHAPTER 2 08-12-16\MSME\PROJECT-MECHATRONICS\PROGRAMS\C#\SAVED DATA\";
                            string filename = "TData.txt";
                            System.IO.File.WriteAllText(pathfile + filename, RBox_Data.Text);
                            MessageBox.Show("Data has been saved to: " + pathfile, "Save File");
                        }
                        catch (Exception) { MessageBox.Show("Error"); }
                    }

        //Calibration buttons
            //Torque reset default button
            private void But_CalTorque_Click(object sender, EventArgs e)
                            {
                                try
                                    {
                                        SetDefaultCalibration();
                                    }
                                catch (Exception) { MessageBox.Show("Error"); }
                            }

        //Connection buttons
            //Connect button
                private void But_Connect_Click(object sender, EventArgs e)
                    {
                        try
                        {
                            if (SBox_Baude.Text == "" || SBox_Ports.Text == "") //check for baude/port#
                                {
                                    MessageBox.Show("Fill Baude Rate and Port#.");
                                }
                            else
                                {
                                    myPort = new SerialPort();
                                    myPort.BaudRate = Convert.ToInt32(SBox_Baude.Text);
                                    myPort.PortName = SBox_Ports.Text;
                                    myPort.Open(); //Open the port so the arduino analog signal can be read
                                    PBar_Connection.Value = 100; //Animate the status bar to complete
                                    //Enable/Disable buttons
                                        But_Connect.Enabled = false;
                                        But_Close.Enabled = true;
                                        But_Forward.Enabled = false;
                                        But_Reverse.Enabled = true;
                                        But_Start.Enabled = true;
                                        But_Stop.Enabled = false;
                                        But_CalTorque.Enabled = true;
                                        But_Start_Data.Enabled = false;
                                        But_Stop_Data.Enabled = false;
                                        But_Save_Data.Enabled = false;
                                }
                        }
                        catch (Exception){MessageBox.Show("Error");}
                    }

            //Close button
                private void But_Close_Click(object sender, EventArgs e)
                    {
                        myPort.Close();
                        PBar_Connection.Value = 0;
                        But_Stop.PerformClick();
                        //Enable/Disable buttons
                            But_Connect.Enabled = true;
                            But_Close.Enabled = false;
                            But_Forward.Enabled = false;
                            But_Reverse.Enabled = false;
                            But_Start.Enabled = false;
                            But_Stop.Enabled = false;
                            But_CalTorque.Enabled = false;
                            But_Start_Data.Enabled = false;
                            But_Stop_Data.Enabled = false;
                            But_Save_Data.Enabled = false;
                    }
         
        //Motor control buttons      
            //Reverse button
                private void BReverse_Click(object sender, EventArgs e)
                    {
                        myPort.WriteLine("1");//Energize case 1 of arduino
                        I_Motor.Image = Image.FromFile("C:/Users/DIZAD/Desktop/CHAPTER 2 08-12-16/MSME/PROJECT-MECHATRONICS/PROGRAMS/C#/MOTOR INTERFACE/MOTOR INTERFACE/ELEMENTS/ANIMATIONS/MReverse.gif");
                        //Disable/Enable buttons
                            But_Reverse.Enabled = false;
                            But_Forward.Enabled = true;
                    }
            //Forward button
                private void BForward_Click(object sender, EventArgs e)
                    {
                        myPort.WriteLine("0"); //Energize case 0 of arduino
                        I_Motor.Image = Image.FromFile("C:/Users/DIZAD/Desktop/CHAPTER 2 08-12-16/MSME/PROJECT-MECHATRONICS/PROGRAMS/C#/MOTOR INTERFACE/MOTOR INTERFACE/ELEMENTS/ANIMATIONS/MForward.gif");
                        //Disable/Enable buttons
                            But_Reverse.Enabled = true;
                            But_Forward.Enabled = false;
                    }
            //Motor Stop button
                private void But_Stop_Click(object sender, EventArgs e)
                    {
                        EBox_RPM.Text = "0"; //shut down the motor signal
                        I_Motor.Enabled = false; //stop the motor GIF
                        //Disable/Enable buttons
                            But_Stop.Enabled = false;
                            But_Start.Enabled = true;
                    }
            //Motor Start button
                private void But_Start_Click(object sender, EventArgs e)
                    {
                    //Send the speed requires to the Arduino
                        if (TBar_RPM.Value == 0) {myPort.WriteLine("2");} //speed 0 -> 0 RPM
                        if (TBar_RPM.Value == 1) {myPort.WriteLine("3");} //speed 1 -> 10 RPM
                        if (TBar_RPM.Value == 2) {myPort.WriteLine("4");} //speed 2 -> 20 RPM
                        if (TBar_RPM.Value == 3) {myPort.WriteLine("5");} //speed 3 -> 30 RPM
                    //Enable buttons as needed
                        But_Stop.Enabled = true;
                        But_Start.Enabled = false;
                        But_Start_Data.Enabled = true;
                        But_Stop_Data.Enabled = false;
                    //Other
                        if (TBar_RPM.Value > 0){ I_Motor.Enabled = true;} //if motor speed> 0, play motor GIF
                    }

    //Entry boxes and meters
        //RPM entry box
            private void EBox_RPM_TextChanged(object sender, EventArgs e)
            {
                try
                {
                    //Prevent from entering a value higher than the label max value
                    if (Convert.ToInt32(EBox_RPM.Text) > Convert.ToInt32(L_RPM_MAX.Text))
                    {
                        EBox_RPM.Text = L_RPM_MAX.Text;
                        MessageBox.Show("Entry is limited to label max value.");
                    }
                    //Prevent from entering a value lower than the label min value
                    if (Convert.ToInt32(EBox_RPM.Text) < Convert.ToInt32(L_RPM_MIN.Text))
                    {
                        EBox_RPM.Text = L_RPM_MIN.Text;
                        MessageBox.Show("Entry is limited to label min value.");
                    }
                    //Value Conversion
                        int C_RPM = Convert.ToInt32(EBox_RPM.Text);
                        TBar_RPM.Value = C_RPM;
                        SetDefaultCalibration();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Entry: Enter positive integers only");
                }
            }
        //RPM meter
            private void TBar_RPM_Scroll(object sender, EventArgs e)
            {
                EBox_RPM.Text = Convert.ToString(TBar_RPM.Value);
            }
        //Torque limit entry box
            private void EBox_Torque_Limit_TextChanged(object sender, EventArgs e)
            {
                try
                {
                    //Prevent someone from entering a value higher than the label max value
                    if (Convert.ToInt32(EBox_Torque_Limit.Text) > Convert.ToInt32(L_Limit_MAX.Text))
                    {
                        MessageBox.Show("Entry is limited to label max value.");
                        EBox_Torque_Limit.Text = L_Limit_MAX.Text;
                    }
                    //Prevent someone from entering a value lower than the label min value
                    if (Convert.ToInt32(EBox_Torque_Limit.Text) < Convert.ToInt32(L_Limit_MIN.Text))
                    {
                        EBox_Torque_Limit.Text = L_Limit_MIN.Text;
                        MessageBox.Show("Entry is limited to label min value.");
                    }
                    //convert value to an integer
                        int C_Limit = Convert.ToInt32(EBox_Torque_Limit.Text);
                        TBar_Torque_Limit.Value = C_Limit;
                        SetDefaultCalibration(); //reset the calibration values
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Entry: Enter positive integers only");
                }
            }
        //Torque limit meter
            private void TBar_Torque_Limit_Scroll(object sender, EventArgs e)
            {
                EBox_Torque_Limit.Text = Convert.ToString(TBar_Torque_Limit.Value);
            }
            }//FORM end bracket
    }//MAIN end bracket
