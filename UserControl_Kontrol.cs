using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Egitim
{
    public partial class UserControl_Kontrol : UserControl
    {
        string[] motorkontrol = new string[20];
        byte c = 0;

        public UserControl_Kontrol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.section = 0;
        }

        private void timer_update_Tick(object sender, EventArgs e)
        {
            if (c == 4)    timer_update.Stop();
            richTextBox1.Text += motorkontrol[c] + "\n";
            c++;
        }
       
        private void UserControl_Kontrol_Load(object sender, EventArgs e)
        {
            motorkontrol[0] = "Subaru Impreza --> Bağlanıyor";
            motorkontrol[1] = "...";
            motorkontrol[2] = "Subaru Impreza --> Bağlandı";
            motorkontrol[3] = "Motor Devri     : 998";
            motorkontrol[4] = "Motor Sıcaklığı : 70 C ";
            motorkontrol[5] = "!! Sol ön teker basıncı düşük";
            motorkontrol[6] = "OK Turbo Basıncı ";
            motorkontrol[7] = "OK Direksiyon Hidrolik";
            motorkontrol[8] = "OK Soğutma Sıvı Seviyesi";
            motorkontrol[9] = "OK Cam Suyu Seviyesi";
            motorkontrol[10] = "!! Yağ basıncı düşük";
            motorkontrol[11] = "OK Akü Sarj";
            motorkontrol[12] = "OK Fren Hidroliği";
            motorkontrol[13] = "!! Arka Stop Işığı Volaj Düşük";
            motorkontrol[14] = "OK Güvenlik Sistemleri ";

        }

        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox1.AppendText(richTextBox2.Text + "\n");
                richTextBox1.AppendText(motorkontrol[c] + "\n");
                richTextBox1.ScrollToCaret();
                richTextBox2.Text = "";
                c++;
            }
            
        }

    }
}
