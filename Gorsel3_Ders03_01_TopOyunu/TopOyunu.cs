using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel3_Ders03_01_TopOyunu
{
    public partial class TopOyunu : Form
    {
        public TopOyunu()
        {
            InitializeComponent();
        }
        int a = 5;
        int x=5, y=5 ;
        Point topBaslangic;
        Point cubukBaslangic;
        Random r = new Random();
        int seviye = 1, vurusSayisi = 0, can = 3;

        private void TopOyunu_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        int sure = 0;
        private void timerSure_Tick(object sender, EventArgs e)
        {
            tslbl_sure.Text = String.Format("Sure {0:00}:{1:00} ", sure / 60, sure % 60);
        }

        private void TopOyunu_Load(object sender, EventArgs e)
        {
            topBaslangic = top.Location;
            cubukBaslangic = cubuk.Location;
            timerHareket.Start();
            timerSure.Start();
            seviye = 1;
            vurusSayisi = 0;
            can = 3;
            x = r.Next(0, 2) == 0 ? +a : -a;
            y= r.Next(0, 2) == 0 ? +a : -a;
        }

        private void TopOyunu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left && cubuk.Location.X>0)
                cubuk.Location = new Point(cubuk.Location.X - 10,cubuk.Location.Y);
            else if (e.KeyData == Keys.Right && cubuk.Location.X < this.Width-120)
                cubuk.Location = new Point(cubuk.Location.X + 10, cubuk.Location.Y);

            if (e.KeyData == Keys.A && cubuk2.Location.X > 0)
                cubuk2.Location = new Point(cubuk2.Location.X - 10, cubuk2.Location.Y);
            else if (e.KeyData == Keys.D && cubuk2.Location.X < this.Width - 120)
                cubuk2.Location = new Point(cubuk2.Location.X + 10, cubuk2.Location.Y);

            if (e.KeyData == Keys.Space && timerHareket.Enabled == false)
            {
                x = r.Next(0, 2) == 0 ? +a : -a;
                y = r.Next(0, 2) == 0 ? +a : -a;
                timerHareket.Start();
            }
        }

        private void timerHareket_Tick(object sender, EventArgs e)
        {
            //if (top.Location.Y <= 0)
            //    y = +a;
            if (top.Location.X >= this.Size.Width -35)
                x = -a;
            if (top.Location.X <= 0)
                x = +a;
            if (top.Location.Y <= cubuk2.Location.Y + 10
         && (top.Location.X >= cubuk2.Location.X - 10 && top.Location.X <= cubuk2.Location.X + cubuk2.Width - 2))
            {
                y = +a;
            }
            if (top.Location.Y >= cubuk.Location.Y - 20
         && (top.Location.X >= cubuk.Location.X - 10 && top.Location.X <= cubuk.Location.X + cubuk.Width - 2))
            {
                y = -a;
            }
            if (top.Location.Y >= cubuk.Location.Y - 10)
            {
                timerHareket.Stop();
                MessageBox.Show("1. Oyuncu Kazandı..");
                cubuk.Location = new Point(cubukBaslangic.X,cubuk.Location.Y);
                cubuk2.Location = new Point(cubukBaslangic.X, cubuk2.Location.Y);
                top.Location = topBaslangic;
                return;
            }

            if (top.Location.Y <= cubuk2.Location.Y - 10)
            {
                timerHareket.Stop();
                MessageBox.Show("2. Oyuncu Kazandı..");
                cubuk.Location = new Point(cubukBaslangic.X, cubuk.Location.Y);
                cubuk2.Location = new Point(cubukBaslangic.X, cubuk2.Location.Y);
                top.Location = topBaslangic;
                return;
            }

            top.Location = new Point(top.Location.X+x,top.Location.Y+y);

        }
    }
}
