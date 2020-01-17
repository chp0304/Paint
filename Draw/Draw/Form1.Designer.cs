namespace Draw
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.直线 = new System.Windows.Forms.ToolStripButton();
            this.椭圆 = new System.Windows.Forms.ToolStripButton();
            this.清除 = new System.Windows.Forms.ToolStripButton();
            this.实心矩形 = new System.Windows.Forms.ToolStripButton();
            this.实心圆形 = new System.Windows.Forms.ToolStripButton();
            this.矩形 = new System.Windows.Forms.ToolStripButton();
            this.铅笔 = new System.Windows.Forms.ToolStripButton();
            this.橡皮 = new System.Windows.Forms.ToolStripButton();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(241, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 317);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.直线,
            this.椭圆,
            this.清除,
            this.实心矩形,
            this.实心圆形,
            this.矩形,
            this.铅笔,
            this.橡皮});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(13, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(82, 154);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // 直线
            // 
            this.直线.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.直线.Image = ((System.Drawing.Image)(resources.GetObject("直线.Image")));
            this.直线.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.直线.Name = "直线";
            this.直线.Size = new System.Drawing.Size(24, 24);
            this.直线.Text = "直线";
            this.直线.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // 椭圆
            // 
            this.椭圆.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.椭圆.Image = ((System.Drawing.Image)(resources.GetObject("椭圆.Image")));
            this.椭圆.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.椭圆.Name = "椭圆";
            this.椭圆.Size = new System.Drawing.Size(24, 24);
            this.椭圆.Text = "椭圆";
            this.椭圆.Click += new System.EventHandler(this.椭圆_Click);
            // 
            // 清除
            // 
            this.清除.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.清除.Image = ((System.Drawing.Image)(resources.GetObject("清除.Image")));
            this.清除.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.清除.Name = "清除";
            this.清除.Size = new System.Drawing.Size(24, 24);
            this.清除.Text = "清除";
            this.清除.Click += new System.EventHandler(this.清除_Click);
            // 
            // 实心矩形
            // 
            this.实心矩形.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.实心矩形.Image = ((System.Drawing.Image)(resources.GetObject("实心矩形.Image")));
            this.实心矩形.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.实心矩形.Name = "实心矩形";
            this.实心矩形.Size = new System.Drawing.Size(24, 24);
            this.实心矩形.Text = "实心矩形";
            this.实心矩形.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // 实心圆形
            // 
            this.实心圆形.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.实心圆形.Image = ((System.Drawing.Image)(resources.GetObject("实心圆形.Image")));
            this.实心圆形.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.实心圆形.Name = "实心圆形";
            this.实心圆形.Size = new System.Drawing.Size(24, 24);
            this.实心圆形.Text = "实心圆形";
            this.实心圆形.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // 矩形
            // 
            this.矩形.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.矩形.Image = ((System.Drawing.Image)(resources.GetObject("矩形.Image")));
            this.矩形.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.矩形.Name = "矩形";
            this.矩形.Size = new System.Drawing.Size(24, 24);
            this.矩形.Text = "矩形";
            this.矩形.Click += new System.EventHandler(this.矩形_Click);
            // 
            // 铅笔
            // 
            this.铅笔.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.铅笔.Image = ((System.Drawing.Image)(resources.GetObject("铅笔.Image")));
            this.铅笔.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.铅笔.Name = "铅笔";
            this.铅笔.Size = new System.Drawing.Size(24, 24);
            this.铅笔.Text = "铅笔";
            this.铅笔.Click += new System.EventHandler(this.铅笔_Click);
            // 
            // 橡皮
            // 
            this.橡皮.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.橡皮.Image = ((System.Drawing.Image)(resources.GetObject("橡皮.Image")));
            this.橡皮.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.橡皮.Name = "橡皮";
            this.橡皮.Size = new System.Drawing.Size(24, 24);
            this.橡皮.Text = "橡皮";
            this.橡皮.Click += new System.EventHandler(this.橡皮_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 27);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 直线;
        private System.Windows.Forms.ToolStripButton 矩形;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolStripButton 椭圆;
        private System.Windows.Forms.ToolStripButton 清除;
        private System.Windows.Forms.ToolStripButton 实心矩形;
        private System.Windows.Forms.ToolStripButton 实心圆形;
        private System.Windows.Forms.ToolStripButton 铅笔;
        private System.Windows.Forms.ToolStripButton 橡皮;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

