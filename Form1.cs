using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace RunnerGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Jumbing = false; 
        byte SwitchPic = 0;
        byte TimeJumbing = 0;
        int NumberOfcoins = 0;
        Random CoinsLocation = new Random();
        Random FencLocation = new Random();


        void ChangLocation(PictureBox PBX,Random arg)
        {
            PBX.Left = arg.Next(1200,1500);
        }
        void Reset()
        {
            JumpUp.Start();
            PlayerRunTime.Start();
            Player.Top = 250;
            Fenc.Left = 500;
            Fenc1.Left = 1000;
            Fenc2.Left = 1500;

            Start.Visible = false;
            Start.Enabled = false;
            Player.Enabled = true;
            NCoins.Text = "0";
            NumberOfcoins = 0;
            NCoins.Enabled = false;
            lblNCoins.Enabled = false;



        }

        void SumCoins(PictureBox Coins)
        {
            MovePicBox(Coins);

            if (Coins.Bounds.IntersectsWith(Player.Bounds) || Player.Bounds.IntersectsWith(Coins.Bounds))
            {
                Coins.Visible = false;
                NumberOfcoins++;

                ChangLocation(Coins,CoinsLocation);
                NCoins.Text = NumberOfcoins.ToString();


            }
            else
            {
                Coins.Visible = true;
            }

        }
        void GameOver()
        {
            JumpUp.Stop();
            PlayerRunTime.Stop();
            Start.Visible = true;
            Start.Enabled = true;
            Player.Enabled = false;

        }
         void AccidantPlayerWithFenc(PictureBox PBXFenc)
        {
            MovePicBox(PBXFenc);

            if (PBXFenc.Bounds.IntersectsWith(Player.Bounds) || Player.Bounds.IntersectsWith(PBXFenc.Bounds))
            {

                GameOver();
            }

        }

        void MovePicBox(PictureBox PBX)
        {
            PBX.Left -= 20;

            if(PBX.Left < 0)
            {
                PBX.Left = 1400;
            }

        }

        void ChangePicturePlayer(PictureBox PBXPlayer)
        {
           
               if (Jumbing == true || Player.Top < 250) return;

                SwitchPic++;

                if (SwitchPic == 1)
                {
                    PBXPlayer.Image = Properties.Resources.newRunner_01;

                }
                if (SwitchPic == 2)
                {
                    PBXPlayer.Image = Properties.Resources.newRunner_03;

                }
                if (SwitchPic == 3)
                {
                    PBXPlayer.Image = Properties.Resources.newRunner_05;

                }
                if (SwitchPic == 4)
                {
                    PBXPlayer.Image = Properties.Resources.newRunner_07;

                  SwitchPic = 0;

                }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {


            if (Player.Top < 170)
            {
                Player.Top = 170;
                Jumbing = false;

            }
            if (e.KeyCode == Keys.Space && Player.Top > 170)
            {
                Player.Top -= 80;
                Player.Image = Properties.Resources.newRunner_02;
                Jumbing = true;
            }
        }
        private void KeyIsUP(object sender, KeyEventArgs e)
        {
            Player.Top = 250;
            Player.Image = Properties.Resources.newRunner_06;

            if (Jumbing == true)
            {
                Jumbing = false;

            }

        }

        private void JumpUp_Tick(object sender, EventArgs e)
        {

            AccidantPlayerWithFenc(Fenc);
            AccidantPlayerWithFenc(Fenc1);
            AccidantPlayerWithFenc(Fenc2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();  
        }

        private void PlayerRunTime_Tick(object sender, EventArgs e)
        {

            SumCoins(Coin);
            SumCoins(Coin2);
            SumCoins(Coin3);
            ChangLocation(Fenc, FencLocation);
            ChangePicturePlayer(Player);
        }



        private void Start_Click_1(object sender, EventArgs e)
        {
            Reset();

        }
    }
}

