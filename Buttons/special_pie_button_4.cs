using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp_Egitim
{
    class special_pie_button_4 : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddPie(0, -200, 400, 400, 90, 90);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);
        }
    }
}
