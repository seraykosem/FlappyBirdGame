namespace FlappyBirdGame
{
    partial class FlappyBirdGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBirdGame));
            this.Score = new System.Windows.Forms.Label();
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.pipedown = new System.Windows.Forms.PictureBox();
            this.pipe = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(12, 485);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(87, 22);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score : 0";
            // 
            // flappybird
            // 
            this.flappybird.Image = ((System.Drawing.Image)(resources.GetObject("flappybird.Image")));
            this.flappybird.Location = new System.Drawing.Point(55, 178);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(121, 71);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flappybird.TabIndex = 1;
            this.flappybird.TabStop = false;
            // 
            // pipedown
            // 
            this.pipedown.Image = ((System.Drawing.Image)(resources.GetObject("pipedown.Image")));
            this.pipedown.Location = new System.Drawing.Point(347, -4);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(100, 82);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown.TabIndex = 2;
            this.pipedown.TabStop = false;
            // 
            // pipe
            // 
            this.pipe.Enabled = false;
            this.pipe.Image = ((System.Drawing.Image)(resources.GetObject("pipe.Image")));
            this.pipe.Location = new System.Drawing.Point(321, 336);
            this.pipe.Name = "pipe";
            this.pipe.Size = new System.Drawing.Size(52, 88);
            this.pipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipe.TabIndex = 3;
            this.pipe.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-1, 420);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1008, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 4;
            this.ground.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 50;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // FlappyBirdGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1001, 528);
            this.Controls.Add(this.flappybird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipe);
            this.Controls.Add(this.pipedown);
            this.Controls.Add(this.Score);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "FlappyBirdGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FlappyBirdGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox pipedown;
        private System.Windows.Forms.PictureBox pipe;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer GameTimer;
    }
}

