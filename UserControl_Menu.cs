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
    public partial class UserControl_Menu : UserControl
    {
        public UserControl_Menu()
        {
            InitializeComponent();
        }

        private void special_pie_button_11_Click(object sender, EventArgs e)
        {
            Form1.baglan = true;
        }

        private void special_pie_button_21_Click(object sender, EventArgs e)
        {
            Form1.section = 1;
        }

        private void special_pie_button_41_Click(object sender, EventArgs e)
        {
            Form1.section = 2;
        }

        private void special_pie_button_31_Click(object sender, EventArgs e)
        {
            Form1.section = 3;
        }
    }
}
