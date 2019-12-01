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

namespace WindowsFormsApp_Egitim
{
    public partial class Form1 : Form
    {
        public static UserControl_Menu ucmenu = new UserControl_Menu();
        public static UserControl_Kontrol uckontrol = new UserControl_Kontrol();
        public static UserControl_Veri ucveri = new UserControl_Veri();
        public static UserControl_Log uclog = new UserControl_Log();


        public static byte section = 0;
        public static byte last_section = 0;

        bool buyuk = false;
        public static bool baglan = false;

        public static float Motor_Devir = 0, Motor_Sicaklik = 0, Motor_Yuk = 0, Anlık_Yakıt = 0;
        public static byte Hata = 0;

        int BYTE = 11;
        byte[] temp = new byte[200];
        byte[] ConvertionBuffer = new byte[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            panel_usercontrol.Controls.Add(ucmenu);
            panel_usercontrol.Controls.Add(uckontrol);
            panel_usercontrol.Controls.Add(ucveri);
            panel_usercontrol.Controls.Add(uclog);
            ucmenu.Dock = DockStyle.Fill;
            uckontrol.Dock = DockStyle.Fill;
            ucveri.Dock = DockStyle.Fill;
            uclog.Dock = DockStyle.Fill;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(buyuk == false)
            {
                buyuk = true;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                buyuk = false;
                this.WindowState = FormWindowState.Normal;
            }
            
        }
        void AddControlsToPanel(Control c)
        {
            panel_usercontrol.Controls.SetChildIndex(c, 0);
        }

        private void toolStripComboBox1_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            toolStripComboBox1.Items.AddRange(ports);
        }

        private void main_timer_Tick(object sender, EventArgs e)
        {
            connect(baglan);
            Current_Section(section);
        }

        void Current_Section(byte section)
        {
            if(!(section == last_section))
            {
               last_section = section;
               switch (section)
                {
                    case 0:
                        AddControlsToPanel(ucmenu);
                        break;
                    case 1:
                        AddControlsToPanel(uckontrol);
                        break;
                    case 2:
                        AddControlsToPanel(ucveri);
                        break;
                    case 3:
                        AddControlsToPanel(uclog);
                        break;
                }
            }
        }
        void connect(bool state)
        {
            if(state == true && !serialPort.IsOpen)
            {
                try
                {
                    serialPort.PortName = toolStripComboBox1.Text;
                    serialPort.BaudRate = 9600;
                    serialPort.DataBits = 8;
                    //serialPort.Open();
                    toolStripTextBox1.Text = "Bağlantı Yapıldı";

                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                if (serialPort.IsOpen && toolStripTextBox1.Text == "Bağlantı Yapıldı")
                {
                    //serialPort.Close();
                    toolStripTextBox1.Text = "Baglantı Yok";
                }
            }
        
        }
        
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort.BytesToRead <= BYTE - 2) ;

            serialPort.Read(temp, 0, BYTE - 2);

            //Hata
            Hata = temp[0];  

            //Motor_Devir
            ConvertionBuffer[0] = temp[1];  
            ConvertionBuffer[1] = temp[2];  
            Motor_Devir = BitConverter.ToInt16(ConvertionBuffer, 0) / 100.0f;

            //Motor_Sicaklik
            ConvertionBuffer[0] = temp[3];  
            ConvertionBuffer[1] = temp[4];  
            Motor_Sicaklik = BitConverter.ToInt16(ConvertionBuffer, 0) / 100.0f;

            //Motor_Yuk
            ConvertionBuffer[0] = temp[5];  
            ConvertionBuffer[1] = temp[6]; 
            Motor_Yuk = BitConverter.ToInt16(ConvertionBuffer, 0);

            //Anlık_Yakıt
            ConvertionBuffer[0] = temp[7]; 
            ConvertionBuffer[1] = temp[8]; 
            Anlık_Yakıt = BitConverter.ToInt16(ConvertionBuffer, 0);
        }
    }
}
