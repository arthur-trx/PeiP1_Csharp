using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP11_15
{
    public partial class Form1 : Form
    {
        // C# inline color vizualiser
        /*Brush m_Brosse_bleus = new SolidBrush(Color.LightBlue); //System.Drawing.Brush 
        Brush m_Brosse_rouge = new SolidBrush(Color.Red);
        Brush m_Brosse_jaune = new SolidBrush(Color.Yellow);
        Brush m_Brosse_vert = new SolidBrush(Color.LightGreen);*/
        SolidBrush m_Brosse_rectangle = new SolidBrush(Color.LightBlue);



        SolidBrush m_Brosse_police = new SolidBrush(Color.Red);
        Font m_Font = new Font("Arial", 16);
        Rectangle m_Rectangle; // System.Drawing.Rectangle
        bool m_deplace = false;
        Point m_Last_Mouse;
        Point m_delta;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            m_delta = new Point(0, 0);

            m_Last_Mouse = new Point(ClientSize);
            m_Last_Mouse.X /= 4;
            m_Last_Mouse.Y /= 4;

            m_Rectangle = new Rectangle(m_Last_Mouse, ClientSize);
            m_Rectangle.Height /= 2;
            m_Rectangle.Width /= 2;


            //int W = 200; int H = 150;
            m_Rectangle = new Rectangle(m_Last_Mouse, ClientSize);
            //m_Rectangle = new Rectangle(ClientSize.Width / 2 - W / 2, ClientSize.Height / 2 - H / 2, W, H);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            update();



        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            m_Last_Mouse = e.Location;

            if (m_Rectangle.Contains(MousePosition))
            {
                m_Brosse_rectangle.Color = Color.LightGreen; // new SolidBrush(Color.LightGreen);

            }
            else m_Brosse_rectangle.Color = Color.LightBlue;

            if (m_deplace)
            {
                ///////////////
                m_Last_Mouse.X += m_delta.X;
                m_Last_Mouse.Y += m_delta.Y;

                if (m_Last_Mouse.X > ClientSize.Width - m_Rectangle.Width)
                    m_Last_Mouse.X = ClientSize.Width - m_Rectangle.Width;
                else if (m_Last_Mouse.X < 0)
                    m_Last_Mouse.X = 0;
                if (m_Last_Mouse.Y > ClientSize.Height - m_Rectangle.Height)
                    m_Last_Mouse.Y = ClientSize.Height - m_Rectangle.Height;
                else if (m_Last_Mouse.Y < 0)
                    m_Last_Mouse.Y = 0;


                m_Rectangle.Location = m_Last_Mouse;
                ///////////////
                /*int W = 200; int H = 150;
                m_Rectangle.X = e.X - W / 2;
                m_Rectangle.Y = e.Y - H / 2;*/
            }

            
            update();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (m_Brosse_police.Color == Color.Yellow) m_Brosse_police.Color = Color.Red;
                else m_Brosse_police.Color = Color.Yellow;
            }


            if (e.Button == MouseButtons.Left)
            {
                
                if (m_Rectangle.Contains(MousePosition))
                {
                    //m_Brosse_police.Color = Color.Violet;
                    m_deplace = true;
                    m_delta.X = m_Rectangle.X - m_Last_Mouse.X;
                    m_delta.Y = m_Rectangle.Y - m_Last_Mouse.Y;


                }
            }
            update();
        }
    
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            m_deplace = false;
        }



        public void update()
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);


            //Pen temp_pen = new Pen(m_Brosse_bleus, 1);
            graphics.FillRectangle(m_Brosse_rectangle, m_Rectangle);
            Point temp_point = new Point(m_Rectangle.X + m_Rectangle.Width / 3, m_Rectangle.Y + m_Rectangle.Height / 3);
            graphics.DrawString("Box", m_Font, m_Brosse_police, temp_point);

        }
    }
}
