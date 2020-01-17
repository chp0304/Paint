using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Drawing : UserControl
    {
        DrawTools dt;
        private string type;
        Bitmap bmp;
        private bool flag = false;
        public Drawing()
        {
            InitializeComponent();
        }

        private void Drawing_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(pictureBox1.BackColor),new Rectangle(0,0,pictureBox1.Width,pictureBox1.Height));
            g.Dispose();
            dt = new DrawTools(pictureBox1.CreateGraphics(),bmp);
            pictureBox1.MouseDown += new MouseEventHandler(this.pic_MouseDown);
            pictureBox1.MouseMove += new MouseEventHandler(this.pic_MouseMove);
            pictureBox1.MouseUp += new MouseEventHandler(this.pic_MouseUp);
            pictureBox1.MouseWheel += new MouseEventHandler(this.pic_MouseWheel);
            button1.MouseDown += new MouseEventHandler(this.b1_MouseDown);
            button1.MouseMove += new MouseEventHandler(this.b1_MouseMove);
            button1.MouseUp += new MouseEventHandler(this.b1_MouseUp);
            button3.MouseDown += new MouseEventHandler(this.b3_MouseDown);
            button3.MouseMove += new MouseEventHandler(this.b3_MouseMove);
            button3.MouseUp += new MouseEventHandler(this.b3_MouseUp);
            button4.MouseDown += new MouseEventHandler(this.b4_MouseDown);
            button4.MouseMove += new MouseEventHandler(this.b4_MouseMove);
            button4.MouseUp += new MouseEventHandler(this.b4_MouseUp);
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            dt.startp = new PointF(e.X, e.Y);
            dt.flag = true;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            dt.EndDraw();

        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
            //String tipText = String.Format("({0}, {1})", e.X, e.Y);
            //toolTip1.Show(tipText,pictureBox1,e.Location);
            if (dt.flag)
            {
                switch (type)
                {
                    case "铅笔":
                        dt.DrawPencil(e);
                        break;
                    case "橡皮":
                        dt.Eraser(e);
                        break;
                    default:
                        dt.Draw(e, type);
                        break;
                }
            }

        }


        private void pic_MouseWheel(object sender, MouseEventArgs e)//画笔粗细
        {
            dt.PenSize(e);
        }

        private void 铅笔_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            type = tsb.Name;
            pictureBox1.Cursor = Cursors.Cross;
        }

        private void 橡皮_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            type = tsb.Name;
            pictureBox1.Cursor = new Cursor(Application.StartupPath + @"\\pb.cur");//相对路径
        }

        private void 直线_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            type = tsb.Name;
            pictureBox1.Cursor = Cursors.Cross;
        }

        private void 椭圆_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            type = tsb.Name;
            pictureBox1.Cursor = Cursors.Cross;
        }

        private void 实心圆形_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            type = tsb.Name;
            pictureBox1.Cursor = Cursors.Cross;
        }

        private void 矩形_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            type = tsb.Name;
            pictureBox1.Cursor = Cursors.Cross;
        }

        private void 实心矩形_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            type = tsb.Name;
            pictureBox1.Cursor = Cursors.Cross;
        }

        private void 清除_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp1);
            g.FillRectangle(new SolidBrush(pictureBox1.BackColor), new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            g.Dispose();
            g = pictureBox1.CreateGraphics();
            g.DrawImage(bmp1, 0, 0);
            g.Dispose();
            dt.O = (Image)bmp1;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)//重绘
        {
            Graphics g = e.Graphics;
            g.DrawImage(dt.O,0,0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dt.p.Color = Color.Green;
        }

        private void more_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            dt.p.Color = c.Color;
        }

        private void colorHatch1_ColorChanged(object sender, ColorHatch.ColorChangedEventArgs e)
        {
            dt.p.Color = e.GetColor;
            dt.color = e.GetColor;
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)//保存绘画
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPG(*.jpg)|*.jpg|BMP(*.bmp)|*.bmp";
            if(save.ShowDialog() == DialogResult.OK)
            {
                dt.O.Save(save.FileName);
                MessageBox.Show("保存成功！");
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)//设置背景
        {
            bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);//画板
            OpenFileDialog file = new OpenFileDialog();//打开文件
            file.ShowDialog();
            Bitmap pic = new Bitmap(file.FileName);//所选文件
            g.DrawImage(pic, 0, 0);
            g.Dispose();
            dt = new DrawTools(pictureBox1.CreateGraphics(), bmp);//实例化dt
            dt.aim.DrawImage(bmp,0,0);//将所选图片画到目标滑板上
            dt.aim.Dispose();
        }


        private void b3_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void b3_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                button3.Location = new Point(button3.Location.X + e.X, button3.Location.Y);


            }
        }

        private void b3_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
            button1.Location = new Point(button3.Location.X, button1.Location.Y);
            button4.Location = new Point(button1.Location.X / 2, button1.Location.Y );
            pictureBox1.Size = new Size((button3.Location.X - panel1.AutoScrollPosition.X), button1.Location.Y);
            //dt.aim = this.pictureBox1.CreateGraphics();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(pictureBox1.BackColor), new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            g.DrawImage(dt.O, 0, 0);
            g.Dispose();
            dt = new DrawTools(pictureBox1.CreateGraphics(), bmp);

        }

        private void b4_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void b4_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                button4.Location = new Point(button4.Location.X, button4.Location.Y + e.Y);
            }
        }

        private void b4_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
            button1.Location = new Point(button1.Location.X, button4.Location.Y);
            button3.Location = new Point(button1.Location.X , button1.Location.Y / 2);
            pictureBox1.Size = new Size((button3.Location.X ), (button1.Location.Y - panel1.AutoScrollPosition.Y));
            //dt.aim = this.pictureBox1.CreateGraphics();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(pictureBox1.BackColor), new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            g.DrawImage(dt.O, 0, 0);
            g.Dispose();
            dt = new DrawTools(pictureBox1.CreateGraphics(), bmp);

        }

        private  void b1_MouseDown(object sender,MouseEventArgs e)
        {
            flag = true;
        }

        private void b1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (flag)
            {
                //textBox1.Text = e.Location.X.ToString() + "  " + e.Location.Y.ToString();
                button1.Location = new Point(button1.Location.X + e.X, button1.Location.Y + e.Y);
            }
        }

        private void b1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
            button4.Location = new Point(button1.Location.X / 2, button1.Location.Y);
            button3.Location = new Point(button1.Location.X, button1.Location.Y / 2);
            pictureBox1.Size = new Size((button1.Location.X - panel1.AutoScrollPosition.X),(button1.Location.Y - panel1.AutoScrollPosition.Y));
            //dt.aim = this.pictureBox1.CreateGraphics();
            bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(pictureBox1.BackColor), new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            g.DrawImage(dt.O,0,0);
            g.Dispose();
            dt = new DrawTools(pictureBox1.CreateGraphics(),bmp);

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 笔_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            dt.s = textBox1.Text.ToString();
            ToolStripButton tsb = sender as ToolStripButton;
            type = tsb.Name;
            pictureBox1.Cursor = Cursors.Cross;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.ShowDialog();
            dt.f = f.Font;
            //dt.f = f.Color;
        }
    }
}
