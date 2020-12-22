using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarRacing
{
    public partial class Menu : Form
    {
       
        
        public Menu()
        {
            InitializeComponent();

        }

        private bool ButtonPress = false;

        private void btn_Start_Paint(object sender, PaintEventArgs e)
        {
            if (ButtonPress == false)
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

        private void btn_Start_Click(object sender, EventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            this.Hide();

           
        }  

        int countLevelDiff = 1;
        private void btn_LevDifficulty_Click(object sender, EventArgs e)
        {
             countLevelDiff++;

            if (countLevelDiff <= 2)
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
                countLevelDiff = 0;

            }



        } 
    
        private void btn_LevDifficulty_Paint(object sender, PaintEventArgs e)
        {
            if (ButtonPress == false)
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

        private void radioBtnHard_CheckedChanged(object sender, EventArgs e)
        {


            if (radioBtnHard.Checked)
            {
                GameWindow.carSpeed +=+2;
                GameWindow.roadLineSpeed += +2;
                panel1.Visible = false;
                panel1.Height = 1;
                timer1.Stop();
                btn_instruc.Visible = true;
               

            }

        } 

        private void radioBtnMedium_CheckedChanged(object sender, EventArgs e)
        {

            if (radioBtnMedium.Checked)
            {
                GameWindow.carSpeed += +1;
                GameWindow.roadLineSpeed += +1;
                panel1.Visible = false;
                panel1.Height = 1;
                timer1.Stop();
                btn_instruc.Visible = true;


            }
        } 

        private void radioBtnEasy_CheckedChanged(object sender, EventArgs e)
        {
            

            if (radioBtnEasy.Checked)
            {
                GameWindow.carSpeed = 3;
                panel1.Visible = false;
                panel1.Height = 1;
                timer1.Stop();
                btn_instruc.Visible = true;


            }

        } 

        private void btnExit_Paint(object sender, PaintEventArgs e)
        {

            if (ButtonPress == false)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        } 

        private void btnInstructions_Paint(object sender, PaintEventArgs e) 
        {
            if (ButtonPress == false)
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
        private void btnInstructions_Click(object sender, EventArgs e)
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
