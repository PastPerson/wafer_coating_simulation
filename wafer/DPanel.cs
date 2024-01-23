using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//더블 버퍼링을 구현하기 위한 클래스

namespace wafer
{
   public class DPanel:Panel
    {
        public DPanel()
        {
            SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer |
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }
    }
}
