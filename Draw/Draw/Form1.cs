using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorHatch;
namespace Draw
{
    
    public partial class Form1 : Form
    {
        bool flag = false;
        PointF startp;
        Bitmap bit;
        Graphics aim, help;
        Image O, F;
        Bitmap b;
        Pen p = new Pen(Color.Black);
        Color color = Color.Black;
        string type;
        public Form1()
        {
            
            InitializeComponent();
            bit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bit);
            g.FillRectangle(new SolidBrush(pictureBox1.BackColor), new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));//很重要
            g.Dispose();
            F = (Image)bit.Clone();//
            O = (Image)bit.Clone();
            aim = pictureBox1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //label1.Text = startp.X.ToString() + "," + startp.Y.ToString();
            
            aim.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pictureBox1.MouseDown += new MouseEventHandler(this.pic_MouseDown);
            pictureBox1.MouseMove += new MouseEventHandler(this.pic_MouseMove);
            pictureBox1.MouseUp += new MouseEventHandler(this.pic_MouseUp);
            pictureBox1.MouseWheel += new MouseEventHandler(this.pic_MouseWheel);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(O,0,0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            type = "矩形";
            pictureBox1.Cursor = Cursors.Cross;
            
        }
        private void pic_MouseDown(object sender,MouseEventArgs e)
        {
            startp = new PointF(e.X,e.Y);
            flag = true;
        }

        private void pic_MouseUp(object sender,MouseEventArgs e)
        {
            flag = false;
            help = Graphics.FromImage(O);
            help.DrawImage(F,0,0);
            help.Dispose();
            
        }

        private void pic_MouseMove(object sender,MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
            if(flag)
            {
                switch (type)
                {
                    case "铅笔":
                        DrawPencil(e);
                        break;
                    case "橡皮":
                        Eraser(e);
                        break;
                    default:
                        Draw(e, type);
                        break;
                }
            }
            
        }


        private void pic_MouseWheel(object sender,MouseEventArgs e)
        {
            if(e.Delta > 0)
            {
                p.Width++;
            }
            else
            {
                p.Width--;
            }
        }
        private void Eraser(MouseEventArgs e) //橡皮
        { 
            help = Graphics.FromImage(F);
            help.FillRectangle(new SolidBrush(pictureBox1.BackColor), new Rectangle(e.X,e.Y,20,20));
            help.Dispose();
            aim.DrawImage(F, 0, 0);
        }

        private void DrawPencil(MouseEventArgs e) // 铅笔
        {
            PointF currentpoint = new PointF(e.X,e.Y);
            help = Graphics.FromImage(F);
            help.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;//抗锯齿
            help.DrawLine(p,startp,currentpoint);
            help.Dispose();
            startp = currentpoint;
            aim.DrawImage(F,0,0);

        }

        private void Draw(MouseEventArgs e,string type)
        {
            Image img = (Image)O.Clone();
            help = Graphics.FromImage(img);
            help.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;//抗锯齿
            switch (type)
            {
                case "矩形":
                    float width = Math.Abs(e.X - startp.X);//确定矩形的宽
                    float heigth = Math.Abs(e.Y - startp.Y);//确定矩形的高
                    PointF rectStartPointF = startp;
                    if (e.X < startp.X)
                    {
                        rectStartPointF.X = e.X;
                    }
                    if (e.Y < startp.Y)
                    {
                        rectStartPointF.Y = e.Y;
                    }
                    help.DrawRectangle(p, rectStartPointF.X, rectStartPointF.Y, width, heigth);
                    break;
                case "椭圆":
                    help.DrawEllipse(p, startp.X, startp.Y, e.X - startp.X, e.Y - startp.Y); 
                    break;
                case "直线":
                    {//画直线
                        help.DrawLine(p, startp, new PointF(e.X, e.Y));
                        break;
                    }
                case "实心矩形":
                    {
                        float w = Math.Abs(e.X - startp.X);//确定矩形的宽
                        float h = Math.Abs(e.Y - startp.Y);//确定矩形的高
                        PointF rectStartPointf = startp;
                        if (e.X < startp.X)
                        {
                            rectStartPointf.X = e.X;
                        }
                        if (e.Y < startp.Y)
                        {
                            rectStartPointf.Y = e.Y;
                        }
                        help.FillRectangle(new SolidBrush(color), rectStartPointf.X, rectStartPointf.Y, w, h);
                        break;
                    }
                case "实心圆形":
                    {
                        help.FillEllipse(new SolidBrush(color), startp.X, startp.Y, e.X - startp.X, e.Y - startp.Y);
                        break;
                    }
            }
            //help.FillPath();
            help.Dispose();
            help = Graphics.FromImage(F);
            help.DrawImage(img,0,0);//原图覆盖
            help.Dispose();
            aim.DrawImage(img,0,0);
            img.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            type = "椭圆";
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            type = tsb.Name;
            pictureBox1.Cursor = Cursors.Cross;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
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

        private void 清除_Click(object sender, EventArgs e)//清除全屏事件
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(new SolidBrush(pictureBox1.BackColor),new Rectangle(0,0, pictureBox1.Width, pictureBox1.Height));
            g.Dispose();
            g = pictureBox1.CreateGraphics();
            g.DrawImage(bmp,0,0);
            g.Dispose();
            O = (Image)bmp;
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

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            p.Color = colorDialog.Color;
            color = colorDialog.Color;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            aim.Clear(pictureBox1.BackColor);
        }
    }
}
