using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp_Egitim
{
    class special_pie_button_1 : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddPie(0, 0, 400, 400, 180, 90);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);
        }
    }
}
