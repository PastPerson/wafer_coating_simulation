
namespace wafer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.pn = new System.Windows.Forms.Panel();
            this.tm_coating = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(146, 36);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pn
            // 
            this.pn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn.Location = new System.Drawing.Point(84, 117);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(200, 200);
            this.pn.TabIndex = 1;
            this.pn.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_wafer_Paint);
            // 
            // tm_coating
            // 
            this.tm_coating.Tick += new System.EventHandler(this.tm_coating_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 394);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "wafer simulator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Timer tm_coating;
    }
}

