namespace RunnerGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.JumpUp = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fenc1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Fenc2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NCoins = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNCoins = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Coin3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Coin2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Coin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Start = new System.Windows.Forms.PictureBox();
            this.Fenc = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Player = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayerRunTime = new System.Windows.Forms.Timer(this.components);
            this.CoinTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fenc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fenc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fenc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // JumpUp
            // 
            this.JumpUp.Interval = 20;
            this.JumpUp.Tick += new System.EventHandler(this.JumpUp_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Fenc1);
            this.panel1.Controls.Add(this.Fenc2);
            this.panel1.Controls.Add(this.NCoins);
            this.panel1.Controls.Add(this.lblNCoins);
            this.panel1.Controls.Add(this.Coin3);
            this.panel1.Controls.Add(this.Coin2);
            this.panel1.Controls.Add(this.Coin);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.Fenc);
            this.panel1.Controls.Add(this.Player);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1779, 516);
            this.panel1.TabIndex = 0;
            // 
            // Fenc1
            // 
            this.Fenc1.BackColor = System.Drawing.Color.Transparent;
            this.Fenc1.Image = global::RunnerGame.Properties.Resources.obstacle;
            this.Fenc1.ImageRotate = 0F;
            this.Fenc1.Location = new System.Drawing.Point(1000, 330);
            this.Fenc1.Name = "Fenc1";
            this.Fenc1.Size = new System.Drawing.Size(104, 83);
            this.Fenc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fenc1.TabIndex = 11;
            this.Fenc1.TabStop = false;
            this.Fenc1.UseTransparentBackground = true;
            // 
            // Fenc2
            // 
            this.Fenc2.BackColor = System.Drawing.Color.Transparent;
            this.Fenc2.Image = global::RunnerGame.Properties.Resources.obstacle;
            this.Fenc2.ImageRotate = 0F;
            this.Fenc2.Location = new System.Drawing.Point(1500, 330);
            this.Fenc2.Name = "Fenc2";
            this.Fenc2.Size = new System.Drawing.Size(104, 83);
            this.Fenc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fenc2.TabIndex = 10;
            this.Fenc2.TabStop = false;
            this.Fenc2.UseTransparentBackground = true;
            // 
            // NCoins
            // 
            this.NCoins.AutoSize = false;
            this.NCoins.BackColor = System.Drawing.Color.Transparent;
            this.NCoins.BackgroundImage = global::RunnerGame.Properties.Resources.background;
            this.NCoins.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCoins.Location = new System.Drawing.Point(128, 3);
            this.NCoins.Name = "NCoins";
            this.NCoins.Size = new System.Drawing.Size(53, 49);
            this.NCoins.TabIndex = 9;
            this.NCoins.Text = "0";
            // 
            // lblNCoins
            // 
            this.lblNCoins.AutoSize = false;
            this.lblNCoins.BackColor = System.Drawing.Color.Transparent;
            this.lblNCoins.BackgroundImage = global::RunnerGame.Properties.Resources.background;
            this.lblNCoins.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCoins.Location = new System.Drawing.Point(12, 3);
            this.lblNCoins.Name = "lblNCoins";
            this.lblNCoins.Size = new System.Drawing.Size(110, 49);
            this.lblNCoins.TabIndex = 8;
            this.lblNCoins.Text = "Coins ";
            // 
            // Coin3
            // 
            this.Coin3.BackColor = System.Drawing.Color.Transparent;
            this.Coin3.Image = ((System.Drawing.Image)(resources.GetObject("Coin3.Image")));
            this.Coin3.ImageRotate = 0F;
            this.Coin3.Location = new System.Drawing.Point(250, 370);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(42, 31);
            this.Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin3.TabIndex = 7;
            this.Coin3.TabStop = false;
            this.Coin3.UseTransparentBackground = true;
            // 
            // Coin2
            // 
            this.Coin2.BackColor = System.Drawing.Color.Transparent;
            this.Coin2.Image = ((System.Drawing.Image)(resources.GetObject("Coin2.Image")));
            this.Coin2.ImageRotate = 0F;
            this.Coin2.Location = new System.Drawing.Point(1344, 370);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(42, 31);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin2.TabIndex = 6;
            this.Coin2.TabStop = false;
            this.Coin2.UseTransparentBackground = true;
            // 
            // Coin
            // 
            this.Coin.BackColor = System.Drawing.Color.Transparent;
            this.Coin.Image = global::RunnerGame.Properties.Resources.CoinsGiF;
            this.Coin.ImageRotate = 0F;
            this.Coin.Location = new System.Drawing.Point(797, 370);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(42, 31);
            this.Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin.TabIndex = 5;
            this.Coin.TabStop = false;
            this.Coin.UseTransparentBackground = true;
            // 
            // Start
            // 
            this.Start.Image = global::RunnerGame.Properties.Resources.aBbJcT;
            this.Start.Location = new System.Drawing.Point(802, 227);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(175, 62);
            this.Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Start.TabIndex = 4;
            this.Start.TabStop = false;
            this.Start.Click += new System.EventHandler(this.Start_Click_1);
            // 
            // Fenc
            // 
            this.Fenc.BackColor = System.Drawing.Color.Transparent;
            this.Fenc.Image = global::RunnerGame.Properties.Resources.obstacle;
            this.Fenc.ImageRotate = 0F;
            this.Fenc.Location = new System.Drawing.Point(500, 330);
            this.Fenc.Name = "Fenc";
            this.Fenc.Size = new System.Drawing.Size(104, 83);
            this.Fenc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fenc.TabIndex = 2;
            this.Fenc.TabStop = false;
            this.Fenc.UseTransparentBackground = true;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::RunnerGame.Properties.Resources.newRunner_01;
            this.Player.ImageRotate = 0F;
            this.Player.Location = new System.Drawing.Point(88, 286);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(108, 115);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            this.Player.UseTransparentBackground = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RunnerGame.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1779, 516);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PlayerRunTime
            // 
            this.PlayerRunTime.Interval = 150;
            this.PlayerRunTime.Tick += new System.EventHandler(this.PlayerRunTime_Tick);
            // 
            // CoinTimer
            // 
            this.CoinTimer.Interval = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 516);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUP);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Fenc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fenc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fenc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer JumpUp;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox Fenc;
        private Guna.UI2.WinForms.Guna2PictureBox Player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer PlayerRunTime;
        private System.Windows.Forms.Timer CoinTimer;
        private System.Windows.Forms.PictureBox Start;
        private Guna.UI2.WinForms.Guna2PictureBox Coin;
        private Guna.UI2.WinForms.Guna2PictureBox Coin3;
        private Guna.UI2.WinForms.Guna2PictureBox Coin2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNCoins;
        private Guna.UI2.WinForms.Guna2HtmlLabel NCoins;
        private Guna.UI2.WinForms.Guna2PictureBox Fenc1;
        private Guna.UI2.WinForms.Guna2PictureBox Fenc2;
    }
}

