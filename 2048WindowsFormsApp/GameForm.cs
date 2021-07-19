using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class GameForm : Form
    {
        private static readonly Random random = new Random();
        private readonly Color emptyBoxColor = Color.FromArgb(205, 193, 181);
        private readonly Color backLayerColor = Color.FromArgb(187, 173, 160);
        private readonly Color lightTextColor = Color.FromArgb(249, 248, 242);
        private readonly Color darkTextColor = Color.FromArgb(119, 110, 101);
        private readonly Color[] boxColors =
        {
            Color.FromArgb(235, 228, 218),
            Color.FromArgb(236, 224, 200),
            Color.FromArgb(243, 176, 121),
            Color.FromArgb(237, 141, 83),
            Color.FromArgb(245, 124, 95),
            Color.FromArgb(235, 88, 55),
            Color.FromArgb(244, 216, 107),
            Color.FromArgb(242, 208, 75),
            Color.FromArgb(228, 192, 44),
            Color.FromArgb(237, 197, 63),
            Color.FromArgb(236, 196, 0)
        };
        private readonly int mapSize;
        private int hiScore;
        private int startGameHiScore;
        private Label[,] labelsMap;
        private Label scoreLabel;
        private Label hiScoreLabel;
        private TableLayoutPanel scoreGrid;
        private TableLayoutPanel hiScoreGrid;
        private Button restartButton;
        public int Score { get; private set; }
        public StartForm StartForm { get; private set; }
        public string UserName { get; private set; }

        public GameForm(StartForm startForm)
        {
            InitializeComponent();
            this.StartForm = startForm;
            UserName = StartForm.userNameTextBox.Text;
            mapSize = startForm.mapsize;
            BackColor = Color.FromArgb(250, 248, 239);
            Padding = new Padding(0, 20, 5, 5);
            InitializeControls();
            hiScore = GetHiScore();
            startGameHiScore = hiScore;
            hiScoreLabel.Text = hiScore.ToString();
            KeyDown += GameForm_KeyDown;
            FormClosed += GameForm_FormClosed;
            FormClosing += GameForm_FormClosing;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            InitMap();
            GenerateNumber();
            GenerateNumber();
            ShowScore();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartForm.Visible = true;
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Завершить игру? Ваши результаты не будут сохранены!", "Завершить игру", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ShowScore()
        {
            UpdateScore();
            if (Score > hiScore)
            {
                hiScore = Score;
                hiScoreLabel.Text = hiScore.ToString();
            }
        }

        private void UpdateScore() => scoreLabel.Text = Score.ToString();

        private void InitMap()
        {
            var gameGrid = new TableLayoutPanel
            {
                RowCount = mapSize,
                ColumnCount = mapSize,
                Location = new Point(10, 65),
                BackColor = backLayerColor,
                Padding = new Padding(5),
                AutoSize = true,
            };
            labelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel();
                    newLabel.TextChanged += Label_TextChanged;
                    gameGrid.Controls.Add(newLabel, j, i);
                    labelsMap[i, j] = newLabel;
                }
            }
            Controls.Add(gameGrid);
            this.Size = new Size(gameGrid.Width + 35, gameGrid.Height + 115);
        }

        private Label CreateLabel()
        {
            return new Label
            {
                BackColor = emptyBoxColor,
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold),
                Size = new Size(70, 70),
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(5)
            };
        }

        private void Label_TextChanged(object sender, EventArgs e)
        {
            (sender as Label).BackColor = GetBackColor((sender as Label).Text);
            (sender as Label).ForeColor = GetTextColor((sender as Label).Text);
        }

        private Color GetBackColor(string labelText)
        {
            if (int.TryParse(labelText, out int number))
            {
                var index = (int)Math.Log(number, 2);
                if (index > boxColors.Length - 1)
                {
                    return boxColors[boxColors.Length - 1];
                }
                return boxColors[index - 1];
            }
            return emptyBoxColor;
        }

        private Color GetTextColor(string labelText)
        {
            if (int.TryParse(labelText, out int number))
            {
                return number > 4 ? lightTextColor : darkTextColor;
            }
            return emptyBoxColor;
        }

        private void GenerateNumber()
        {
            var emptyLabelsList = new List<Label>();
            for (int i = 0; i < mapSize; i++)
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                        emptyLabelsList.Add(labelsMap[i, j]);
                }
            if (emptyLabelsList.Count == 0)
            {
                if (NoMoreSteps()) ShowEndGameForm();
                return;
            }
            var randomNumberLabel = random.Next(emptyLabelsList.Count);
            var number = random.NextDouble() < 0.8 ? 2 : 4; // вероятность выпадения 4-ки - 20%
            emptyLabelsList[randomNumberLabel].Text = number.ToString();
        }

        private int GetHiScore()
        {
            var hiScore = 0;
            var results = FileProvider.GetUserResults($"UserResultsMap{mapSize}.json");
            if (results != null)
            {
                foreach (var result in results)
                {
                    if (result.Score > hiScore)
                    {
                        hiScore = result.Score;
                    }
                }
            }
            return hiScore;
        }

        private bool NoMoreSteps()
        {
            for (int i = 1; i < mapSize - 1; i++)
                for (int j = 1; j < mapSize - 1; j++)
                {
                    if (labelsMap[i, j].Text == labelsMap[i - 1, j].Text || labelsMap[i, j].Text == labelsMap[i + 1, j].Text ||
                        labelsMap[i, j].Text == labelsMap[i, j - 1].Text || labelsMap[i, j].Text == labelsMap[i, j + 1].Text)
                    {
                        return false;
                    }
                }
            for (int i = 1; i < mapSize - 1; i++)
            {
                if (labelsMap[i, 0].Text == labelsMap[i - 1, 0].Text || labelsMap[i, 0].Text == labelsMap[i + 1, 0].Text ||
                    labelsMap[i, mapSize - 1].Text == labelsMap[i - 1, mapSize - 1].Text || labelsMap[i, mapSize - 1].Text == labelsMap[i + 1, mapSize - 1].Text)
                {
                    return false;
                }
            }
            for (int j = 1; j < mapSize - 1; j++)
            {
                if (labelsMap[0, j].Text == labelsMap[0, j - 1].Text || labelsMap[0, j].Text == labelsMap[0, j + 1].Text ||
                    labelsMap[mapSize - 1, j].Text == labelsMap[mapSize - 1, j - 1].Text || labelsMap[mapSize - 1, j].Text == labelsMap[mapSize - 1, j + 1].Text)
                {
                    return false;
                }
            }
            return true;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right: ShiftLabelsRight();
                    break;
                case Keys.Left: ShiftLabelsLeft();
                    break;
                case Keys.Up: ShiftLabelsUp();
                    break;
                case Keys.Down: ShiftLabelsDown();
                    break;
                default: return;
            }
            GenerateNumber();
            ShowScore();
        }

        private void ShiftLabelsLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (!labelsMap[i, j].IsEmpty())
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (!labelsMap[i, k].IsEmpty())
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    CombineNumLabels(labelsMap[i, j], labelsMap[i, k]);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].IsEmpty())
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (!labelsMap[i, k].IsEmpty())
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Clear();
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void ShiftLabelsRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (!labelsMap[i, j].IsEmpty())
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (!labelsMap[i, k].IsEmpty())
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    CombineNumLabels(labelsMap[i, j], labelsMap[i, k]);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].IsEmpty())
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (!labelsMap[i, k].IsEmpty())
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Clear();
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void ShiftLabelsUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (!labelsMap[i, j].IsEmpty())
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (!labelsMap[k, j].IsEmpty())
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    CombineNumLabels(labelsMap[i, j], labelsMap[k, j]);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].IsEmpty())
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (!labelsMap[k, j].IsEmpty())
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Clear();
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void ShiftLabelsDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (!labelsMap[i, j].IsEmpty())
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (!labelsMap[k, j].IsEmpty())
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    CombineNumLabels(labelsMap[i, j], labelsMap[k, j]);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].IsEmpty())
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (!labelsMap[k, j].IsEmpty())
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Clear();
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void CombineNumLabels (Label currentLabel, Label accedingLabel)
        {
            var newNumber = currentLabel.GetNumber() * 2;
            Score += newNumber;
            currentLabel.Text = newNumber.ToString();
            accedingLabel.Clear();
        }
        
        private void ShowEndGameForm()
        {
            var userResult = new UserResult
            {
                UserName = this.UserName,
                Score = this.Score
            };
            var endGameForm = new EndGameForm(userResult);
            endGameForm.ShowDialog();
            if (endGameForm.DialogResult == DialogResult.OK)
            {
                FileProvider.SaveUserResult(userResult, $"UserResultsMap{mapSize}.json");
                FormClosing -= GameForm_FormClosing;
                this.Close();
                this.StartForm.Visible = Enabled;
            }
        }

        private void InitializeControls()
        {
            scoreGrid = new TableLayoutPanel
            {
                RowCount = 2,
                ColumnCount = 1,
                BackColor = backLayerColor,
                Size = new Size(65, 45),
                Location = new Point(10, 10)
            };

            var headLabel = new Label
            {
                Text = "Очки",
                ForeColor = lightTextColor,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                MaximumSize = scoreGrid.Size
            };
            scoreGrid.Controls.Add(headLabel, 0, 0);
            scoreLabel = new Label
            {
                Text = "0",
                ForeColor = lightTextColor,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                MaximumSize = scoreGrid.Size
            };
            scoreGrid.Controls.Add(scoreLabel, 0, 1);
            Controls.Add(scoreGrid);

            hiScoreGrid = new TableLayoutPanel
            {
                RowCount = 2,
                ColumnCount = 1,
                BackColor = backLayerColor,
                Size = new Size(80, 45),
                Location = new Point(85, 10)
            };
            headLabel = new Label
            {
                Text = "Рекорд",
                ForeColor = lightTextColor,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
            };
            hiScoreGrid.Controls.Add(headLabel, 0, 0);

            hiScoreLabel = new Label
            {
                Text = "0",
                ForeColor = lightTextColor,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                MaximumSize = hiScoreGrid.Size
            };
            hiScoreGrid.Controls.Add(hiScoreLabel, 0, 1);
            Controls.Add(hiScoreGrid);

            restartButton = new UnfocusedButton
            {
                BackColor = backLayerColor,
                Image = Image.FromFile(Environment.CurrentDirectory + "\\Resources\\restart.png"),
                Size = new Size(45, 45),
                Location = new Point(175, 10),
                FlatStyle = FlatStyle.Flat,
            };
            restartButton.FlatAppearance.BorderColor = backLayerColor;
            restartButton.Click += RestartButton_Click;
            Controls.Add(restartButton);
        }
        private void RestartButton_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Перезапустить игру? Ваши результаты не будут сохранены!", "Перезапуск игры", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Score = 0;
                hiScore = startGameHiScore;
                hiScoreLabel.Text = hiScore.ToString();
                UpdateScore();
                foreach (var label in labelsMap)
                {
                    label.Text = string.Empty;
                }
                GenerateNumber();
                GenerateNumber();
            }
        }
    }
}
