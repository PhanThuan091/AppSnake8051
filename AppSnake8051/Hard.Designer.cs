namespace AppSnake8051
{
    partial class Hard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hard));
            this.buttonStartHard = new System.Windows.Forms.Button();
            this.labelScoreHard = new System.Windows.Forms.Label();
            this.labelScoreEasyText = new System.Windows.Forms.Label();
            this.labelSpeedHard = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelHighScoreHard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartHard
            // 
            this.buttonStartHard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartHard.Location = new System.Drawing.Point(132, 460);
            this.buttonStartHard.Name = "buttonStartHard";
            this.buttonStartHard.Size = new System.Drawing.Size(152, 56);
            this.buttonStartHard.TabIndex = 16;
            this.buttonStartHard.Text = "Start";
            this.buttonStartHard.UseVisualStyleBackColor = true;
            this.buttonStartHard.Click += new System.EventHandler(this.buttonStartHard_Click);
            // 
            // labelScoreHard
            // 
            this.labelScoreHard.AutoSize = true;
            this.labelScoreHard.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreHard.Location = new System.Drawing.Point(255, 98);
            this.labelScoreHard.Name = "labelScoreHard";
            this.labelScoreHard.Size = new System.Drawing.Size(0, 38);
            this.labelScoreHard.TabIndex = 14;
            // 
            // labelScoreEasyText
            // 
            this.labelScoreEasyText.AutoSize = true;
            this.labelScoreEasyText.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreEasyText.Location = new System.Drawing.Point(48, 98);
            this.labelScoreEasyText.Name = "labelScoreEasyText";
            this.labelScoreEasyText.Size = new System.Drawing.Size(122, 38);
            this.labelScoreEasyText.TabIndex = 13;
            this.labelScoreEasyText.Text = "Score: ";
            // 
            // labelSpeedHard
            // 
            this.labelSpeedHard.AutoSize = true;
            this.labelSpeedHard.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeedHard.Location = new System.Drawing.Point(48, 32);
            this.labelSpeedHard.Name = "labelSpeedHard";
            this.labelSpeedHard.Size = new System.Drawing.Size(170, 38);
            this.labelSpeedHard.TabIndex = 12;
            this.labelSpeedHard.Text = "Speed: 90";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(844, 570);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            this.serialPort1.WriteBufferSize = 4096;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_Hard_DataReceived);
            // 
            // labelHighScoreHard
            // 
            this.labelHighScoreHard.AutoSize = true;
            this.labelHighScoreHard.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighScoreHard.Location = new System.Drawing.Point(48, 346);
            this.labelHighScoreHard.Name = "labelHighScoreHard";
            this.labelHighScoreHard.Size = new System.Drawing.Size(53, 38);
            this.labelHighScoreHard.TabIndex = 18;
            this.labelHighScoreHard.Text = "....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = "High score";
            // 
            // Hard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 570);
            this.Controls.Add(this.buttonStartHard);
            this.Controls.Add(this.labelScoreHard);
            this.Controls.Add(this.labelScoreEasyText);
            this.Controls.Add(this.labelSpeedHard);
            this.Controls.Add(this.labelHighScoreHard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Hard";
            this.Text = "Hard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hard_Close);
            this.Load += new System.EventHandler(this.Hard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStartHard;
        private System.Windows.Forms.Label labelScoreHard;
        private System.Windows.Forms.Label labelScoreEasyText;
        private System.Windows.Forms.Label labelSpeedHard;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelHighScoreHard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}