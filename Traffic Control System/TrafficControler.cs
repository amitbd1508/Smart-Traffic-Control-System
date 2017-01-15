using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Control_System
{

    public partial class Main : Form
    {
        public string recieveStatus="R1$R2$R3$R4$R5$R6$R7$";
        
        public int n=6;
        public Main()
        {
            InitializeComponent();
            lblEmaRoad.Text = "No Emargency";
            richTextBox1.Hide();
            ini();
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            //port.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

       

     
        private void ini()
        {
            controlToolStripMenuItem.Enabled = false;
            string[] ports = SerialPort.GetPortNames();

            cmbConnect.Items.AddRange(ports);

            pnlLight1_red.BackColor = Color.Gray;
            pnlLight2_red.BackColor = Color.Gray;
            pnlLight3_red.BackColor = Color.Gray;
            pnlLight4_red.BackColor = Color.Gray;
            pnlLight5_red.BackColor = Color.Gray;
            pnlLight6_red.BackColor = Color.Gray;

            pnlLight1_green.BackColor = Color.Gray;
            pnlLight2_green.BackColor = Color.Gray;
            pnlLight3_green.BackColor = Color.Gray;
            pnlLight4_green.BackColor = Color.Gray;
            pnlLight5_green.BackColor = Color.Gray;
            pnlLight6_green.BackColor = Color.Gray;

            pnlLight1_yellow.BackColor = Color.Gray;
            pnlLight2_yellow.BackColor = Color.Gray;
            pnlLight3_yellow.BackColor = Color.Gray;
            pnlLight4_yellow.BackColor = Color.Gray;
            pnlLight5_yellow.BackColor = Color.Gray;
            pnlLight6_yellow.BackColor = Color.Gray;


            lbl.Visible = false;

            
            btn1.BackColor = Color.Red;
            btn2.BackColor = Color.Red;
            btn3.BackColor = Color.Red;
            btn4.BackColor = Color.Red;
            btn5.BackColor = Color.Red;
            btn6.BackColor = Color.Red;
            btne.BackColor = Color.Red;
            


        }
        

        
        private void openPort()
        {
            try
            {
                
                
                if (!serialPort1.IsOpen)
                {
                    
                    serialPort1.PortName = cmbConnect.SelectedItem.ToString();
                    serialPort1.BaudRate = Convert.ToInt32(txtBUD.Text.ToString());
                    serialPort1.Open();
                    
                    
                }
                    
                
            }
            catch
            {
                
                MessageBox.Show("Serial port Problem");
                
                
            }
            
        }

        public void upadateLightStatus()
        {
           // Refresh();
            try {
                recieveStatus = serialPort1.ReadLine();
            }
            catch(Exception)
            {
                this.Dispose();
            }
            
            //lbl.Text = recieveStatus;
            Invoke(new Action(() => richTextBox1.AppendText(recieveStatus)));
            string[] temp = recieveStatus.Split('$');
            string s="";
            for (int j = 0; j < temp.Length;j++ )
            {
                 s=s+temp[j]+" ";
            }
            //lbl.Text="\n=="+s;
                for (int i = 0; i < temp.Length; i++)
                {

                    //light 1
                    if (temp[i] == "R1")
                    {

                        pnlLight1_green.BackColor = Color.Gray;
                        pnlLight1_yellow.BackColor = Color.Gray;
                        pnlLight1_red.BackColor = Color.Red;
                    }
                    if (temp[i] == "Y1")
                    {
                        pnlLight1_red.BackColor = Color.Gray;
                        pnlLight1_green.BackColor = Color.Gray;
                        pnlLight1_yellow.BackColor = Color.Yellow;


                    }
                    if (temp[i] == "G1")
                    {

                        pnlLight1_red.BackColor = Color.Gray;

                        pnlLight1_yellow.BackColor = Color.Gray;
                        pnlLight1_green.BackColor = Color.Green;
                    }

                    //light 2
                    if (temp[i] == "R2")
                    {



                        pnlLight2_green.BackColor = Color.Gray;
                        pnlLight2_yellow.BackColor = Color.Gray;
                        pnlLight2_red.BackColor = Color.Red;

                    }
                    if (temp[i] == "Y2")
                    {

                        pnlLight2_red.BackColor = Color.Gray;
                        pnlLight2_green.BackColor = Color.Gray;
                        pnlLight2_yellow.BackColor = Color.Yellow;
                    }
                    if (temp[i] == "G2")
                    {

                        pnlLight2_red.BackColor = Color.Gray;

                        pnlLight2_yellow.BackColor = Color.Gray;
                        pnlLight2_green.BackColor = Color.Green;
                    }



                    //light 3
                    if (temp[i] == "R3")
                    {



                        pnlLight3_green.BackColor = Color.Gray;
                        pnlLight3_yellow.BackColor = Color.Gray;
                        pnlLight3_red.BackColor = Color.Red;

                    }
                    if (temp[i] == "Y3")
                    {

                        pnlLight3_red.BackColor = Color.Gray;
                        pnlLight3_green.BackColor = Color.Gray;
                        pnlLight3_yellow.BackColor = Color.Yellow;
                    }
                    if (temp[i] == "G3")
                    {

                        pnlLight3_red.BackColor = Color.Gray;

                        pnlLight3_yellow.BackColor = Color.Gray;
                        pnlLight3_green.BackColor = Color.Green;
                    }




                    //light 4
                    if (temp[i] == "R4")
                    {



                        pnlLight4_green.BackColor = Color.Gray;
                        pnlLight4_yellow.BackColor = Color.Gray;
                        pnlLight4_red.BackColor = Color.Red;

                    }
                    if (temp[i] == "Y4")
                    {

                        pnlLight4_red.BackColor = Color.Gray;
                        pnlLight4_green.BackColor = Color.Gray;
                        pnlLight4_yellow.BackColor = Color.Yellow;
                    }
                    if (temp[i] == "G4")
                    {

                        pnlLight4_red.BackColor = Color.Gray;

                        pnlLight4_yellow.BackColor = Color.Gray;
                        pnlLight4_green.BackColor = Color.Green;
                    }

                    //light 5
                    if (temp[i] == "R5")
                    {



                        pnlLight5_green.BackColor = Color.Gray;
                        pnlLight5_yellow.BackColor = Color.Gray;
                        pnlLight5_red.BackColor = Color.Red;

                    }
                    if (temp[i] == "Y5")
                    {

                        pnlLight5_red.BackColor = Color.Gray;
                        pnlLight5_green.BackColor = Color.Gray;
                        pnlLight5_yellow.BackColor = Color.Yellow;
                    }
                    if (temp[i] == "G5")
                    {

                        pnlLight5_red.BackColor = Color.Gray;

                        pnlLight5_yellow.BackColor = Color.Gray;
                        pnlLight5_green.BackColor = Color.Green;
                    }
                    //light 6
                    if (temp[i] == "R6")
                    {



                        pnlLight6_green.BackColor = Color.Gray;
                        pnlLight6_yellow.BackColor = Color.Gray;
                        pnlLight6_red.BackColor = Color.Red;

                    }
                    if (temp[i] == "Y6")
                    {

                        pnlLight6_red.BackColor = Color.Gray;
                        pnlLight6_green.BackColor = Color.Gray;
                        pnlLight6_yellow.BackColor = Color.Yellow;
                    }
                    if (temp[i] == "G6")
                    {

                        pnlLight6_red.BackColor = Color.Gray;

                        pnlLight6_yellow.BackColor = Color.Gray;
                        pnlLight6_green.BackColor = Color.Green;
                    }
                    if (temp[i] == "E")
                    {
                        //lblEmaRoad.Text = "Emargency Alart";
                        Invoke(new Action(() => lblEmaRoad.Text = "Emargency Alart"));
                        pnlEmargency.BackColor = Color.Red;
                        
                    }
                    if (temp[i] == "D")
                    {
                        //lblEmaRoad.Text = " No Emargency Alart";
                        Invoke(new Action(() => lblEmaRoad.Text = "No Emargency Alart"));
                        pnlEmargency.BackColor = Color.Green;
                    }

                    
                   


                }


            

        }

      

     

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(btnConnect.Text=="Connect")
            {
                btnConnect.Text = "Disconnect";
            }
            else
            {
                btnConnect.Text = "Connect";
                
               
                
                
                
            }


            if(txtBUD.Text.ToString()!=""&& cmbConnect.Text.ToString()!="Select COM Port")

                openPort();


            else
            {
                
            }

        }

        public List<string> GetAllPorts()
        {
            List<string> allPorts = new List<string>();
            foreach(string port in SerialPort.GetPortNames())
            {
                allPorts.Add(port);
            }



            return allPorts;
        }

        private void txtBUD_Enter(object sender, EventArgs e)
        {
            txtBUD.Text = "";
        }

        private void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            upadateLightStatus();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            if (btn2.BackColor==Color.Red)
            {
                btn2.Image = Traffic_Control_System.Properties.Resources.onBtn;
                btn2.BackColor = Color.Green;
            }
                //MessageBox.Show("fdssd");
                
            else if(btn2.BackColor==Color.Green)
            {
                btn2.Image = Traffic_Control_System.Properties.Resources.offbtn;
                btn2.BackColor = Color.Red;
            }
        }

        private void hideConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lbl.Visible)
            {
                lbl.Visible = false;
                hideConsoleToolStripMenuItem.Text = "Show Console";
                richTextBox1.Hide();
            }
            else
            {
                lbl.Visible = true;
                hideConsoleToolStripMenuItem.Text = "Hide Console";
                
                richTextBox1.Show();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.BackColor == Color.Red)
            {
                btn1.Image = Traffic_Control_System.Properties.Resources.onBtn;
                btn1.BackColor = Color.Green;
            }
            //MessageBox.Show("fdssd");

            else if (btn1.BackColor == Color.Green)
            {
                btn1.Image = Traffic_Control_System.Properties.Resources.offbtn;
                btn1.BackColor = Color.Red;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.BackColor == Color.Red)
            {
                btn3.Image = Traffic_Control_System.Properties.Resources.onBtn;
                btn3.BackColor = Color.Green;
            }
            //MessageBox.Show("fdssd");

            else if (btn3.BackColor == Color.Green)
            {
                btn3.Image = Traffic_Control_System.Properties.Resources.offbtn;
                btn3.BackColor = Color.Red;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.BackColor == Color.Red)
            {
                btn4.Image = Traffic_Control_System.Properties.Resources.onBtn;
                btn4.BackColor = Color.Green;
            }
            //MessageBox.Show("fdssd");

            else if (btn4.BackColor == Color.Green)
            {
                btn4.Image = Traffic_Control_System.Properties.Resources.offbtn;
                btn4.BackColor = Color.Red;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.BackColor == Color.Red)
            {
                btn5.Image = Traffic_Control_System.Properties.Resources.onBtn;
                btn5.BackColor = Color.Green;
            }
            //MessageBox.Show("fdssd");

            else if (btn5.BackColor == Color.Green)
            {
                btn5.Image = Traffic_Control_System.Properties.Resources.offbtn;
                btn5.BackColor = Color.Red;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.BackColor == Color.Red)
            {
                btn6.Image = Traffic_Control_System.Properties.Resources.onBtn;
                btn6.BackColor = Color.Green;
            }
            //MessageBox.Show("fdssd");

            else if (btn6.BackColor == Color.Green)
            {
                btn6.Image = Traffic_Control_System.Properties.Resources.offbtn;
                btn6.BackColor = Color.Red;
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (btne.BackColor == Color.Red)
            {
                btne.Image = Traffic_Control_System.Properties.Resources.onBtn;
                btne.BackColor = Color.Green;
            }
            //MessageBox.Show("fdssd");

            else if (btne.BackColor == Color.Green)
            {
                btne.Image = Traffic_Control_System.Properties.Resources.offbtn;
                btne.BackColor = Color.Red;
            }
        }






       

    }
}
