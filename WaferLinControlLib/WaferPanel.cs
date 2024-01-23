using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaferLinLib;

namespace WaferLinControlLib
{
    /// <summary>
    /// WaferPanel 클래스 - Wafer를 시각화하는 패널
    /// </summary>
    public class WaferPanel:DPanel
    {
        /// <summary>
        /// Wafer 속성 - 가져오기 및 설정하기
        /// </summary>
        public Wafer Wafer
        {
            get;
            set;
        }
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public WaferPanel()
        {
            this.Paint += WaferPanel_Paint;
        }
        /// <summary>
        /// Paint 이벤트 핸들러 - Wafer의 품질 수준 시각화
        /// </summary>
        /// <param name="sender">이벤트 전송자</param>
        /// <param name="e">이벤트 처리 인자</param>
        private void WaferPanel_Paint(object sender,System.Windows.Forms.PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Brush brush = Brushes.Silver;
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            graphics.FillEllipse(brush, rect);
            int width = Width;
            int height = Height;
            int sx = (int)(width * 0.15);
            int sy = (int)(height * 0.15);
            Rectangle rect2 = new Rectangle(sx, sy, (int)(width * 0.7), (int)(height * 0.7));
            graphics.DrawRectangle(Pens.Red, rect2);
            int xu = rect2.Width / 10;
            int yu = rect2.Height / 10;
            Pen pen = new Pen(Color.DarkGray, 1);
            for (int x = 1; x < 10; x++)
            {
                graphics.DrawLine(pen, new Point(sx + x * xu, sy), new Point(sx + x * xu, sy + rect2.Height));
            }
            for (int y = 1; y < 10; y++)
            {
                graphics.DrawLine(pen, new Point(sx, sy + y * yu), new Point(sx + rect2.Width, sy + y * yu));
            }

            if (Wafer == null)
            {
                return;
            }
            int dir = 0;
            int step = 1, nowstep = step;
            int nx = 4, ny = 5;
            for (int i = 0; i < 100; i++)
            {
                int qual = Wafer[i];
                Color color = Color.FromArgb(200 - qual * 2, 55 + qual * 2, 0);
                Rectangle rt = new Rectangle(sx + nx * xu + 1, sy + ny * yu + 1, xu - 1, yu - 1);
                graphics.FillRectangle(new SolidBrush(color), rt);
                if (nowstep == 0)
                {
                    dir = (dir + 1) % 4;
                    if (dir % 2 == 0)
                    {
                        step++;
                    }
                    nowstep = step;
                }
                nowstep--;
                switch (dir)
                {
                    case 0: ny--; break;
                    case 1: nx++; break;
                    case 2: ny++; break;
                    case 3: nx--; break;
                }
            }
        }
    }
}
