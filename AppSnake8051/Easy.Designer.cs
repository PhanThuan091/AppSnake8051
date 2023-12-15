namespace AppSnake8051
{
    partial class Easy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Easy));
            this.labelSpeedEasy = new System.Windows.Forms.Label();
            this.labelScoreEasyText = new System.Windows.Forms.Label();
            this.labelScoreEasy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelHighScoreEasy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStartEasy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSpeedEasy
            // 
            this.labelSpeedEasy.AutoSize = true;
            this.labelSpeedEasy.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeedEasy.Location = new System.Drawing.Point(53, 56);
            this.labelSpeedEasy.Name = "labelSpeedEasy";
            this.labelSpeedEasy.Size = new System.Drawing.Size(170, 38);
            this.labelSpeedEasy.TabIndex = 0;
            this.labelSpeedEasy.Text = "Speed: 20";
            // 
            // labelScoreEasyText
            // 
            this.labelScoreEasyText.AutoSize = true;
            this.labelScoreEasyText.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreEasyText.Location = new System.Drawing.Point(53, 122);
            this.labelScoreEasyText.Name = "labelScoreEasyText";
            this.labelScoreEasyText.Size = new System.Drawing.Size(122, 38);
            this.labelScoreEasyText.TabIndex = 1;
            this.labelScoreEasyText.Text = "Score: ";
            // 
            // labelScoreEasy
            // 
            this.labelScoreEasy.AutoSize = true;
            this.labelScoreEasy.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreEasy.Location = new System.Drawing.Point(260, 122);
            this.labelScoreEasy.Name = "labelScoreEasy";
            this.labelScoreEasy.Size = new System.Drawing.Size(0, 38);
            this.labelScoreEasy.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            this.serialPort1.WriteBufferSize = 4096;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // labelHighScoreEasy
            // 
            this.labelHighScoreEasy.AutoSize = true;
            this.labelHighScoreEasy.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighScoreEasy.Location = new System.Drawing.Point(53, 323);
            this.labelHighScoreEasy.Name = "labelHighScoreEasy";
            this.labelHighScoreEasy.Size = new System.Drawing.Size(44, 38);
            this.labelHighScoreEasy.TabIndex = 6;
            this.labelHighScoreEasy.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "High score";
            // 
            // buttonStartEasy
            // 
            this.buttonStartEasy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartEasy.Location = new System.Drawing.Point(128, 446);
            this.buttonStartEasy.Name = "buttonStartEasy";
            this.buttonStartEasy.Size = new System.Drawing.Size(152, 56);
            this.buttonStartEasy.TabIndex = 4;
            this.buttonStartEasy.Text = "Start";
            this.buttonStartEasy.UseVisualStyleBackColor = true;
            this.buttonStartEasy.Click += new System.EventHandler(this.buttonStartEasy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Easy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(844, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelHighScoreEasy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStartEasy);
            this.Controls.Add(this.labelScoreEasy);
            this.Controls.Add(this.labelScoreEasyText);
            this.Controls.Add(this.labelSpeedEasy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Easy";
            this.Text = "Easy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Easy_FormClosing);
            this.Load += new System.EventHandler(this.Easy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSpeedEasy;
        private System.Windows.Forms.Label labelScoreEasyText;
        private System.Windows.Forms.Label labelScoreEasy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelHighScoreEasy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStartEasy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}