namespace WindowsFormsApp_Egitim
{
    partial class UserControl_Veri
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Veri));
            this.button1 = new System.Windows.Forms.Button();
            this.winChartViewer1 = new ChartDirector.WinChartViewer();
            this.trackLine2Enable = new System.Windows.Forms.CheckBox();
            this.trackLine1Enable = new System.Windows.Forms.CheckBox();
            this.pointerPB = new System.Windows.Forms.RadioButton();
            this.zoomInPB = new System.Windows.Forms.RadioButton();
            this.zoomOutPB = new System.Windows.Forms.RadioButton();
            this.dataRateTimer = new System.Windows.Forms.Timer(this.components);
            this.chartUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.timer_takedata = new System.Windows.Forms.Timer(this.components);
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.winChartViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(819, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ana Menü";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // winChartViewer1
            // 
            this.winChartViewer1.Location = new System.Drawing.Point(175, 30);
            this.winChartViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.winChartViewer1.Name = "winChartViewer1";
            this.winChartViewer1.Size = new System.Drawing.Size(512, 288);
            this.winChartViewer1.TabIndex = 29;
            this.winChartViewer1.TabStop = false;
            this.winChartViewer1.MouseMovePlotArea += new System.Windows.Forms.MouseEventHandler(this.winChartViewer1_MouseMovePlotArea);
            this.winChartViewer1.ViewPortChanged += new ChartDirector.WinViewPortEventHandler(this.winChartViewer1_ViewPortChanged);
            // 
            // trackLine2Enable
            // 
            this.trackLine2Enable.AutoSize = true;
            this.trackLine2Enable.Checked = true;
            this.trackLine2Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackLine2Enable.Location = new System.Drawing.Point(366, 344);
            this.trackLine2Enable.Margin = new System.Windows.Forms.Padding(0);
            this.trackLine2Enable.Name = "trackLine2Enable";
            this.trackLine2Enable.Size = new System.Drawing.Size(65, 17);
            this.trackLine2Enable.TabIndex = 44;
            this.trackLine2Enable.Text = "Cursor 2";
            this.trackLine2Enable.UseVisualStyleBackColor = true;
            this.trackLine2Enable.CheckedChanged += new System.EventHandler(this.trackLineEnable_CheckedChanged);
            // 
            // trackLine1Enable
            // 
            this.trackLine1Enable.AutoSize = true;
            this.trackLine1Enable.Checked = true;
            this.trackLine1Enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackLine1Enable.Location = new System.Drawing.Point(275, 344);
            this.trackLine1Enable.Margin = new System.Windows.Forms.Padding(0);
            this.trackLine1Enable.Name = "trackLine1Enable";
            this.trackLine1Enable.Size = new System.Drawing.Size(65, 17);
            this.trackLine1Enable.TabIndex = 43;
            this.trackLine1Enable.Text = "Cursor 1";
            this.trackLine1Enable.UseVisualStyleBackColor = true;
            this.trackLine1Enable.CheckedChanged += new System.EventHandler(this.trackLineEnable_CheckedChanged);
            // 
            // pointerPB
            // 
            this.pointerPB.Appearance = System.Windows.Forms.Appearance.Button;
            this.pointerPB.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pointerPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointerPB.Image = ((System.Drawing.Image)(resources.GetObject("pointerPB.Image")));
            this.pointerPB.Location = new System.Drawing.Point(174, 338);
            this.pointerPB.Margin = new System.Windows.Forms.Padding(0);
            this.pointerPB.Name = "pointerPB";
            this.pointerPB.Size = new System.Drawing.Size(30, 30);
            this.pointerPB.TabIndex = 40;
            this.pointerPB.CheckedChanged += new System.EventHandler(this.pointerPB_CheckedChanged);
            // 
            // zoomInPB
            // 
            this.zoomInPB.Appearance = System.Windows.Forms.Appearance.Button;
            this.zoomInPB.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.zoomInPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomInPB.Image = ((System.Drawing.Image)(resources.GetObject("zoomInPB.Image")));
            this.zoomInPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zoomInPB.Location = new System.Drawing.Point(203, 338);
            this.zoomInPB.Margin = new System.Windows.Forms.Padding(0);
            this.zoomInPB.Name = "zoomInPB";
            this.zoomInPB.Size = new System.Drawing.Size(30, 30);
            this.zoomInPB.TabIndex = 41;
            this.zoomInPB.CheckedChanged += new System.EventHandler(this.zoomInPB_CheckedChanged);
            // 
            // zoomOutPB
            // 
            this.zoomOutPB.Appearance = System.Windows.Forms.Appearance.Button;
            this.zoomOutPB.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.zoomOutPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomOutPB.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutPB.Image")));
            this.zoomOutPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.zoomOutPB.Location = new System.Drawing.Point(232, 338);
            this.zoomOutPB.Margin = new System.Windows.Forms.Padding(0);
            this.zoomOutPB.Name = "zoomOutPB";
            this.zoomOutPB.Size = new System.Drawing.Size(30, 30);
            this.zoomOutPB.TabIndex = 42;
            this.zoomOutPB.CheckedChanged += new System.EventHandler(this.zoomOutPB_CheckedChanged);
            // 
            // dataRateTimer
            // 
            this.dataRateTimer.Enabled = true;
            this.dataRateTimer.Interval = 1000;
            this.dataRateTimer.Tick += new System.EventHandler(this.dataRateTimer_Tick);
            // 
            // chartUpdateTimer
            // 
            this.chartUpdateTimer.Enabled = true;
            this.chartUpdateTimer.Interval = 1000;
            this.chartUpdateTimer.Tick += new System.EventHandler(this.chartUpdateTimer_Tick);
            // 
            // timer_takedata
            // 
            this.timer_takedata.Tick += new System.EventHandler(this.timer_takedata_Tick);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.BackColor = System.Drawing.Color.White;
            this.hScrollBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hScrollBar1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hScrollBar1.Location = new System.Drawing.Point(175, 318);
            this.hScrollBar1.Maximum = 1000000000;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(512, 20);
            this.hScrollBar1.TabIndex = 45;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // UserControl_Veri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.trackLine2Enable);
            this.Controls.Add(this.trackLine1Enable);
            this.Controls.Add(this.pointerPB);
            this.Controls.Add(this.zoomInPB);
            this.Controls.Add(this.zoomOutPB);
            this.Controls.Add(this.winChartViewer1);
            this.Controls.Add(this.button1);
            this.Name = "UserControl_Veri";
            this.Size = new System.Drawing.Size(894, 541);
            this.Load += new System.EventHandler(this.UserControl_Veri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.winChartViewer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ChartDirector.WinChartViewer winChartViewer1;
        private System.Windows.Forms.CheckBox trackLine2Enable;
        private System.Windows.Forms.CheckBox trackLine1Enable;
        private System.Windows.Forms.RadioButton pointerPB;
        private System.Windows.Forms.RadioButton zoomInPB;
        private System.Windows.Forms.RadioButton zoomOutPB;
        internal System.Windows.Forms.Timer dataRateTimer;
        internal System.Windows.Forms.Timer chartUpdateTimer;
        private System.Windows.Forms.Timer timer_takedata;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}
