using System;
using System.IO;
using System.Windows.Forms;

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "CSV 讀取器";
            getScoresButton.Text = "取得分數";
            exitButton.Text = "離開";
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            averagesListBox.Items.Clear();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV 檔案 (*.csv)|*.csv";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader inputFile = File.OpenText(openFile.FileName);
                    string line;

                    while (!inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine();
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        // 拆分「姓名」與「成績」
                        string[] parts = line.Split(':');
                        if (parts.Length != 2)
                        {
                            averagesListBox.Items.Add("格式錯誤：" + line);
                            continue;
                        }

                        string name = parts[0].Trim();
                        string[] scores = parts[1].Split(',');

                        double total = 0;
                        int validCount = 0;

                        foreach (string scoreStr in scores)
                        {
                            if (int.TryParse(scoreStr.Trim(), out int score))
                            {
                                total += score;
                                validCount++;
                            }
                        }

                        if (validCount > 0)
                        {
                            double average = total / validCount;
                            averagesListBox.Items.Add($"{name} 的平均分數為：{average:F2}");
                        }
                        else
                        {
                            averagesListBox.Items.Add($"{name} 的資料無法解析");
                        }
                    }

                    inputFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取檔案時發生錯誤：" + ex.Message);
                }
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void averagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 可以留空
        }
    }
}


