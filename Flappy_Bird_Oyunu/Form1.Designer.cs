
namespace Flappy_Bird_Oyunu
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
            this.PcbFlappyBird = new System.Windows.Forms.PictureBox();
            this.PcbBoruUst = new System.Windows.Forms.PictureBox();
            this.PcbBoruAlt = new System.Windows.Forms.PictureBox();
            this.PcbZemin = new System.Windows.Forms.PictureBox();
            this.LblScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PcbFlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBoruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBoruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbZemin)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbFlappyBird
            // 
            this.PcbFlappyBird.Image = ((System.Drawing.Image)(resources.GetObject("PcbFlappyBird.Image")));
            this.PcbFlappyBird.Location = new System.Drawing.Point(107, 300);
            this.PcbFlappyBird.Name = "PcbFlappyBird";
            this.PcbFlappyBird.Size = new System.Drawing.Size(78, 52);
            this.PcbFlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbFlappyBird.TabIndex = 0;
            this.PcbFlappyBird.TabStop = false;
            // 
            // PcbBoruUst
            // 
            this.PcbBoruUst.Image = ((System.Drawing.Image)(resources.GetObject("PcbBoruUst.Image")));
            this.PcbBoruUst.Location = new System.Drawing.Point(597, 1);
            this.PcbBoruUst.Name = "PcbBoruUst";
            this.PcbBoruUst.Size = new System.Drawing.Size(100, 179);
            this.PcbBoruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbBoruUst.TabIndex = 1;
            this.PcbBoruUst.TabStop = false;
            // 
            // PcbBoruAlt
            // 
            this.PcbBoruAlt.Image = ((System.Drawing.Image)(resources.GetObject("PcbBoruAlt.Image")));
            this.PcbBoruAlt.Location = new System.Drawing.Point(516, 440);
            this.PcbBoruAlt.Name = "PcbBoruAlt";
            this.PcbBoruAlt.Size = new System.Drawing.Size(100, 162);
            this.PcbBoruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbBoruAlt.TabIndex = 2;
            this.PcbBoruAlt.TabStop = false;
            // 
            // PcbZemin
            // 
            this.PcbZemin.Image = ((System.Drawing.Image)(resources.GetObject("PcbZemin.Image")));
            this.PcbZemin.Location = new System.Drawing.Point(-2, 597);
            this.PcbZemin.Name = "PcbZemin";
            this.PcbZemin.Size = new System.Drawing.Size(806, 50);
            this.PcbZemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbZemin.TabIndex = 3;
            this.PcbZemin.TabStop = false;
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblScore.Location = new System.Drawing.Point(60, 663);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(125, 35);
            this.LblScore.TabIndex = 4;
            this.LblScore.Text = "Score : 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 717);
            this.Controls.Add(this.PcbFlappyBird);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.PcbZemin);
            this.Controls.Add(this.PcbBoruAlt);
            this.Controls.Add(this.PcbBoruUst);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.PcbFlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBoruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBoruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbZemin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbFlappyBird;
        private System.Windows.Forms.PictureBox PcbBoruUst;
        private System.Windows.Forms.PictureBox PcbBoruAlt;
        private System.Windows.Forms.PictureBox PcbZemin;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Timer GameTimer;
    }
}

