using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;



namespace Car_Racing
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

        }

        Random ran = new Random();
        public static int gamespeed = 3;
        SoundPlayer song = new SoundPlayer("hit.wav");
        SoundPlayer song2 = new SoundPlayer("coins2.wav");

        private void timer1_Tick(object sender, EventArgs e)
        {
            Moveline(gamespeed);

            Enemy(gamespeed);

            GameOver();

            Coins(gamespeed);

            CoinCollectioncoins();

            NewLevel(gamespeed);

        }

        private  void Moveline(int speed)
        {
            



            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top=0;

            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;

            }
            else
            {
                pictureBox2.Top += speed;
            }


            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;

            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox6.Top >= 500)
            {
                pictureBox6.Top = 0;

            }
            else
            {
                pictureBox6.Top += speed;
            }



        }

        private  void Enemy(int speed)
        {

            if (ename1.Top >= 500)
            {

                x = ran.Next(15, 350);

                ename1.Location = new Point(x,0);

            }
            else
            {
               ename1.Top += speed;
            }



            if (ename2.Top >= 500)
            {

                x = ran.Next(15, 350);

                ename2.Location = new Point(x, 0);

            }
            else
            {
                ename2.Top += speed;
            }



            if (ename3.Top >= 500)
            {
                x = ran.Next(15, 350);

                ename3.Location = new Point(x, 0);

            }
            else
            {
                ename3.Top += speed;
            }

           


        }

        private void GameOver()
        {

            if (picture_car1.Bounds.IntersectsWith(ename1.Bounds))
            {
                timer1.Enabled = false;

                pic_game_over.BackColor = Color.Transparent;

                pic_game_over.Visible = true;

                lab_score.Text = "Your Score is: " + coinsCol.ToString();

                lab_score.Visible = true;

                picture_car1.Controls.Add(gif_explosion);

                gif_explosion.Location = new Point(-8, 5);

                gif_explosion.BackColor = Color.Transparent;

                gif_explosion.Visible = true;

                gif_explosion.BringToFront();

                song.Play();

                timer_contr.Stop();
              


            }

            if (picture_car1.Bounds.IntersectsWith(ename2.Bounds))
            {
                timer1.Enabled = false;
       
                pic_game_over.Visible = true;

                lab_score.Text = "Your Score is: " + coinsCol.ToString();

                lab_score.Visible = true;

                picture_car1.Controls.Add(gif_explosion);

                gif_explosion.Location = new Point(-8, 5);

                gif_explosion.BackColor = Color.Transparent;

                gif_explosion.Visible = true;

                gif_explosion.BringToFront();

                song.Play();

                timer_contr.Stop();
            }

            if (picture_car1.Bounds.IntersectsWith(ename3.Bounds))
            {
                timer1.Enabled = false;            

                pic_game_over.Visible = true;

                lab_score.Text = "Your Score is: " + coinsCol.ToString();

                lab_score.Visible = true;

                picture_car1.Controls.Add(gif_explosion);

                gif_explosion.Location = new Point(-8, 5);

                gif_explosion.BackColor = Color.Transparent;

                gif_explosion.Visible = true;

                gif_explosion.BringToFront();

                song.Play();

                timer_contr.Stop();
            }
           
            if (picture_car1.Bounds.IntersectsWith(truck1.Bounds))
            {

                if (truck1.Enabled)
                {
             
                timer1.Enabled = false;
                    
                pic_game_over.Visible = true;

                lab_score.Text = "Your Score is: " + coinsCol.ToString();

                lab_score.Visible = true;

                picture_car1.Controls.Add(gif_explosion);

                gif_explosion.Location = new Point(-8, 5);

                gif_explosion.BackColor = Color.Transparent;

                gif_explosion.Visible = true;

                gif_explosion.BringToFront();

                song.Play();

                timer_contr.Stop();
            }

            }
        }

        int x=0, y=0;
        private  void Coins(int speed)
        {

            if (pic_coin1.Top >= 500)
            {
                
                x = ran.Next(15, 345);

                pic_coin1.Location = new Point(x, 0);

                if (pic_coin1.Bounds.IntersectsWith(ename1.Bounds) || pic_coin1.Bounds.IntersectsWith(ename2.Bounds) || pic_coin1.Bounds.IntersectsWith(ename3.Bounds)   || pic_coin1.Bounds.IntersectsWith(truck1.Bounds) || pic_coin1.Bounds.IntersectsWith(pic_coin2.Bounds)|| pic_coin1.Bounds.IntersectsWith(pic_coin3.Bounds))
                {
                    pic_coin1.Enabled = false;
                    pic_coin1.Visible = false;

                }
                else
                {

                    pic_coin1.Enabled = true;
                    pic_coin1.Visible = true;

                }

               

            }
            
            else
            {
                pic_coin1.Top += speed;

                if (pic_coin1.Bounds.IntersectsWith(ename1.Bounds) || pic_coin1.Bounds.IntersectsWith(ename2.Bounds) || pic_coin1.Bounds.IntersectsWith(ename3.Bounds)|| pic_coin1.Bounds.IntersectsWith(truck1.Bounds) || pic_coin1.Bounds.IntersectsWith(pic_coin2.Bounds) || pic_coin1.Bounds.IntersectsWith(pic_coin3.Bounds))
                {
                    pic_coin1.Enabled = false;
                    pic_coin1.Visible = false;

                }
                else
                {

                    pic_coin1.Enabled = true;
                    pic_coin1.Visible = true;

                }
               

            }


           

            if (pic_coin2.Top >= 500)
            {

                x = ran.Next(15, 345);

                pic_coin2.Location = new Point(x, 0);

                if (pic_coin2.Bounds.IntersectsWith(ename1.Bounds) || pic_coin2.Bounds.IntersectsWith(ename2.Bounds) || pic_coin2.Bounds.IntersectsWith(ename3.Bounds)|| pic_coin1.Bounds.IntersectsWith(truck1.Bounds) || pic_coin1.Bounds.IntersectsWith(truck1.Bounds) || pic_coin2.Bounds.IntersectsWith(pic_coin1.Bounds) || pic_coin2.Bounds.IntersectsWith(pic_coin3.Bounds))
                {
                    pic_coin2.Enabled = false;
                    pic_coin2.Visible = false;

                }
                else
                {

                    pic_coin2.Enabled = true;
                    pic_coin2.Visible = true;

                }



            }

            else
            {
                pic_coin2.Top += speed;

                if (pic_coin2.Bounds.IntersectsWith(ename1.Bounds) || pic_coin2.Bounds.IntersectsWith(ename2.Bounds) || pic_coin2.Bounds.IntersectsWith(ename3.Bounds)|| pic_coin1.Bounds.IntersectsWith(truck1.Bounds) || pic_coin2.Bounds.IntersectsWith(pic_coin1.Bounds) || pic_coin2.Bounds.IntersectsWith(pic_coin3.Bounds))
                {
                    pic_coin2.Enabled = false;
                    pic_coin2.Visible = false;

                }
                else
                {

                    pic_coin2.Enabled = true;
                    pic_coin2.Visible = true;

                }





            }

           


        }

        int coinsCol = 0;
        private  void CoinCollectioncoins()
        {
            if (picture_car1.Bounds.IntersectsWith(pic_coin1.Bounds))
            {
                coinsCol++;

                lab_coins.Text = "Coins=" + coinsCol.ToString();

                song2.Play();

                x = ran.Next(0, 200);

                pic_coin1.Location = new Point(x, 0);

            }

            if (picture_car1.Bounds.IntersectsWith(pic_coin2.Bounds))
            {
                coinsCol++;

                lab_coins.Text = "Coins=" + coinsCol.ToString();

                song2.Play();

                x = ran.Next(0, 200);

                pic_coin2.Location = new Point(x, 0);

            }


          

        }
     
        private void form2_KeyDown(object sender, KeyEventArgs e)  // Game controls
        {
            if (e.KeyCode == Keys.Space)
            {
                timer1.Enabled = true;

                leb_space.Visible = false;

                timer_contr.Enabled = true;


           } else if (e.KeyCode == Keys.Enter)
            {
                timer1.Enabled = false;

                picture_car1.Location = new Point(67, 438);

                ename1.Location = new Point(67, 178);

                ename2.Location = new Point(250, 77);

                ename3.Location = new Point(250, 266);

                pic_coin3.Location = new Point(100, 230);

                pic_coin1.Location = new Point(118, 87);

                pic_coin2.Location = new Point(238, 41);

                truck1.Location = new Point(359, 471);

                pic_game_over.Visible = false;

                gif_explosion.Visible = false;

                lab_score.Visible = false;

                timer_contr.Enabled = false;

                truck1.Visible = false;

                truck1.Enabled = false;

                lab_next_level.Visible = false;

                nexlevelcount = 1;
                nextlevel = 1;


                lab_sec.Text = "00";
                lab_min.Text = "00";
                lab_hour.Text = "00";
                lab_score.Text = "0";
                min = 0;
                sec = 0;
                count = 0;
                houer = 0;
                coinsCol = 0;
                lab_coins.Text = "Coins=0";
                lab_level.Text = "Lev=" + 1.ToString();
                nexlevelcount = 1;

            }
            

                if (e.KeyCode == Keys.Left){
               
                if (picture_car1.Left > 0)
                
                 picture_car1.Left += -8;
                
               
                 }
                
            if (e.KeyCode == Keys.Right)
            {
                if (picture_car1.Right < 380)
                
                    picture_car1.Left +=8;
                
                
            }

            if (e.KeyCode == Keys.ControlKey)
            {
                timer1.Enabled = false;
             
                timer_contr.Enabled = false;

            }


        }
     
        int sec = 0;
        int count = 0;
        int houer = 0;
        int min = 0;
        private void timer_contr_Tick(object sender, EventArgs e) // Timer of the game
        {


            if (sec != 60)
            {

             if (count <= 9)
                {

                    count++;

                    sec++;

                    lab_sec.Text = "0" + sec.ToString();
                }
                else
                {

                    sec++;

                    lab_sec.Text = sec.ToString();

                }


            }
            else
            {
                count = 0;

                if (min != 60)
                {


                if (count <= 9)
                {

                    sec = 0;
                    count++;
                    lab_sec.Text = "00";
                    min++;
                    lab_min.Text = "0" + min.ToString();

                }
                else
                {
                   count = 0;
                    sec = 0;
                     count++;
                    lab_sec.Text = "00";
                    min++;
                    lab_min.Text =min.ToString();

            
                }

                }
                else
                {
                    count = 0;
                    houer++;
                    sec = 0;
                    min = 0;
                    count++;
                    lab_min.Text = "00";
                    lab_sec.Text = "00";
                    houer++;
                    lab_hour.Text = "0" + houer.ToString();


                }

               

            }


        }

        int nexlevelcount = 1;
        int nextlevel = 1;
        private void NewLevel(int speed)
        {
           if (sec >= 15||min>=1||houer>=1)
            {

            if (truck1.Bounds.IntersectsWith(ename1.Bounds) || truck1.Bounds.IntersectsWith(ename2.Bounds) || truck1.Bounds.IntersectsWith(ename3.Bounds))
                {
                    truck1.Visible = false;
                    truck1.Enabled = false;
                    truck1.Location = new Point(341, 471);

                }
                else
                {
                    truck1.Visible = true;
                    truck1.Enabled = true;

                }


                if (truck1.Top >= 500)
                {

                   x = ran.Next(15, 350);
                    truck1.Location = new Point(x, 0);

                }
                else
                {
                    truck1.Top += speed;
                }




            }
           
           

           

            if (nexlevelcount == 1 && sec >= 15)
            {
                lab_next_level.Visible = true;

                nextlevel++;

                lab_level.Text = "Lev=" + nextlevel.ToString();

                nexlevelcount = 0;

            }
            if (sec == 18)
            {
                lab_next_level.Visible = false;
                
            }

           

        }

       
    }
}
