using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class StartForm : Form
    {
        public int mapsize { get; set; }
        private readonly string rules = "В начале игры вы выбираете размер игрового поля. " +
            "При старте вам выдается два кирпичика с цифрами \"2\" или \"4\"," +
            " нажимая стрелки клавиатуры вверх, вправо, влево или вниз, все ваши кирпичики будут смещаться в ту же сторону. " +
            "При соприкосновении клеточек с одним и тем же номиналом, они объединяются и создают сумму вдвое больше. " +
            "Игра заканчивается тогда, когда все пустые ячейки заполнены, и вы больше не можете передвигать клеточки ни в одну из сторон. " +
            "Ну, или когда на одном из кубов, наконец, появилась заветная цифра 2048.";
        public StartForm()
        {
            InitializeComponent();
            mapsize = 4;
        }

        private void ExitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartGame(object sender, EventArgs e)
        {
            Visible = false;
            var gameForm = new GameForm(this);
            gameForm.Show();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                if (int.TryParse((sender as RadioButton).Tag.ToString(), out int size))
                    mapsize = size;
            }
        }

        private void RulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rules, "Правила");
        }

        private void UserNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
            {
                startGameButton.Enabled = false;
                newGameToolStripMenuItem.Enabled = false;
            }
            else
            {
                startGameButton.Enabled = true;
                newGameToolStripMenuItem.Enabled = true;
            }
        }

        private void ResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }
    }
}
