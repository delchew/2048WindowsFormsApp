namespace _2048WindowsFormsApp
{
    partial class ResultsForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeButton = new System.Windows.Forms.Button();
            this.gameTypeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameColumn,
            this.userScoreColumn});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(262, 342);
            this.dataGridView.TabIndex = 0;
            // 
            // userNameColumn
            // 
            this.userNameColumn.HeaderText = "Игрок";
            this.userNameColumn.Name = "userNameColumn";
            // 
            // userScoreColumn
            // 
            this.userScoreColumn.HeaderText = "Очки";
            this.userScoreColumn.Name = "userScoreColumn";
            this.userScoreColumn.ReadOnly = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(199, 372);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // gameTypeComboBox
            // 
            this.gameTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameTypeComboBox.Items.AddRange(new object[] {
            "Игры 4х4",
            "Игры 5х5",
            "Игры 6х6",
            "Игры 8х8"});
            this.gameTypeComboBox.Location = new System.Drawing.Point(12, 372);
            this.gameTypeComboBox.Name = "gameTypeComboBox";
            this.gameTypeComboBox.Size = new System.Drawing.Size(180, 21);
            this.gameTypeComboBox.TabIndex = 2;
            this.gameTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.GameTypeComboBox_SelectedIndexChanged);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 407);
            this.ControlBox = false;
            this.Controls.Add(this.gameTypeComboBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты игр";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userScoreColumn;
        private System.Windows.Forms.ComboBox gameTypeComboBox;
    }
}