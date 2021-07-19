namespace _2048WindowsFormsApp
{
    partial class EndGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGameForm));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.gameResultPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameResultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(12, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(67, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Имя игрока";
            // 
            // OkButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(265, 138);
            this.okButton.Name = "OkButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // Label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 65);
            this.label.Name = "Label";
            this.label.Size = new System.Drawing.Size(36, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Счёт: ";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(46, 65);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(33, 13);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "score";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 38);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(76, 13);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "Инфо об игре";
            // 
            // GameResultPictureBox
            // 
            this.gameResultPictureBox.Location = new System.Drawing.Point(240, 9);
            this.gameResultPictureBox.Name = "GameResultPictureBox";
            this.gameResultPictureBox.Size = new System.Drawing.Size(100, 100);
            this.gameResultPictureBox.TabIndex = 6;
            this.gameResultPictureBox.TabStop = false;
            // 
            // EndGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 173);
            this.ControlBox = false;
            this.Controls.Add(this.gameResultPictureBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.userNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            ((System.ComponentModel.ISupportInitialize)(this.gameResultPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.PictureBox gameResultPictureBox;
    }
}