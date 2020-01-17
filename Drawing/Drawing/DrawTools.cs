using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Drawing
{
    class DrawTools
    {
        public bool flag = false;
        public PointF startp;
        //Bitmap bit;
        public Font f = new Font("Arial", 16);
        public Graphics aim, help;
        public Image O, F;
        public Pen p = new Pen(Color.Black);
        public Color color = Color.Black;
        public string s = "请输入你要输入的文字";
        public DrawTools(Graphics g,Image img)
        {
            aim = g;
            O = (Image)img.Clone();
            F = (Image)img.Clone();
        }

        public void Draw(MouseEventArgs e, string type)
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
                case "笔":
                    {
                        
                        //FontDialog ff = new FontDialog();
                        //ff.ShowDialog();
                        //f. = ff.;
                        
                        help.DrawString(s,f,new SolidBrush(color),new PointF(e.X,e.Y));
                        break;
                    }
            }
            //help.FillPath();
            help.Dispose();
            help = Graphics.FromImage(F);
            help.DrawImage(img, 0, 0);//原图覆盖
            help.Dispose();
            aim.DrawImage(img, 0, 0);
            img.Dispose();
        }

        public void DrawPencil(MouseEventArgs e) // 铅笔
        {
            PointF currentpoint = new PointF(e.X, e.Y);
            help = Graphics.FromImage(F);
            help.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;//抗锯齿
            help.DrawLine(p, startp, currentpoint);
            help.Dispose();
            startp = currentpoint;
            aim.DrawImage(F, 0, 0);

        }

        public void Eraser(MouseEventArgs e) //橡皮
        {
            help = Graphics.FromImage(F);
            help.FillRectangle(new SolidBrush(Color.White), new Rectangle(e.X, e.Y, 20, 20));
            help.Dispose();
            aim.DrawImage(F, 0, 0);
        }

        public void EndDraw()
        {
            flag = false;
            help = Graphics.FromImage(O);
            help.DrawImage(F, 0, 0);
            help.Dispose();
        }

        public void PenSize(MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                p.Width++;
            }
            else
            {
                p.Width--;
            }
        }

        public void Clean()
        {
            //Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //Graphics g = Graphics.FromImage(bmp);
            //g.FillRectangle(new SolidBrush(pictureBox1.BackColor), new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            //g.Dispose();
            //g = pictureBox1.CreateGraphics();
            //g.DrawImage(bmp, 0, 0);
            //g.Dispose();
            //O = (Image)bmp;
        }
    }
}
