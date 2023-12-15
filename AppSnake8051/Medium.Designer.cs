namespace AppSnake8051
{
    partial class Medium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medium));
            this.buttonStartMedium = new System.Windows.Forms.Button();
            this.labelScoreMedium = new System.Windows.Forms.Label();
            this.labelScoreEasyText = new System.Windows.Forms.Label();
            this.labelSpeedEasy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.labelHighScoreMedium = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartMedium
            // 
            this.buttonStartMedium.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartMedium.Location = new System.Drawing.Point(123, 449);
            this.buttonStartMedium.Name = "buttonStartMedium";
            this.buttonStartMedium.Size = new System.Drawing.Size(152, 56);
            this.buttonStartMedium.TabIndex = 9;
            this.buttonStartMedium.Text = "Start";
            this.buttonStartMedium.UseVisualStyleBackColor = true;
            this.buttonStartMedium.Click += new System.EventHandler(this.buttonStartMedium_Click);
            // 
            // labelScoreMedium
            // 
            this.labelScoreMedium.AutoSize = true;
            this.labelScoreMedium.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreMedium.Location = new System.Drawing.Point(255, 125);
            this.labelScoreMedium.Name = "labelScoreMedium";
            this.labelScoreMedium.Size = new System.Drawing.Size(0, 38);
            this.labelScoreMedium.TabIndex = 7;
            // 
            // labelScoreEasyText
            // 
            this.labelScoreEasyText.AutoSize = true;
            this.labelScoreEasyText.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreEasyText.Location = new System.Drawing.Point(48, 125);
            this.labelScoreEasyText.Name = "labelScoreEasyText";
            this.labelScoreEasyText.Size = new System.Drawing.Size(122, 38);
            this.labelScoreEasyText.TabIndex = 6;
            this.labelScoreEasyText.Text = "Score: ";
            // 
            // labelSpeedEasy
            // 
            this.labelSpeedEasy.AutoSize = true;
            this.labelSpeedEasy.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeedEasy.Location = new System.Drawing.Point(48, 59);
            this.labelSpeedEasy.Name = "labelSpeedEasy";
            this.labelSpeedEasy.Size = new System.Drawing.Size(170, 38);
            this.labelSpeedEasy.TabIndex = 5;
            this.labelSpeedEasy.Text = "Speed: 60";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM6";
            this.serialPort2.WriteBufferSize = 4096;
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // labelHighScoreMedium
            // 
            this.labelHighScoreMedium.AutoSize = true;
            this.labelHighScoreMedium.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighScoreMedium.Location = new System.Drawing.Point(57, 343);
            this.labelHighScoreMedium.Name = "labelHighScoreMedium";
            this.labelHighScoreMedium.Size = new System.Drawing.Size(44, 38);
            this.labelHighScoreMedium.TabIndex = 11;
            this.labelHighScoreMedium.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "High score: ";
            // 
            // Medium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 570);
            this.Controls.Add(this.labelHighScoreMedium);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStartMedium);
            this.Controls.Add(this.labelScoreMedium);
            this.Controls.Add(this.labelScoreEasyText);
            this.Controls.Add(this.labelSpeedEasy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Medium";
            this.Text = "Medium";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Medium_FormClosing);
            this.Load += new System.EventHandler(this.Medium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartMedium;
        private System.Windows.Forms.Label labelScoreMedium;
        private System.Windows.Forms.Label labelScoreEasyText;
        private System.Windows.Forms.Label labelSpeedEasy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label labelHighScoreMedium;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}