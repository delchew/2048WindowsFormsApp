using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class EndGameForm : Form
    {
        public EndGameForm(UserResult userResult)
        {
            InitializeComponent();
            userNameLabel.Text = string.Format("Уважаемый {0}!", userResult.UserName);
            infoLabel.Text = "Игра окончена! Больше ходов нет.";
            gameResultPictureBox.Image = Image.FromFile(Environment.CurrentDirectory + "\\Resources\\2048.png");
            scoreLabel.Text = userResult.Score.ToString();
        }
    }
}
