namespace War_Hawley
{
    partial class WarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.playerScoreTextBox = new System.Windows.Forms.TextBox();
            this.computerScoreTextBox = new System.Windows.Forms.TextBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Score:";
            // 
            // restartButton
            // 
            this.restartButton.Enabled = false;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(213, 301);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(122, 42);
            this.restartButton.TabIndex = 2;
            this.restartButton.Text = "Restart Game";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(130, 349);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 41);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(39, 301);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(134, 42);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play Card";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // playerScoreTextBox
            // 
            this.playerScoreTextBox.Enabled = false;
            this.playerScoreTextBox.Location = new System.Drawing.Point(248, 266);
            this.playerScoreTextBox.Name = "playerScoreTextBox";
            this.playerScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerScoreTextBox.TabIndex = 6;
            this.playerScoreTextBox.Text = "0";
            this.playerScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // computerScoreTextBox
            // 
            this.computerScoreTextBox.Enabled = false;
            this.computerScoreTextBox.Location = new System.Drawing.Point(179, 43);
            this.computerScoreTextBox.Name = "computerScoreTextBox";
            this.computerScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.computerScoreTextBox.TabIndex = 7;
            this.computerScoreTextBox.Text = "0";
            this.computerScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Image = global::War_Hawley.Properties.Resources.beach_back;
            this.playerPictureBox.Location = new System.Drawing.Point(277, 154);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(71, 96);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playerPictureBox.TabIndex = 8;
            this.playerPictureBox.TabStop = false;
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.Image = global::War_Hawley.Properties.Resources.beach_back;
            this.computerPictureBox.Location = new System.Drawing.Point(39, 77);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(71, 96);
            this.computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.computerPictureBox.TabIndex = 9;
            this.computerPictureBox.TabStop = false;
            // 
            // WarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 402);
            this.Controls.Add(this.computerPictureBox);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.computerScoreTextBox);
            this.Controls.Add(this.playerScoreTextBox);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WarForm";
            this.Text = "War";
            this.Load += new System.EventHandler(this.restartButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TextBox playerScoreTextBox;
        private System.Windows.Forms.TextBox computerScoreTextBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.PictureBox computerPictureBox;
    }
}

