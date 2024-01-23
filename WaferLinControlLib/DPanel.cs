using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WaferLinControlLib
{
    /// <summary>
    /// 더블 버퍼링 스타일을 지정한 패널 클래스
    /// </summary>
    public class DPanel : Panel
    {
        /// <summary>
        /// 기본 생성자(더블 버퍼링 가능하게 스타일 지정하였음)
        /// </summary>
        public DPanel()
        {
            SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer |
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }
    }
}
