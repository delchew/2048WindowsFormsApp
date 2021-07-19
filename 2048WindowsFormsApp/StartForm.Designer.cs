namespace _2048WindowsFormsApp
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.field8RadioButton = new System.Windows.Forms.RadioButton();
            this.field6RadioButton = new System.Windows.Forms.RadioButton();
            this.field5RadioButton = new System.Windows.Forms.RadioButton();
            this.field4RadioButton = new System.Windows.Forms.RadioButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameButton = new System.Windows.Forms.Button();
            this.exitGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.field8RadioButton);
            this.groupBox1.Controls.Add(this.field6RadioButton);
            this.groupBox1.Controls.Add(this.field5RadioButton);
            this.groupBox1.Controls.Add(this.field4RadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор поля";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2048WindowsFormsApp.Properties.Resources._2048;
            this.pictureBox1.Location = new System.Drawing.Point(94, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // field8RadioButton
            // 
            this.field8RadioButton.AutoSize = true;
            this.field8RadioButton.Location = new System.Drawing.Point(214, 103);
            this.field8RadioButton.Name = "field8RadioButton";
            this.field8RadioButton.Size = new System.Drawing.Size(48, 17);
            this.field8RadioButton.TabIndex = 3;
            this.field8RadioButton.Tag = "8";
            this.field8RadioButton.Text = "8 х 8";
            this.field8RadioButton.UseVisualStyleBackColor = true;
            this.field8RadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // field6RadioButton
            // 
            this.field6RadioButton.AutoSize = true;
            this.field6RadioButton.Location = new System.Drawing.Point(31, 103);
            this.field6RadioButton.Name = "field6RadioButton";
            this.field6RadioButton.Size = new System.Drawing.Size(48, 17);
            this.field6RadioButton.TabIndex = 2;
            this.field6RadioButton.Tag = "6";
            this.field6RadioButton.Text = "6 х 6";
            this.field6RadioButton.UseVisualStyleBackColor = true;
            this.field6RadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // field5RadioButton
            // 
            this.field5RadioButton.AutoSize = true;
            this.field5RadioButton.Location = new System.Drawing.Point(214, 39);
            this.field5RadioButton.Name = "field5RadioButton";
            this.field5RadioButton.Size = new System.Drawing.Size(48, 17);
            this.field5RadioButton.TabIndex = 1;
            this.field5RadioButton.Tag = "5";
            this.field5RadioButton.Text = "5 х 5";
            this.field5RadioButton.UseVisualStyleBackColor = true;
            this.field5RadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // field4RadioButton
            // 
            this.field4RadioButton.AutoSize = true;
            this.field4RadioButton.Checked = true;
            this.field4RadioButton.Location = new System.Drawing.Point(31, 39);
            this.field4RadioButton.Name = "field4RadioButton";
            this.field4RadioButton.Size = new System.Drawing.Size(48, 17);
            this.field4RadioButton.TabIndex = 0;
            this.field4RadioButton.TabStop = true;
            this.field4RadioButton.Tag = "4";
            this.field4RadioButton.Text = "4 х 4";
            this.field4RadioButton.UseVisualStyleBackColor = true;
            this.field4RadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.результатыToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(319, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.правилаToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newGameToolStripMenuItem.Text = "Новая игра";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.StartGame);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitGame);
            // 
            // правилаToolStripMenuItem
            // 
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.правилаToolStripMenuItem.Text = "Правила";
            this.правилаToolStripMenuItem.Click += new System.EventHandler(this.RulesToolStripMenuItem_Click);
            // 
            // результатыToolStripMenuItem
            // 
            this.результатыToolStripMenuItem.Name = "результатыToolStripMenuItem";
            this.результатыToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.результатыToolStripMenuItem.Text = "Результаты";
            this.результатыToolStripMenuItem.Click += new System.EventHandler(this.ResultsToolStripMenuItem_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(106, 258);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(91, 23);
            this.startGameButton.TabIndex = 2;
            this.startGameButton.Text = "Начать игру";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.StartGame);
            // 
            // exitGameButton
            // 
            this.exitGameButton.Location = new System.Drawing.Point(216, 258);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(89, 23);
            this.exitGameButton.TabIndex = 3;
            this.exitGameButton.Text = "Выход";
            this.exitGameButton.UseVisualStyleBackColor = true;
            this.exitGameButton.Click += new System.EventHandler(this.ExitGame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя игрока";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(106, 218);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.userNameTextBox.TabIndex = 5;
            this.userNameTextBox.Text = "Игрок1";
            this.userNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserNameTextBox_KeyUp);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 293);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitGameButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.RadioButton field8RadioButton;
        private System.Windows.Forms.RadioButton field6RadioButton;
        private System.Windows.Forms.RadioButton field5RadioButton;
        private System.Windows.Forms.RadioButton field4RadioButton;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыToolStripMenuItem;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button exitGameButton;
        private System.Windows.Forms.ToolStripMenuItem правилаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox userNameTextBox;
    }
}