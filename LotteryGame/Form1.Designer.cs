namespace LotteryGame
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            Animation = new System.Windows.Forms.Timer(components);
            HideAnimation = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(15, 45);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(15, 314);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(193, 23);
            progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(214, 311);
            label1.Name = "label1";
            label1.Size = new Size(43, 30);
            label1.TabIndex = 2;
            label1.Text = "0%";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // Animation
            // 
            Animation.Interval = 40;
            Animation.Tick += Animation_Tick;
            // 
            // HideAnimation
            // 
            HideAnimation.Interval = 40;
            HideAnimation.Tick += HideAnimation_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 9);
            label2.Name = "label2";
            label2.Size = new Size(188, 30);
            label2.TabIndex = 3;
            label2.Text = "The Loterry Game";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 353);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label label1;
        private System.Windows.Forms.Timer Animation;
        private System.Windows.Forms.Timer HideAnimation;
        private Label label2;
    }
}