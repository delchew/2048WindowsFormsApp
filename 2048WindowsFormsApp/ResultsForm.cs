using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class ResultsForm : Form
    {
        private List<UserResult> userResults;
        private int[] gameTypes = { 4, 5, 6, 8 };

        public ResultsForm()
        {
            InitializeComponent();
            gameTypeComboBox.SelectedIndex = 0;
        }

        private void FillStatisticTable()
        {
            dataGridView.Rows.Clear();
            if (userResults == null) return;
            userResults.Sort();
            for (int i = userResults.Count - 1; i >= 0; i--)
            {
                dataGridView.Rows.Add(userResults[i].UserName, userResults[i].Score);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void GameTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filePath = $"UserResultsMap{gameTypes[(sender as ComboBox).SelectedIndex]}.json";
            userResults = FileProvider.GetUserResults(filePath);
            FillStatisticTable();
        }

        
    }
}
