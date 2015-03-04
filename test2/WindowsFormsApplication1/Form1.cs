using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        PicMatrix picmatrix = new PicMatrix(50,50);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 768);
            button1.Location = new Point(250,500);
            button1.Text = "play";
            picmatrix.picshow(this);
            picmatrix.RandomShow();
            picmatrix.picBottom(this);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picmatrix.picdown();
        }
        private void pic1(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.D:
                    picmatrix.compareKeyDown(0);
                    break;
                case Keys.F:
                    picmatrix.compareKeyDown(1);
                    break;
                case Keys.J:
                    picmatrix.compareKeyDown(2);
                    break;
                case Keys.K:
                    picmatrix.compareKeyDown(3);
                    break;
            }
                
        }
        
    }
}
