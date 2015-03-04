using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace WindowsFormsApplication1
{
    class PicMatrix
    {
        private  int height;
        private int width;
        Random r = new Random();
        public PictureBox[,] picturearea = new PictureBox[5,4];
        private int[] rs = new int[4];
        public PicMatrix(int height,int width)
        {
            this.height = height;
            this.width = width;
        }
        public void picshow(Form form1)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                        picturearea[i,j]=new PictureBox();
                        picturearea[i, j].Image = new Bitmap(@"C:\Users\Public\Pictures\Sample Pictures\Chrysanthemum.jpg");
                        picturearea[i,j].Size=new Size(height,width);
                        picturearea[i, j].Location = new Point(200+height*j,200+width*i);
                        form1.Controls.Add(picturearea[i,j]);
                        picturearea[i, j].Visible = false;
                }
            }
        }
        public void RandomShow()
        {
           for (int i = 0; i < 4; i++)
            {
                rs[i]=r.Next(0,4);
                for (int j = 0; j < 4; j++)
                {
                    if (j==rs[i])
                    {
                        picturearea[i, j].Visible = true;
                    }
                    else
                    {
                        picturearea[i, j].Visible = false;
                    }
                }
            }
        }
        public void picBottom(Form form1)
        {
            for(int i=0;i<4;i++)
            {
                picturearea[4, i] = new PictureBox();
                picturearea[4, i].BackColor = Color.White;
                picturearea[4, i].Size = new Size(height, width);
                picturearea[4,i].BorderStyle=BorderStyle.Fixed3D;
         
                picturearea[4, i].Location = new Point(200 + height * i, 200 + width * 4);
                form1.Controls.Add(picturearea[4,i]);
            }
        }
        public void picdown()
        {
            for(int i=3;i>=0;i--)
            {
                picturearea[i, rs[i]].Visible = false;
                if(i==0)
                {
                    rs[i] = r.Next(0, 4);
                    picturearea[i, rs[i]].Visible = true;
                }
                else
                {
                    picturearea[i, rs[i - 1]].Visible = true;
                    rs[i] = rs[i - 1];
                }
            }
        }
        public void compareKeyDown(int Idex)
        {
            if(Idex==rs[4])
            {
                this.picturearea[4, Idex].BackColor = Color.Green;
                this.picdown();
            }
            else
            {
                this.picturearea[4, Idex].BackColor = Color.Red;
            }
        }

    }
}
