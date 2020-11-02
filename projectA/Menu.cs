using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;




namespace Car_Racing
{
    public partial class Menu : Form
    {
       
        
        public Menu()
        {
            InitializeComponent();

        }

        private bool blnButtonDown = false;

        private void btn_statrt_Paint(object sender, PaintEventArgs e)
        {
            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }

        }

        private void btn_statrt_Click(object sender, EventArgs e)
        {
            Game form1 = new Game();

            form1.Show();

          
            this.Hide();

           
        }

       
        private void btn_lev_dif_Click(object sender, EventArgs e)
        {
           

             countLeveldif++;

            if (countLeveldif <= 2)
            {

               btn_instruc.Visible = false;
               panel1.Visible = true;
               panel1.Height = 90;
            }
            else
            {

                panel1.Visible = false;
                btn_instruc.Visible = true;
                panel1.Height = 0;
                countLeveldif = 0;


            }



        }

        int countLeveldif = 1;
        private void btn_lev_dif_Paint(object sender, PaintEventArgs e)
        {
            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

        private void radion_hard_CheckedChanged(object sender, EventArgs e)
        {


            if (radion_hard.Checked)
            {
                Game.gamespeed = 5;
                panel1.Visible = false;
                panel1.Height = 1;
                timer1.Stop();
                btn_instruc.Visible = true;
               

            }

        }

        private void radion_medium_CheckedChanged(object sender, EventArgs e)
        {

            if (radion_medium.Checked)
            {
                Game.gamespeed = 4;
                panel1.Visible = false;
                panel1.Height = 1;
                timer1.Stop();
                btn_instruc.Visible = true;


            }
        }

        private void radion_easy_CheckedChanged(object sender, EventArgs e)
        {
            

            if (radion_easy.Checked)
            {
                Game.gamespeed = 3;
                panel1.Visible = false;
                panel1.Height = 1;
                timer1.Stop();
                btn_instruc.Visible = true;


            }

        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Paint_1(object sender, PaintEventArgs e)
        {
            if (blnButtonDown == false)
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, (sender as System.Windows.Forms.Button).ClientRectangle,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset,
                    System.Drawing.SystemColors.ControlLightLight, 2, ButtonBorderStyle.Inset);
            }
        }

       
        int countinst = 1;
        private void btn_instruc_Click(object sender, EventArgs e)
        {
           

            countinst++;

            if (countinst <= 2)
            {

                btn_Exit.Visible = false;

                pan_instriction.Visible = true;

                pan_instriction.Height = 126;
            }
            else
            {

                pan_instriction.Visible = false;
                btn_Exit.Visible =true;
                pan_instriction.Height = 0;
                countinst = 0;


            }

         
        }



    }
}
