namespace AutoWaterFarmer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tmrMouse = new System.Windows.Forms.Timer(this.components);
            this.lblMouse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx1x = new System.Windows.Forms.TextBox();
            this.tbx1y = new System.Windows.Forms.TextBox();
            this.tbx2y = new System.Windows.Forms.TextBox();
            this.tbx2x = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPossitions = new System.Windows.Forms.Button();
            this.tbxHbBRY = new System.Windows.Forms.TextBox();
            this.tbxHbBRX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxHbTLY = new System.Windows.Forms.TextBox();
            this.tbxHbTLX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 91);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 29);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(115, 50);
            this.trackBar1.TabIndex = 1;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(12, 9);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(44, 17);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "speed";
            // 
            // tmrMouse
            // 
            this.tmrMouse.Enabled = true;
            this.tmrMouse.Tick += new System.EventHandler(this.tmrMouse_Tick);
            // 
            // lblMouse
            // 
            this.lblMouse.AutoSize = true;
            this.lblMouse.Location = new System.Drawing.Point(12, 189);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(43, 17);
            this.lblMouse.TabIndex = 3;
            this.lblMouse.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "crafting in";
            // 
            // tbx1x
            // 
            this.tbx1x.Location = new System.Drawing.Point(174, 29);
            this.tbx1x.Name = "tbx1x";
            this.tbx1x.Size = new System.Drawing.Size(110, 25);
            this.tbx1x.TabIndex = 5;
            // 
            // tbx1y
            // 
            this.tbx1y.Location = new System.Drawing.Point(174, 60);
            this.tbx1y.Name = "tbx1y";
            this.tbx1y.Size = new System.Drawing.Size(110, 25);
            this.tbx1y.TabIndex = 6;
            // 
            // tbx2y
            // 
            this.tbx2y.Location = new System.Drawing.Point(318, 60);
            this.tbx2y.Name = "tbx2y";
            this.tbx2y.Size = new System.Drawing.Size(110, 25);
            this.tbx2y.TabIndex = 9;
            // 
            // tbx2x
            // 
            this.tbx2x.Location = new System.Drawing.Point(318, 29);
            this.tbx2x.Name = "tbx2x";
            this.tbx2x.Size = new System.Drawing.Size(110, 25);
            this.tbx2x.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "crafting out";
            // 
            // btnPossitions
            // 
            this.btnPossitions.Location = new System.Drawing.Point(174, 181);
            this.btnPossitions.Name = "btnPossitions";
            this.btnPossitions.Size = new System.Drawing.Size(254, 25);
            this.btnPossitions.TabIndex = 10;
            this.btnPossitions.Text = "set possitions";
            this.btnPossitions.UseVisualStyleBackColor = true;
            this.btnPossitions.Click += new System.EventHandler(this.btnPossitions_Click);
            // 
            // tbxHbBRY
            // 
            this.tbxHbBRY.Location = new System.Drawing.Point(318, 150);
            this.tbxHbBRY.Name = "tbxHbBRY";
            this.tbxHbBRY.Size = new System.Drawing.Size(110, 25);
            this.tbxHbBRY.TabIndex = 16;
            // 
            // tbxHbBRX
            // 
            this.tbxHbBRX.Location = new System.Drawing.Point(318, 119);
            this.tbxHbBRX.Name = "tbxHbBRX";
            this.tbxHbBRX.Size = new System.Drawing.Size(110, 25);
            this.tbxHbBRX.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "hotbar bottom right";
            // 
            // tbxHbTLY
            // 
            this.tbxHbTLY.Location = new System.Drawing.Point(174, 150);
            this.tbxHbTLY.Name = "tbxHbTLY";
            this.tbxHbTLY.Size = new System.Drawing.Size(110, 25);
            this.tbxHbTLY.TabIndex = 13;
            // 
            // tbxHbTLX
            // 
            this.tbxHbTLX.Location = new System.Drawing.Point(174, 119);
            this.tbxHbTLX.Name = "tbxHbTLX";
            this.tbxHbTLX.Size = new System.Drawing.Size(110, 25);
            this.tbxHbTLX.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "hotbar top left";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Maus possition";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 245);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxHbBRY);
            this.Controls.Add(this.tbxHbBRX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxHbTLY);
            this.Controls.Add(this.tbxHbTLX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPossitions);
            this.Controls.Add(this.tbx2y);
            this.Controls.Add(this.tbx2x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx1y);
            this.Controls.Add(this.tbx1x);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Timer tmrMouse;
        private System.Windows.Forms.Label lblMouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx1x;
        private System.Windows.Forms.TextBox tbx1y;
        private System.Windows.Forms.TextBox tbx2y;
        private System.Windows.Forms.TextBox tbx2x;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPossitions;
        private System.Windows.Forms.TextBox tbxHbBRY;
        private System.Windows.Forms.TextBox tbxHbBRX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxHbTLY;
        private System.Windows.Forms.TextBox tbxHbTLX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
