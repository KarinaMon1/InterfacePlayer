using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Audioplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            //остановка/продлжение трека 


        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            //переходит к предидущему треку


        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            //переходит к следующему треку 


        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //в таблице к каждой песне привязана картинка типа "BabePic.png" как просто строка
            //её вытаскиваем и ищем картинку в папке с картинками и вставляем 

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //каким-то образом тут должна работать перемотка по треку 
        }
    }
}
